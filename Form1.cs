using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace sdi_mega_proj
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;
        private readonly string textsDirectoryPath = @"C:/University/5 semester/sharp projects/parallel/texts"; // указать путь к директориями с файлами текстов

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void GenerateDataButton_Click(object sender, EventArgs e)
        {
            GenerateDataButton.Enabled = false;
            GenerateDataButton.Text = "Generating...";

            employees = await Task.Run(() =>
            {
                return DataGenerator.GenerateEmployees(1000);
            }); // установил фиксированное число сотрудников

            //await Task.Run(() =>
            //{
            //    Thread.Sleep(5000);
            //    var employees = DataGenerator.GenerateEmployees(1000);
            //}); //для теста асинхронности

            GenerateDataButton.Enabled = true;
            GenerateDataButton.Text = "Generate data";

            EmployeesGrid.DataSource = employees.Take(100)
                .Select(e => new { e.FullName, OrderCount = e.Orders.Count })
                .ToList();

            OrdersGrid.DataSource = employees
                .SelectMany(e => e.Orders)
                .Take(500)
                .Select(o => new { o.OrderDate, o.OrderAmount })
                .ToList();

            //int rowCount = OrdersGrid.Rows.Count; //для проверки, что ровно 500 заказов
            //MessageBox.Show($"Amount of orders: {rowCount}");

            //MessageBox.Show($"employees total: {employees.Count}"); //для проверки числа сотрудников
            //MessageBox.Show($"Orders total: {employees.SelectMany(e => e.Orders).Count()}");
        }


        private async void ApplyFilterFIOButton_Click(object sender, EventArgs e)
        {
            string filterText = FIOTextBox.Text;
            string filterType = FIOComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(filterType))
            {
                MessageBox.Show("Choose full name filtration type first !");
                return;
            }

            //MessageBox.Show($"UI thread: {Thread.CurrentThread.ManagedThreadId}");

            var stopwatch = Stopwatch.StartNew();
            var plinqResult = await Task.Run(() =>
            {
                //MessageBox.Show($"thread of Task.Run: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10000);
                return DataProcessor.FilterOrdersByNamePLINQ(employees, filterText, filterType);
            });
            stopwatch.Stop();
            ExecutionTimeLabel.Text = $"Execution time: {stopwatch.ElapsedMilliseconds} ms";

            //MessageBox.Show($"UI thread: {Thread.CurrentThread.ManagedThreadId}");

            QueryResultsGrid.DataSource = plinqResult;

            //var result = await Task.Run(() => DataProcessor.FilterOrdersByNamePLINQ(employees, filterText, filterType));

            //// Обновляем UI в основном потоке
            //Invoke(() =>
            //{
            //    QueryResultsGrid.DataSource = result;
            //});

            //MessageBox.Show($"PLINQ execution time: {plinqTime}");
        }

        private async void ApplyFilterDateButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTimePicker.Value;
            string filterType = DateComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(filterType))
            {
                MessageBox.Show("Choose date filtration type first!");
                return;
            }
            //MessageBox.Show($"UI thread: {Thread.CurrentThread.ManagedThreadId}");

            var stopwatch = Stopwatch.StartNew();
            var plinqResult = await Task.Run(() =>
            {
                //MessageBox.Show($"thread of Task.Run: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10000);
                return DataProcessor.FilterOrdersByDatePLINQ(employees, selectedDate, filterType);
            });

            stopwatch.Stop();
            ExecutionTimeLabel.Text = $"Execution time: {stopwatch.ElapsedMilliseconds} ms";

            //MessageBox.Show($"UI thread: {Thread.CurrentThread.ManagedThreadId}");
            QueryResultsGrid.DataSource = plinqResult;
            //.Take(1000).ToList();

            //ThreadPool.QueueUserWorkItem(_ =>
            //{
            //    //MessageBox.Show($"thread of Task.Run: {Thread.CurrentThread.ManagedThreadId}");
            //    var result =  DataProcessor.FilterOrdersByDatePLINQ(employees, selectedDate, filterType);
            //    QueryResultsGrid.BeginInvoke(() =>
            //    {
            //        QueryResultsGrid.DataSource = result;
            //    });
            //});
        }


        private async void ApplySortButton_Click(object sender, EventArgs e)
        {
            string sortType = SortComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(sortType))
            {
                MessageBox.Show("Choose sort type first !");
                return;
            }

            bool ascending = sortType == "Ascending";

            var stopwatch = Stopwatch.StartNew();
            var sortedEmployees = await Task.Run(() =>
            {
                Thread.Sleep(10000);
                return DataProcessor.SortEmployeesByAverageOrderLINQ(employees, ascending);
            });
            stopwatch.Stop();
            ExecutionTimeLabel.Text = $"Execution time: {stopwatch.ElapsedMilliseconds} ms";

            QueryResultsGrid.DataSource = sortedEmployees
                .Select(e => new
                {
                    e.FullName,
                    AverageOrderAmount = e.Orders.Average(o => o.OrderAmount)
                })
                .ToList();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void ApplySearchButton_Click(object sender, EventArgs e)
        {
            var words = WordListTextBox.Text
                .Split(new[] { ' ', '\n', '\r', ',', '.', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.Trim())
                .Where(word => !string.IsNullOrWhiteSpace(word))
                .ToArray();

            if (words.Length == 0)
            {
                MessageBox.Show("Enter words for search first !");
                return;
            }

            if (!Directory.Exists(textsDirectoryPath))
            {
                MessageBox.Show($"No such directory: {textsDirectoryPath} !");
                return;
            }

            var files = Directory.GetFiles(textsDirectoryPath, "*.txt");

            if (files.Length == 0)
            {
                MessageBox.Show($"No txt files in directory {textsDirectoryPath} !");
                return;
            }

            if (WordListGrid.Columns.Count == 0)
            {
                WordListGrid.Columns.Add("Word", "Word");        
                WordListGrid.Columns.Add("Frequency", "Frequency"); 
            }

            var stopwatch = Stopwatch.StartNew();

            try
            {
                var wordFrequencies = await Task.Run(() =>
                {
                    Thread.Sleep(10000);
                    return TextAnalysisHelper.ProcessTexts(files, words);
                });

                stopwatch.Stop();

                Invoke((MethodInvoker)delegate
                {
                    TimeLabel.Text = $"Search process execution time: {stopwatch.ElapsedMilliseconds} мс";
                    WordListGrid.Rows.Clear();
                    foreach (var kvp in wordFrequencies)
                    {
                        WordListGrid.Rows.Add(kvp.Key, kvp.Value);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error while text processing occured: {ex.Message}");
            }
        }
    }
}