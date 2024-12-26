namespace sdi_mega_proj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            WordListTextBox = new TextBox();
            label6 = new Label();
            TimeLabel = new Label();
            ApplySearchButton = new Button();
            panel2 = new Panel();
            CrawlerInfoGrid = new DataGridView();
            DepthTextBox = new TextBox();
            label8 = new Label();
            StartCrawlerButton = new Button();
            StartUrlTextBox = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            ExecutionTimeLabel = new Label();
            ApplyFilterDateButton = new Button();
            label4 = new Label();
            label1 = new Label();
            DateTimePicker = new DateTimePicker();
            DateComboBox = new ComboBox();
            SortComboBox = new ComboBox();
            ApplySortButton = new Button();
            ApplyFilterFIOButton = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            FIOTextBox = new TextBox();
            FIOComboBox = new ComboBox();
            GenerateDataButton = new Button();
            QueryResultsGrid = new DataGridView();
            OrdersGrid = new DataGridView();
            EmployeesGrid = new DataGridView();
            WordListGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CrawlerInfoGrid).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QueryResultsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WordListGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(WordListTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TimeLabel);
            panel1.Controls.Add(ApplySearchButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 1010);
            panel1.TabIndex = 0;
            // 
            // WordListTextBox
            // 
            WordListTextBox.Location = new Point(20, 605);
            WordListTextBox.Margin = new Padding(5, 5, 5, 5);
            WordListTextBox.Name = "WordListTextBox";
            WordListTextBox.Size = new Size(532, 39);
            WordListTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 550);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(317, 32);
            label6.TabIndex = 3;
            label6.Text = "Enter list of words for search";
            label6.Click += label6_Click;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(34, 685);
            TimeLabel.Margin = new Padding(5, 0, 5, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(0, 32);
            TimeLabel.TabIndex = 4;
            // 
            // ApplySearchButton
            // 
            ApplySearchButton.Location = new Point(34, 741);
            ApplySearchButton.Margin = new Padding(5, 5, 5, 5);
            ApplySearchButton.Name = "ApplySearchButton";
            ApplySearchButton.Size = new Size(474, 210);
            ApplySearchButton.TabIndex = 5;
            ApplySearchButton.Text = "Search";
            ApplySearchButton.UseVisualStyleBackColor = true;
            ApplySearchButton.Click += ApplySearchButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(CrawlerInfoGrid);
            panel2.Controls.Add(DepthTextBox);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(StartCrawlerButton);
            panel2.Controls.Add(StartUrlTextBox);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(564, 0);
            panel2.Margin = new Padding(5, 5, 5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 1010);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // CrawlerInfoGrid
            // 
            CrawlerInfoGrid.AllowUserToAddRows = false;
            CrawlerInfoGrid.AllowUserToDeleteRows = false;
            CrawlerInfoGrid.AllowUserToResizeColumns = false;
            CrawlerInfoGrid.AllowUserToResizeRows = false;
            CrawlerInfoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CrawlerInfoGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CrawlerInfoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CrawlerInfoGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            CrawlerInfoGrid.Location = new Point(0, 0);
            CrawlerInfoGrid.Margin = new Padding(5, 5, 5, 5);
            CrawlerInfoGrid.Name = "CrawlerInfoGrid";
            CrawlerInfoGrid.RowHeadersWidth = 51;
            CrawlerInfoGrid.Size = new Size(788, 522);
            CrawlerInfoGrid.TabIndex = 7;
            // 
            // DepthTextBox
            // 
            DepthTextBox.Location = new Point(206, 669);
            DepthTextBox.Margin = new Padding(5, 5, 5, 5);
            DepthTextBox.Name = "DepthTextBox";
            DepthTextBox.Size = new Size(477, 39);
            DepthTextBox.TabIndex = 6;
            DepthTextBox.TextChanged += DepthTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 669);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(139, 32);
            label8.TabIndex = 5;
            label8.Text = "Enter depth";
            // 
            // StartCrawlerButton
            // 
            StartCrawlerButton.Location = new Point(130, 741);
            StartCrawlerButton.Margin = new Padding(5, 5, 5, 5);
            StartCrawlerButton.Name = "StartCrawlerButton";
            StartCrawlerButton.Size = new Size(556, 210);
            StartCrawlerButton.TabIndex = 2;
            StartCrawlerButton.Text = "Start crawler";
            StartCrawlerButton.UseVisualStyleBackColor = true;
            StartCrawlerButton.Click += StartCrawlerButton_Click;
            // 
            // StartUrlTextBox
            // 
            StartUrlTextBox.Location = new Point(206, 598);
            StartUrlTextBox.Margin = new Padding(5, 5, 5, 5);
            StartUrlTextBox.Name = "StartUrlTextBox";
            StartUrlTextBox.Size = new Size(477, 39);
            StartUrlTextBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 610);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(155, 32);
            label7.TabIndex = 4;
            label7.Text = "Enter root url";
            // 
            // panel3
            // 
            panel3.Controls.Add(ExecutionTimeLabel);
            panel3.Controls.Add(ApplyFilterDateButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(DateTimePicker);
            panel3.Controls.Add(DateComboBox);
            panel3.Controls.Add(SortComboBox);
            panel3.Controls.Add(ApplySortButton);
            panel3.Controls.Add(ApplyFilterFIOButton);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(FIOTextBox);
            panel3.Controls.Add(FIOComboBox);
            panel3.Controls.Add(GenerateDataButton);
            panel3.Controls.Add(QueryResultsGrid);
            panel3.Controls.Add(OrdersGrid);
            panel3.Controls.Add(EmployeesGrid);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1352, 0);
            panel3.Margin = new Padding(5, 5, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(679, 1010);
            panel3.TabIndex = 0;
            // 
            // ExecutionTimeLabel
            // 
            ExecutionTimeLabel.AutoSize = true;
            ExecutionTimeLabel.Location = new Point(257, 526);
            ExecutionTimeLabel.Margin = new Padding(5, 0, 5, 0);
            ExecutionTimeLabel.Name = "ExecutionTimeLabel";
            ExecutionTimeLabel.Size = new Size(0, 32);
            ExecutionTimeLabel.TabIndex = 17;
            // 
            // ApplyFilterDateButton
            // 
            ApplyFilterDateButton.Location = new Point(34, 848);
            ApplyFilterDateButton.Margin = new Padding(5, 5, 5, 5);
            ApplyFilterDateButton.Name = "ApplyFilterDateButton";
            ApplyFilterDateButton.Size = new Size(598, 46);
            ApplyFilterDateButton.TabIndex = 16;
            ApplyFilterDateButton.Text = "Apply date filtration";
            ApplyFilterDateButton.UseVisualStyleBackColor = true;
            ApplyFilterDateButton.Click += ApplyFilterDateButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 795);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 32);
            label4.TabIndex = 15;
            label4.Text = "Choose date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 741);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 14;
            label1.Text = "Filter date";
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(257, 795);
            DateTimePicker.Margin = new Padding(5, 5, 5, 5);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(373, 39);
            DateTimePicker.TabIndex = 13;
            // 
            // DateComboBox
            // 
            DateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DateComboBox.FormattingEnabled = true;
            DateComboBox.Items.AddRange(new object[] { "Before", "After" });
            DateComboBox.Location = new Point(257, 741);
            DateComboBox.Margin = new Padding(5, 5, 5, 5);
            DateComboBox.Name = "DateComboBox";
            DateComboBox.Size = new Size(373, 40);
            DateComboBox.TabIndex = 12;
            // 
            // SortComboBox
            // 
            SortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Items.AddRange(new object[] { "Ascending", "Descending" });
            SortComboBox.Location = new Point(205, 904);
            SortComboBox.Margin = new Padding(5, 5, 5, 5);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(240, 40);
            SortComboBox.TabIndex = 0;
            // 
            // ApplySortButton
            // 
            ApplySortButton.Location = new Point(457, 901);
            ApplySortButton.Margin = new Padding(5, 5, 5, 5);
            ApplySortButton.Name = "ApplySortButton";
            ApplySortButton.Size = new Size(203, 46);
            ApplySortButton.TabIndex = 11;
            ApplySortButton.Text = "Apply sort";
            ApplySortButton.UseVisualStyleBackColor = true;
            ApplySortButton.Click += ApplySortButton_Click;
            // 
            // ApplyFilterFIOButton
            // 
            ApplyFilterFIOButton.Location = new Point(34, 685);
            ApplyFilterFIOButton.Margin = new Padding(5, 5, 5, 5);
            ApplyFilterFIOButton.Name = "ApplyFilterFIOButton";
            ApplyFilterFIOButton.Size = new Size(598, 46);
            ApplyFilterFIOButton.TabIndex = 10;
            ApplyFilterFIOButton.Text = "Apply full name filtration";
            ApplyFilterFIOButton.UseVisualStyleBackColor = true;
            ApplyFilterFIOButton.Click += ApplyFilterFIOButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 904);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 32);
            label5.TabIndex = 9;
            label5.Text = "Type of sort";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 630);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 7;
            label3.Text = "Enter text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 576);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 6;
            label2.Text = "Filter full name";
            // 
            // FIOTextBox
            // 
            FIOTextBox.Location = new Point(257, 630);
            FIOTextBox.Margin = new Padding(5, 5, 5, 5);
            FIOTextBox.Name = "FIOTextBox";
            FIOTextBox.Size = new Size(373, 39);
            FIOTextBox.TabIndex = 5;
            // 
            // FIOComboBox
            // 
            FIOComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FIOComboBox.FormattingEnabled = true;
            FIOComboBox.Items.AddRange(new object[] { "Contains", "Starts with", "Equals to" });
            FIOComboBox.Location = new Point(257, 576);
            FIOComboBox.Margin = new Padding(5, 5, 5, 5);
            FIOComboBox.Name = "FIOComboBox";
            FIOComboBox.Size = new Size(373, 40);
            FIOComboBox.TabIndex = 3;
            // 
            // GenerateDataButton
            // 
            GenerateDataButton.Location = new Point(58, 958);
            GenerateDataButton.Margin = new Padding(5, 5, 5, 5);
            GenerateDataButton.Name = "GenerateDataButton";
            GenerateDataButton.Size = new Size(549, 46);
            GenerateDataButton.TabIndex = 1;
            GenerateDataButton.Text = "Generate data";
            GenerateDataButton.UseVisualStyleBackColor = true;
            GenerateDataButton.Click += GenerateDataButton_Click;
            // 
            // QueryResultsGrid
            // 
            QueryResultsGrid.AllowUserToAddRows = false;
            QueryResultsGrid.AllowUserToDeleteRows = false;
            QueryResultsGrid.AllowUserToResizeColumns = false;
            QueryResultsGrid.AllowUserToResizeRows = false;
            QueryResultsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            QueryResultsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            QueryResultsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QueryResultsGrid.Location = new Point(0, 358);
            QueryResultsGrid.Margin = new Padding(5, 5, 5, 5);
            QueryResultsGrid.Name = "QueryResultsGrid";
            QueryResultsGrid.RowHeadersWidth = 51;
            QueryResultsGrid.Size = new Size(679, 163);
            QueryResultsGrid.TabIndex = 2;
            QueryResultsGrid.VirtualMode = true;
            // 
            // OrdersGrid
            // 
            OrdersGrid.AllowUserToAddRows = false;
            OrdersGrid.AllowUserToDeleteRows = false;
            OrdersGrid.AllowUserToResizeColumns = false;
            OrdersGrid.AllowUserToResizeRows = false;
            OrdersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdersGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            OrdersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGrid.Location = new Point(0, 190);
            OrdersGrid.Margin = new Padding(5, 5, 5, 5);
            OrdersGrid.Name = "OrdersGrid";
            OrdersGrid.RowHeadersWidth = 51;
            OrdersGrid.Size = new Size(679, 158);
            OrdersGrid.TabIndex = 1;
            // 
            // EmployeesGrid
            // 
            EmployeesGrid.AllowUserToAddRows = false;
            EmployeesGrid.AllowUserToDeleteRows = false;
            EmployeesGrid.AllowUserToResizeColumns = false;
            EmployeesGrid.AllowUserToResizeRows = false;
            EmployeesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmployeesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesGrid.Location = new Point(0, 0);
            EmployeesGrid.Margin = new Padding(5, 5, 5, 5);
            EmployeesGrid.Name = "EmployeesGrid";
            EmployeesGrid.RowHeadersWidth = 51;
            EmployeesGrid.Size = new Size(679, 181);
            EmployeesGrid.TabIndex = 0;
            // 
            // WordListGrid
            // 
            WordListGrid.AllowUserToAddRows = false;
            WordListGrid.AllowUserToDeleteRows = false;
            WordListGrid.AllowUserToResizeColumns = false;
            WordListGrid.AllowUserToResizeRows = false;
            WordListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WordListGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            WordListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WordListGrid.Location = new Point(0, 0);
            WordListGrid.Margin = new Padding(5, 5, 5, 5);
            WordListGrid.Name = "WordListGrid";
            WordListGrid.RowHeadersWidth = 51;
            WordListGrid.Size = new Size(564, 522);
            WordListGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Height";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Processing time (ms)";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Node count";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Leaves";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2031, 1010);
            Controls.Add(WordListGrid);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Приложение";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CrawlerInfoGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QueryResultsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)WordListGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView QueryResultsGrid;
        private DataGridView OrdersGrid;
        private DataGridView EmployeesGrid;
        private Button GenerateDataButton;
        private ComboBox FIOComboBox;
        private Label label3;
        private Label label2;
        private TextBox FIOTextBox;
        private ComboBox SortComboBox;
        private Button ApplySortButton;
        private Button ApplyFilterFIOButton;
        private Label label5;
        private DateTimePicker DateTimePicker;
        private ComboBox DateComboBox;
        private Button ApplyFilterDateButton;
        private Label label4;
        private Label label1;
        private Label ExecutionTimeLabel;
        private DataGridView WordListGrid;
        private TextBox WordListTextBox;
        private Label label6;
        private Label TimeLabel;
        private Button ApplySearchButton;
        private DataGridView CrawlerInfoGrid;
        private TextBox DepthTextBox;
        private Label label8;
        private Button StartCrawlerButton;
        private TextBox StartUrlTextBox;
        private Label label7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
