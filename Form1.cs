using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace sdi_mega_proj
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;

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

            employees = await Task.Run(() => DataGenerator.GenerateEmployees(1000)); // установил фиксированное число сотрудников

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


        private async Task<string> MeasureExecutionTimeAsync(Func<Task> action)
        {
            var stopwatch = Stopwatch.StartNew();
            await action(); 
            stopwatch.Stop();

            return $"Query execution time: {stopwatch.ElapsedMilliseconds} ms.";
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
                return DataProcessor.FilterOrdersByDatePLINQ(employees, selectedDate, filterType);
            });
            stopwatch.Stop();
            ExecutionTimeLabel.Text = $"Execution time: {stopwatch.ElapsedMilliseconds} ms";

            //MessageBox.Show($"UI thread: {Thread.CurrentThread.ManagedThreadId}");
            QueryResultsGrid.DataSource = plinqResult;
                    //.Select(o => new { o.OrderDate, o.OrderAmount })
                    //.ToList();
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
            var sortedEmployees = await Task.Run(() => DataProcessor.SortEmployeesByAverageOrderLINQ(employees, ascending));
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
    }
}