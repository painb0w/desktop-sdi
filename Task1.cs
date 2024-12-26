using System.Collections.Concurrent;

public static class TextAnalysisHelper
{
    public static async Task<Dictionary<string, int>> ProcessTexts(string[] files, string[] words)
    {
        var wordSet = new HashSet<string>(words, StringComparer.OrdinalIgnoreCase);

        // map
        var localFrequencies = files.AsParallel().Select(async file =>
        {
            var text = await File.ReadAllTextAsync(file);

            return text
                .Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?', ';', ':', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => wordSet.Contains(word, StringComparer.OrdinalIgnoreCase))
                .GroupBy(word => word, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.Count());
        }).ToList();

        // reduce
        var globalFrequencies = new ConcurrentDictionary<string, int>();

        foreach (var freq in localFrequencies)
        {
            foreach (var kvp in await freq)
            {
                globalFrequencies.AddOrUpdate(kvp.Key, kvp.Value, (key, oldValue) => oldValue + kvp.Value);
            }
        }

        return globalFrequencies.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}
