using HtmlAgilityPack;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

public class CrawlerData
{
    public string url { get; set; }
    public List<string> imagesLinks { get; set; }
    public List<string> subLinks { get; set; }
    public List<CrawlerData> childs { get; set; }
    public long time { get; set; }
}
public class TreeLevelInfo
{
    public int Height { get; set; }
    public long Time { get; set; }
    public int NodeCount { get; set; }
    public string Leaves { get; set; }
}

class Crawler
{
    public bool finished = false;
    public List<string> images = new List<string>();
    public List<string> subLinks = new List<string>();
    public List<Crawler> childs = new List<Crawler>();

    object imagesLocker = new object();
    object subLinksLocker = new object();
    object childLocker = new object();

    private readonly string _url;
    private readonly int _depth;

    Stopwatch stopwatch = new Stopwatch();
    long time;

    public Crawler(string url, int depth)
    {
        _url = url;
        _depth = depth;
    }

    private async Task<CrawlerData> CreateDataToJsonAsync()
    {
        var data = new CrawlerData
        {
            url = this._url,
            imagesLinks = this.images,
            subLinks = this.subLinks,
            time = this.time,
        };

        var datas = new List<CrawlerData>();
        var childTasks = this.childs.Select(child => Task.Run(() => child.CreateDataToJsonAsync()));
        var childResults = await Task.WhenAll(childTasks);

        datas.AddRange(childResults);
        data.childs = datas;

        return data;
    }

    public async Task SaveToJsonAsync(string path)
    {
        try
        {
            CrawlerData data = await CreateDataToJsonAsync();

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };

            var json = JsonSerializer.Serialize(data, options);

            await File.WriteAllTextAsync(path, json);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Access denied: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }


    public async Task Crawl()
    {
        if (_depth == 0) { return; }
        stopwatch.Start();
        await GetImageLinks();
        await GetSubLinks();
        await GetChilds();
        stopwatch.Stop();

        time = stopwatch.ElapsedMilliseconds;
        finished = true;
    }

    private async Task GetSubLinks()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument htmlDoc;

        try
        {
            htmlDoc = await web.LoadFromWebAsync(_url);
        }
        catch (Exception ex) { return; }

        if (htmlDoc is null) { return; }

        var links = htmlDoc.DocumentNode.SelectNodes("//a");

        if (links is null) { return; }

        foreach (var link in links)
        {
            string src = link.Attributes["href"]?.Value;
            if (src is null) { continue; }
            if (!src.Contains("https://"))
            {
                src = _url + src;
            }

            if (_url + '/' == src)
            {
                continue;
            }

            lock (subLinksLocker)
            {
                subLinks.Add(src);
            }
        }
    }

    private async Task GetChilds()
    {
        if (_depth == 1) { return; }

        var tasks = new List<Task>();

        foreach (var subLink in subLinks)
        {
            var child = new Crawler(subLink, _depth - 1);

            tasks.Add(Task.Run(async () =>
            {
                await child.Crawl();
                lock (childLocker)
                {
                    childs.Add(child);
                }
            }));
        }

        await Task.WhenAll(tasks);
    }

    private async Task GetImageLinks()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument htmlDoc;
        try
        {
            htmlDoc = await web.LoadFromWebAsync(_url);
        }
        catch (Exception) { return; }

        var links = htmlDoc.DocumentNode.SelectNodes("//img");
        if (links is null) { return; }

        foreach (var link in links)
        {
            string src = link.Attributes["src"].Value;
            if (src is null) { continue; }
            if (!src.Contains("https://"))
            {
                src = _url + src;
            }
            lock (imagesLocker)
            {
                images.Add(src);
            }
        }
    }

    public async Task LoadDataFromJsonAsync(string filePath, DataGridView gridView)
    {
        if (!File.Exists(filePath))
        {
            MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            var json = await File.ReadAllTextAsync(filePath);
            var root = JsonSerializer.Deserialize<CrawlerData>(json);

            if (root == null)
            {
                MessageBox.Show("Некорректный формат JSON!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var treeInfo = await Task.Run(() => GetTreeInfo(root));

            foreach (var info in treeInfo)
            {
                gridView.Rows.Add(info.Height, info.Time, info.NodeCount, info.Leaves);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при чтении JSON: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private List<TreeLevelInfo> GetTreeInfo(CrawlerData root)
    {
        var levels = new List<TreeLevelInfo>();
        TraverseTree(root, 1, levels);
        return levels;
    }

    private void TraverseTree(CrawlerData node, int height, List<TreeLevelInfo> levels)
    {
        if (node == null) return;

        var levelInfo = levels.FirstOrDefault(l => l.Height == height);
        if (levelInfo == null)
        {
            levelInfo = new TreeLevelInfo { Height = height, Time = 0, NodeCount = 0, Leaves = "" };
            levels.Add(levelInfo);
        }

        levelInfo.NodeCount++;
        levelInfo.Time += node.time;

        if (string.IsNullOrEmpty(levelInfo.Leaves) && node.subLinks != null && node.subLinks.Any())
        {
            levelInfo.Leaves = string.Join(", ", node.subLinks.Take(3));
        }

        if (node.childs != null)
        {
            foreach (var child in node.childs)
            {
                TraverseTree(child, height + 1, levels);
            }
        }
    }



}
