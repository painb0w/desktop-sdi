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
            panel1.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 631);
            panel1.TabIndex = 0;
            // 
            // WordListTextBox
            // 
            WordListTextBox.Location = new Point(12, 378);
            WordListTextBox.Name = "WordListTextBox";
            WordListTextBox.Size = new Size(329, 27);
            WordListTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 344);
            label6.Name = "label6";
            label6.Size = new Size(197, 20);
            label6.TabIndex = 3;
            label6.Text = "Enter list of words for search";
            label6.Click += label6_Click;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(21, 428);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(0, 20);
            TimeLabel.TabIndex = 4;
            // 
            // ApplySearchButton
            // 
            ApplySearchButton.Location = new Point(55, 517);
            ApplySearchButton.Name = "ApplySearchButton";
            ApplySearchButton.Size = new Size(226, 29);
            ApplySearchButton.TabIndex = 5;
            ApplySearchButton.Text = "Search";
            ApplySearchButton.UseVisualStyleBackColor = true;
            ApplySearchButton.Click += ApplySearchButton_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(347, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 631);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
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
            panel3.Location = new Point(832, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(418, 631);
            panel3.TabIndex = 0;
            // 
            // ExecutionTimeLabel
            // 
            ExecutionTimeLabel.AutoSize = true;
            ExecutionTimeLabel.Location = new Point(158, 329);
            ExecutionTimeLabel.Name = "ExecutionTimeLabel";
            ExecutionTimeLabel.Size = new Size(0, 20);
            ExecutionTimeLabel.TabIndex = 17;
            // 
            // ApplyFilterDateButton
            // 
            ApplyFilterDateButton.Location = new Point(21, 530);
            ApplyFilterDateButton.Name = "ApplyFilterDateButton";
            ApplyFilterDateButton.Size = new Size(368, 29);
            ApplyFilterDateButton.TabIndex = 16;
            ApplyFilterDateButton.Text = "Apply date filtration";
            ApplyFilterDateButton.UseVisualStyleBackColor = true;
            ApplyFilterDateButton.Click += ApplyFilterDateButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 497);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 15;
            label4.Text = "Choose date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 463);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 14;
            label1.Text = "Filter date";
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(158, 497);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(231, 27);
            DateTimePicker.TabIndex = 13;
            // 
            // DateComboBox
            // 
            DateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DateComboBox.FormattingEnabled = true;
            DateComboBox.Items.AddRange(new object[] { "Before", "After" });
            DateComboBox.Location = new Point(158, 463);
            DateComboBox.Name = "DateComboBox";
            DateComboBox.Size = new Size(231, 28);
            DateComboBox.TabIndex = 12;
            // 
            // SortComboBox
            // 
            SortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Items.AddRange(new object[] { "Ascending", "Descending" });
            SortComboBox.Location = new Point(126, 565);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(149, 28);
            SortComboBox.TabIndex = 0;
            // 
            // ApplySortButton
            // 
            ApplySortButton.Location = new Point(281, 563);
            ApplySortButton.Name = "ApplySortButton";
            ApplySortButton.Size = new Size(125, 29);
            ApplySortButton.TabIndex = 11;
            ApplySortButton.Text = "Apply sort";
            ApplySortButton.UseVisualStyleBackColor = true;
            ApplySortButton.Click += ApplySortButton_Click;
            // 
            // ApplyFilterFIOButton
            // 
            ApplyFilterFIOButton.Location = new Point(21, 428);
            ApplyFilterFIOButton.Name = "ApplyFilterFIOButton";
            ApplyFilterFIOButton.Size = new Size(368, 29);
            ApplyFilterFIOButton.TabIndex = 10;
            ApplyFilterFIOButton.Text = "Apply full name filtration";
            ApplyFilterFIOButton.UseVisualStyleBackColor = true;
            ApplyFilterFIOButton.Click += ApplyFilterFIOButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 565);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 9;
            label5.Text = "Type of sort";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 394);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Enter text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 360);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 6;
            label2.Text = "Filter full name";
            // 
            // FIOTextBox
            // 
            FIOTextBox.Location = new Point(158, 394);
            FIOTextBox.Name = "FIOTextBox";
            FIOTextBox.Size = new Size(231, 27);
            FIOTextBox.TabIndex = 5;
            // 
            // FIOComboBox
            // 
            FIOComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FIOComboBox.FormattingEnabled = true;
            FIOComboBox.Items.AddRange(new object[] { "Contains", "Starts with", "Equals to" });
            FIOComboBox.Location = new Point(158, 360);
            FIOComboBox.Name = "FIOComboBox";
            FIOComboBox.Size = new Size(231, 28);
            FIOComboBox.TabIndex = 3;
            // 
            // GenerateDataButton
            // 
            GenerateDataButton.Location = new Point(36, 599);
            GenerateDataButton.Name = "GenerateDataButton";
            GenerateDataButton.Size = new Size(338, 29);
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
            QueryResultsGrid.Location = new Point(0, 224);
            QueryResultsGrid.Name = "QueryResultsGrid";
            QueryResultsGrid.RowHeadersWidth = 51;
            QueryResultsGrid.Size = new Size(418, 102);
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
            OrdersGrid.Location = new Point(0, 119);
            OrdersGrid.Name = "OrdersGrid";
            OrdersGrid.RowHeadersWidth = 51;
            OrdersGrid.Size = new Size(418, 99);
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
            EmployeesGrid.Name = "EmployeesGrid";
            EmployeesGrid.RowHeadersWidth = 51;
            EmployeesGrid.Size = new Size(418, 113);
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
            WordListGrid.Name = "WordListGrid";
            WordListGrid.RowHeadersWidth = 51;
            WordListGrid.Size = new Size(347, 326);
            WordListGrid.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 631);
            Controls.Add(WordListGrid);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Приложение";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
