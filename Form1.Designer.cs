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
            panel2 = new Panel();
            panel3 = new Panel();
            RequestResults = new DataGridView();
            Orders = new DataGridView();
            Employees = new DataGridView();
            GenerateDataButton = new Button();
            FIOComboBox = new ComboBox();
            FIOTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            ApplyFilterFIOButton = new Button();
            ApplySortButton = new Button();
            SortComboBox = new ComboBox();
            DateComboBox = new ComboBox();
            DateTimePicker = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            ApplyFilterDateButton = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RequestResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Orders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Employees).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 631);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(347, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 631);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
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
            panel3.Controls.Add(RequestResults);
            panel3.Controls.Add(Orders);
            panel3.Controls.Add(Employees);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(832, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(418, 631);
            panel3.TabIndex = 0;
            // 
            // RequestResults
            // 
            RequestResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestResults.Location = new Point(0, 226);
            RequestResults.Name = "RequestResults";
            RequestResults.RowHeadersWidth = 51;
            RequestResults.Size = new Size(418, 117);
            RequestResults.TabIndex = 2;
            // 
            // Orders
            // 
            Orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Orders.Location = new Point(0, 106);
            Orders.Name = "Orders";
            Orders.RowHeadersWidth = 51;
            Orders.Size = new Size(418, 114);
            Orders.TabIndex = 1;
            // 
            // Employees
            // 
            Employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Employees.Location = new Point(0, 0);
            Employees.Name = "Employees";
            Employees.RowHeadersWidth = 51;
            Employees.Size = new Size(418, 100);
            Employees.TabIndex = 0;
            // 
            // GenerateDataButton
            // 
            GenerateDataButton.Location = new Point(36, 599);
            GenerateDataButton.Name = "GenerateDataButton";
            GenerateDataButton.Size = new Size(338, 29);
            GenerateDataButton.TabIndex = 1;
            GenerateDataButton.Text = "Сгенерировать данные";
            GenerateDataButton.UseVisualStyleBackColor = true;
            // 
            // FIOComboBox
            // 
            FIOComboBox.FormattingEnabled = true;
            FIOComboBox.Location = new Point(158, 360);
            FIOComboBox.Name = "FIOComboBox";
            FIOComboBox.Size = new Size(231, 28);
            FIOComboBox.TabIndex = 3;
            // 
            // FIOTextBox
            // 
            FIOTextBox.Location = new Point(158, 394);
            FIOTextBox.Name = "FIOTextBox";
            FIOTextBox.Size = new Size(231, 27);
            FIOTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 360);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 6;
            label2.Text = "Фильтр ФИО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 394);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 7;
            label3.Text = "Введите текст";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 568);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 9;
            label5.Text = "Тип сортировки";
            // 
            // ApplyFilterFIOButton
            // 
            ApplyFilterFIOButton.Location = new Point(21, 428);
            ApplyFilterFIOButton.Name = "ApplyFilterFIOButton";
            ApplyFilterFIOButton.Size = new Size(368, 29);
            ApplyFilterFIOButton.TabIndex = 10;
            ApplyFilterFIOButton.Text = "Отфильтровать по ФИО";
            ApplyFilterFIOButton.UseVisualStyleBackColor = true;
            // 
            // ApplySortButton
            // 
            ApplySortButton.Location = new Point(281, 563);
            ApplySortButton.Name = "ApplySortButton";
            ApplySortButton.Size = new Size(125, 29);
            ApplySortButton.TabIndex = 11;
            ApplySortButton.Text = "Отсортировать";
            ApplySortButton.UseVisualStyleBackColor = true;
            // 
            // SortComboBox
            // 
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Location = new Point(126, 565);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(149, 28);
            SortComboBox.TabIndex = 0;
            // 
            // DateComboBox
            // 
            DateComboBox.FormattingEnabled = true;
            DateComboBox.Location = new Point(158, 463);
            DateComboBox.Name = "DateComboBox";
            DateComboBox.Size = new Size(231, 28);
            DateComboBox.TabIndex = 12;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(158, 497);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(231, 27);
            DateTimePicker.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 463);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 14;
            label1.Text = "Фильтр даты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 497);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 15;
            label4.Text = "Выберите дату";
            // 
            // ApplyFilterDateButton
            // 
            ApplyFilterDateButton.Location = new Point(21, 530);
            ApplyFilterDateButton.Name = "ApplyFilterDateButton";
            ApplyFilterDateButton.Size = new Size(368, 29);
            ApplyFilterDateButton.TabIndex = 16;
            ApplyFilterDateButton.Text = "Отфильтровать по дате";
            ApplyFilterDateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 631);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Приложение";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RequestResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)Orders).EndInit();
            ((System.ComponentModel.ISupportInitialize)Employees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView RequestResults;
        private DataGridView Orders;
        private DataGridView Employees;
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
    }
}
