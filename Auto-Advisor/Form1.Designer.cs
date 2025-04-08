namespace Auto_Advisor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MajorList = new ComboBox();
            MinorBox = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            button3 = new Button();
            button4 = new Button();
            continueButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            MajorList2 = new ComboBox();
            MajorButton = new Button();
            button6 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            MinorBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            mainScreenPanel = new Panel();
            panel1 = new Panel();
            dataGridTheology = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            dataGridRecommended = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            dataGridGenEd = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            textBox6 = new TextBox();
            dataGridCognate = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox74 = new TextBox();
            dataGridMajors = new DataGridView();
            ClassCode = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Hours = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            textBox42 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            listBox4 = new ListBox();
            listBox2 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            listBox7 = new ListBox();
            listBox8 = new ListBox();
            listBox1 = new ListBox();
            listBox9 = new ListBox();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            minorDisplay = new ListBox();
            majorDisplay = new ListBox();
            button1 = new Button();
            openSaveFileDialog = new OpenFileDialog();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            mainScreenPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTheology).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRecommended).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridGenEd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCognate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMajors).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 58);
            label1.Name = "label1";
            label1.Size = new Size(594, 46);
            label1.TabIndex = 1;
            label1.Text = "Please enter your information below - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(221, 140);
            label2.Name = "label2";
            label2.Size = new Size(204, 28);
            label2.TabIndex = 2;
            label2.Text = "Select your Major(s) - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(221, 182);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 3;
            label3.Text = "Select your Minor(s)- ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(221, 226);
            label4.Name = "label4";
            label4.Size = new Size(273, 28);
            label4.TabIndex = 4;
            label4.Text = "Are you an Honors student? - ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(221, 268);
            label5.Name = "label5";
            label5.Size = new Size(367, 28);
            label5.TabIndex = 5;
            label5.Text = "What is your upcoming semester?(1-8) - ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(221, 310);
            label6.Name = "label6";
            label6.Size = new Size(327, 28);
            label6.TabIndex = 6;
            label6.Text = "What classes have you completed? -";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(221, 478);
            label7.Name = "label7";
            label7.Size = new Size(356, 28);
            label7.TabIndex = 7;
            label7.Text = "What classes are you currently taking?- ";
            // 
            // MajorList
            // 
            MajorList.DropDownStyle = ComboBoxStyle.DropDownList;
            MajorList.FormattingEnabled = true;
            MajorList.Items.AddRange(new object[] { "Computer Science(CS)", "Gender Studies" });
            MajorList.Location = new Point(3, 3);
            MajorList.Name = "MajorList";
            MajorList.Size = new Size(117, 23);
            MajorList.TabIndex = 8;
            // 
            // MinorBox
            // 
            MinorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MinorBox.FormattingEnabled = true;
            MinorBox.Items.AddRange(new object[] { "None", "Biblical Studies" });
            MinorBox.Location = new Point(3, 3);
            MinorBox.Name = "MinorBox";
            MinorBox.Size = new Size(117, 23);
            MinorBox.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "No", "Yes" });
            comboBox3.Location = new Point(606, 231);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBox4.Location = new Point(607, 274);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(246, 340);
            label8.Name = "label8";
            label8.Size = new Size(232, 39);
            label8.TabIndex = 13;
            label8.Text = "Please enter class codes, separated by a line\r\n Example: COSC 1303\r\n                  BIBL 1023";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(246, 514);
            label9.Name = "label9";
            label9.Size = new Size(232, 39);
            label9.TabIndex = 14;
            label9.Text = "Please enter class codes, separated by a line\r\n Example: COSC 1303\r\n                  BIBL 1023\r\n";
            // 
            // button3
            // 
            button3.Location = new Point(556, 634);
            button3.Name = "button3";
            button3.Size = new Size(105, 22);
            button3.TabIndex = 18;
            button3.Text = "Download Data";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(689, 634);
            button4.Name = "button4";
            button4.Size = new Size(105, 22);
            button4.TabIndex = 19;
            button4.Text = "Enter Saved Data";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(817, 634);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(73, 22);
            continueButton.TabIndex = 20;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += button5_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(MajorList2, 1, 0);
            tableLayoutPanel3.Controls.Add(MajorList, 0, 0);
            tableLayoutPanel3.Location = new Point(594, 140);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(246, 46);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // MajorList2
            // 
            MajorList2.DropDownStyle = ComboBoxStyle.DropDownList;
            MajorList2.FormattingEnabled = true;
            MajorList2.Items.AddRange(new object[] { "Computer Science(CS)", "Gender Studies" });
            MajorList2.Location = new Point(126, 3);
            MajorList2.Name = "MajorList2";
            MajorList2.Size = new Size(117, 23);
            MajorList2.TabIndex = 9;
            MajorList2.Visible = false;
            // 
            // MajorButton
            // 
            MajorButton.Location = new Point(517, 141);
            MajorButton.Name = "MajorButton";
            MajorButton.Size = new Size(74, 22);
            MajorButton.TabIndex = 21;
            MajorButton.Text = "Add Major";
            MajorButton.UseVisualStyleBackColor = true;
            MajorButton.Click += button6_Click;
            // 
            // button6
            // 
            button6.Location = new Point(517, 188);
            button6.Name = "button6";
            button6.Size = new Size(74, 22);
            button6.TabIndex = 22;
            button6.Text = "Add Minor";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(MinorBox2, 1, 0);
            tableLayoutPanel4.Controls.Add(MinorBox, 0, 0);
            tableLayoutPanel4.Location = new Point(594, 188);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(246, 39);
            tableLayoutPanel4.TabIndex = 23;
            // 
            // MinorBox2
            // 
            MinorBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            MinorBox2.FormattingEnabled = true;
            MinorBox2.Items.AddRange(new object[] { "None", "Biblical Studies" });
            MinorBox2.Location = new Point(126, 3);
            MinorBox2.Name = "MinorBox2";
            MinorBox2.Size = new Size(117, 23);
            MinorBox2.TabIndex = 24;
            MinorBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(594, 316);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(210, 158);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(594, 484);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(210, 118);
            textBox2.TabIndex = 25;
            // 
            // mainScreenPanel
            // 
            mainScreenPanel.Controls.Add(panel1);
            mainScreenPanel.Controls.Add(label12);
            mainScreenPanel.Controls.Add(label13);
            mainScreenPanel.Controls.Add(tableLayoutPanel1);
            mainScreenPanel.Controls.Add(button1);
            mainScreenPanel.Location = new Point(1, 1);
            mainScreenPanel.Margin = new Padding(2);
            mainScreenPanel.Name = "mainScreenPanel";
            mainScreenPanel.Size = new Size(1500, 671);
            mainScreenPanel.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 40);
            panel1.Controls.Add(dataGridTheology);
            panel1.Controls.Add(dataGridRecommended);
            panel1.Controls.Add(dataGridGenEd);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(dataGridCognate);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox74);
            panel1.Controls.Add(dataGridMajors);
            panel1.Controls.Add(textBox42);
            panel1.Location = new Point(156, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 664);
            panel1.TabIndex = 242;
            // 
            // dataGridTheology
            // 
            dataGridTheology.AllowUserToAddRows = false;
            dataGridTheology.AllowUserToDeleteRows = false;
            dataGridTheology.AllowUserToResizeColumns = false;
            dataGridTheology.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridTheology.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTheology.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTheology.BorderStyle = BorderStyle.None;
            dataGridTheology.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridTheology.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridTheology.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTheology.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewButtonColumn4 });
            dataGridTheology.Location = new Point(51, 1024);
            dataGridTheology.Margin = new Padding(2);
            dataGridTheology.Name = "dataGridTheology";
            dataGridTheology.RowHeadersVisible = false;
            dataGridTheology.RowHeadersWidth = 62;
            dataGridTheology.RowTemplate.Height = 33;
            dataGridTheology.ScrollBars = ScrollBars.Vertical;
            dataGridTheology.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTheology.Size = new Size(762, 158);
            dataGridTheology.TabIndex = 245;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn10.Frozen = true;
            dataGridViewTextBoxColumn10.HeaderText = "Class Code";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 178;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn11.Frozen = true;
            dataGridViewTextBoxColumn11.HeaderText = "Class Name";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn11.Width = 320;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Hours";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn4
            // 
            dataGridViewButtonColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewButtonColumn4.HeaderText = "Details";
            dataGridViewButtonColumn4.MinimumWidth = 8;
            dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            dataGridViewButtonColumn4.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn4.Text = "More...";
            dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn4.Width = 178;
            // 
            // dataGridRecommended
            // 
            dataGridRecommended.AllowUserToAddRows = false;
            dataGridRecommended.AllowUserToDeleteRows = false;
            dataGridRecommended.AllowUserToResizeColumns = false;
            dataGridRecommended.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridRecommended.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridRecommended.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRecommended.BorderStyle = BorderStyle.None;
            dataGridRecommended.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridRecommended.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridRecommended.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRecommended.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewButtonColumn2 });
            dataGridRecommended.Location = new Point(51, 93);
            dataGridRecommended.Margin = new Padding(2);
            dataGridRecommended.Name = "dataGridRecommended";
            dataGridRecommended.RowHeadersVisible = false;
            dataGridRecommended.RowHeadersWidth = 62;
            dataGridRecommended.RowTemplate.Height = 33;
            dataGridRecommended.ScrollBars = ScrollBars.Vertical;
            dataGridRecommended.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRecommended.Size = new Size(762, 158);
            dataGridRecommended.TabIndex = 234;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "Class Code";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 178;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "Class Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn2.Width = 320;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Hours";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewButtonColumn2.HeaderText = "Details";
            dataGridViewButtonColumn2.MinimumWidth = 8;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn2.Text = "More...";
            dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn2.Width = 178;
            // 
            // dataGridGenEd
            // 
            dataGridGenEd.AllowUserToAddRows = false;
            dataGridGenEd.AllowUserToDeleteRows = false;
            dataGridGenEd.AllowUserToResizeColumns = false;
            dataGridGenEd.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridGenEd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridGenEd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridGenEd.BorderStyle = BorderStyle.None;
            dataGridGenEd.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridGenEd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridGenEd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGenEd.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewButtonColumn3 });
            dataGridGenEd.Location = new Point(51, 790);
            dataGridGenEd.Margin = new Padding(2);
            dataGridGenEd.Name = "dataGridGenEd";
            dataGridGenEd.RowHeadersVisible = false;
            dataGridGenEd.RowHeadersWidth = 62;
            dataGridGenEd.RowTemplate.Height = 33;
            dataGridGenEd.ScrollBars = ScrollBars.Vertical;
            dataGridGenEd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridGenEd.Size = new Size(762, 158);
            dataGridGenEd.TabIndex = 244;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn7.Frozen = true;
            dataGridViewTextBoxColumn7.HeaderText = "Class Code";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 178;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn8.Frozen = true;
            dataGridViewTextBoxColumn8.HeaderText = "Class Name";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn8.Width = 320;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Hours";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewButtonColumn3.HeaderText = "Details";
            dataGridViewButtonColumn3.MinimumWidth = 8;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn3.Text = "More...";
            dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn3.Width = 178;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DimGray;
            textBox6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(51, 738);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(762, 52);
            textBox6.TabIndex = 243;
            textBox6.Text = "General Education Courses";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridCognate
            // 
            dataGridCognate.AllowUserToAddRows = false;
            dataGridCognate.AllowUserToDeleteRows = false;
            dataGridCognate.AllowUserToResizeColumns = false;
            dataGridCognate.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridCognate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridCognate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCognate.BorderStyle = BorderStyle.None;
            dataGridCognate.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridCognate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridCognate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCognate.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewButtonColumn1 });
            dataGridCognate.Location = new Point(51, 554);
            dataGridCognate.Margin = new Padding(2);
            dataGridCognate.Name = "dataGridCognate";
            dataGridCognate.RowHeadersVisible = false;
            dataGridCognate.RowHeadersWidth = 62;
            dataGridCognate.RowTemplate.Height = 33;
            dataGridCognate.ScrollBars = ScrollBars.Vertical;
            dataGridCognate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCognate.Size = new Size(762, 158);
            dataGridCognate.TabIndex = 242;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn4.Frozen = true;
            dataGridViewTextBoxColumn4.HeaderText = "Class Code";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 178;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn5.Frozen = true;
            dataGridViewTextBoxColumn5.HeaderText = "Class Name";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn5.Width = 320;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Hours";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewButtonColumn1.HeaderText = "Details";
            dataGridViewButtonColumn1.MinimumWidth = 8;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.Text = "More...";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 178;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DimGray;
            textBox4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(51, 972);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(762, 52);
            textBox4.TabIndex = 238;
            textBox4.Text = "Theology and Vocation Courses";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DimGray;
            textBox3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(51, 44);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(762, 52);
            textBox3.TabIndex = 158;
            textBox3.Text = "Recommended Classes";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox74
            // 
            textBox74.BackColor = Color.DimGray;
            textBox74.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox74.ForeColor = Color.White;
            textBox74.Location = new Point(51, 503);
            textBox74.Name = "textBox74";
            textBox74.ReadOnly = true;
            textBox74.Size = new Size(762, 52);
            textBox74.TabIndex = 208;
            textBox74.Text = "Cognate Courses";
            textBox74.TextAlign = HorizontalAlignment.Center;
            textBox74.TextChanged += textBox74_TextChanged;
            // 
            // dataGridMajors
            // 
            dataGridMajors.AllowUserToAddRows = false;
            dataGridMajors.AllowUserToDeleteRows = false;
            dataGridMajors.AllowUserToResizeColumns = false;
            dataGridMajors.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridMajors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridMajors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMajors.BorderStyle = BorderStyle.None;
            dataGridMajors.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridMajors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridMajors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMajors.Columns.AddRange(new DataGridViewColumn[] { ClassCode, ClassName, Hours, Details });
            dataGridMajors.Location = new Point(51, 321);
            dataGridMajors.Margin = new Padding(2);
            dataGridMajors.Name = "dataGridMajors";
            dataGridMajors.RowHeadersVisible = false;
            dataGridMajors.RowHeadersWidth = 62;
            dataGridMajors.RowTemplate.Height = 33;
            dataGridMajors.ScrollBars = ScrollBars.Vertical;
            dataGridMajors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMajors.Size = new Size(762, 158);
            dataGridMajors.TabIndex = 233;
            dataGridMajors.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ClassCode
            // 
            ClassCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassCode.Frozen = true;
            ClassCode.HeaderText = "Class Code";
            ClassCode.MinimumWidth = 8;
            ClassCode.Name = "ClassCode";
            ClassCode.ReadOnly = true;
            ClassCode.Width = 178;
            // 
            // ClassName
            // 
            ClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassName.Frozen = true;
            ClassName.HeaderText = "Class Name";
            ClassName.MinimumWidth = 8;
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            ClassName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ClassName.Width = 320;
            // 
            // Hours
            // 
            Hours.HeaderText = "Hours";
            Hours.MinimumWidth = 8;
            Hours.Name = "Hours";
            Hours.ReadOnly = true;
            Hours.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Details
            // 
            Details.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Details.HeaderText = "Details";
            Details.MinimumWidth = 8;
            Details.Name = "Details";
            Details.Resizable = DataGridViewTriState.True;
            Details.Text = "More...";
            Details.UseColumnTextForButtonValue = true;
            Details.Width = 178;
            // 
            // textBox42
            // 
            textBox42.BackColor = Color.DimGray;
            textBox42.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox42.ForeColor = Color.White;
            textBox42.Location = new Point(51, 272);
            textBox42.Name = "textBox42";
            textBox42.ReadOnly = true;
            textBox42.Size = new Size(762, 52);
            textBox42.TabIndex = 183;
            textBox42.Text = "Major Classes";
            textBox42.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ControlLight;
            label12.Location = new Point(1054, 776);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.MaximumSize = new Size(175, 1500);
            label12.Name = "label12";
            label12.Size = new Size(2, 500);
            label12.TabIndex = 241;
            label12.Text = " ";
            // 
            // label13
            // 
            label13.BackColor = SystemColors.ControlLight;
            label13.Location = new Point(1054, 0);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.MaximumSize = new Size(175, 1500);
            label13.Name = "label13";
            label13.Size = new Size(2, 1000);
            label13.TabIndex = 4;
            label13.Text = " ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutPanel1.Controls.Add(label10, 0, 0);
            tableLayoutPanel1.Controls.Add(label11, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 0, 5);
            tableLayoutPanel1.Controls.Add(minorDisplay, 0, 3);
            tableLayoutPanel1.Controls.Add(majorDisplay, 0, 1);
            tableLayoutPanel1.Location = new Point(1070, 44);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.410441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.370837F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.320432F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.830783F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.50225F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.840684F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.2646255F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(281, 668);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.BackColor = SystemColors.ControlDarkDark;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(listBox4, 1, 0);
            tableLayoutPanel2.Controls.Add(listBox2, 1, 2);
            tableLayoutPanel2.Controls.Add(listBox5, 1, 3);
            tableLayoutPanel2.Controls.Add(listBox6, 1, 1);
            tableLayoutPanel2.Controls.Add(listBox7, 0, 0);
            tableLayoutPanel2.Controls.Add(listBox8, 0, 1);
            tableLayoutPanel2.Controls.Add(listBox1, 0, 3);
            tableLayoutPanel2.Controls.Add(listBox9, 0, 2);
            tableLayoutPanel2.Location = new Point(11, 161);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RightToLeft = RightToLeft.No;
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.96154F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.0769234F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.48077F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.48077F));
            tableLayoutPanel2.Size = new Size(258, 124);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // listBox4
            // 
            listBox4.Anchor = AnchorStyles.Left;
            listBox4.BackColor = SystemColors.ControlDarkDark;
            listBox4.BorderStyle = BorderStyle.None;
            listBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox4.ForeColor = Color.White;
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Items.AddRange(new object[] { "0" });
            listBox4.Location = new Point(194, 7);
            listBox4.Margin = new Padding(2);
            listBox4.Name = "listBox4";
            listBox4.SelectionMode = SelectionMode.None;
            listBox4.Size = new Size(59, 20);
            listBox4.TabIndex = 5;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Left;
            listBox2.BackColor = SystemColors.ControlDarkDark;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.ForeColor = Color.White;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Items.AddRange(new object[] { "126" });
            listBox2.Location = new Point(194, 65);
            listBox2.Margin = new Padding(2);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.None;
            listBox2.Size = new Size(59, 20);
            listBox2.TabIndex = 7;
            // 
            // listBox5
            // 
            listBox5.Anchor = AnchorStyles.Left;
            listBox5.BackColor = SystemColors.ControlDarkDark;
            listBox5.BorderStyle = BorderStyle.None;
            listBox5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox5.ForeColor = Color.White;
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 20;
            listBox5.Items.AddRange(new object[] { "0" });
            listBox5.Location = new Point(194, 96);
            listBox5.Margin = new Padding(2);
            listBox5.Name = "listBox5";
            listBox5.SelectionMode = SelectionMode.None;
            listBox5.Size = new Size(59, 20);
            listBox5.TabIndex = 8;
            // 
            // listBox6
            // 
            listBox6.Anchor = AnchorStyles.Left;
            listBox6.BackColor = SystemColors.ControlDarkDark;
            listBox6.BorderStyle = BorderStyle.None;
            listBox6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox6.ForeColor = Color.White;
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 20;
            listBox6.Items.AddRange(new object[] { "0" });
            listBox6.Location = new Point(194, 36);
            listBox6.Margin = new Padding(2);
            listBox6.Name = "listBox6";
            listBox6.SelectionMode = SelectionMode.None;
            listBox6.Size = new Size(59, 20);
            listBox6.TabIndex = 9;
            // 
            // listBox7
            // 
            listBox7.Anchor = AnchorStyles.Left;
            listBox7.BackColor = SystemColors.ControlDarkDark;
            listBox7.BorderStyle = BorderStyle.None;
            listBox7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox7.ForeColor = Color.White;
            listBox7.FormattingEnabled = true;
            listBox7.ItemHeight = 20;
            listBox7.Items.AddRange(new object[] { "Current Semester:" });
            listBox7.Location = new Point(5, 7);
            listBox7.Margin = new Padding(2);
            listBox7.Name = "listBox7";
            listBox7.SelectionMode = SelectionMode.None;
            listBox7.Size = new Size(118, 20);
            listBox7.TabIndex = 10;
            // 
            // listBox8
            // 
            listBox8.Anchor = AnchorStyles.Left;
            listBox8.BackColor = SystemColors.ControlDarkDark;
            listBox8.BorderStyle = BorderStyle.None;
            listBox8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox8.ForeColor = Color.White;
            listBox8.FormattingEnabled = true;
            listBox8.ItemHeight = 20;
            listBox8.Items.AddRange(new object[] { "Total Hours:" });
            listBox8.Location = new Point(5, 36);
            listBox8.Margin = new Padding(2);
            listBox8.Name = "listBox8";
            listBox8.SelectionMode = SelectionMode.None;
            listBox8.Size = new Size(118, 20);
            listBox8.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Left;
            listBox1.BackColor = SystemColors.ControlDarkDark;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Hours still needed:" });
            listBox1.Location = new Point(5, 96);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(176, 20);
            listBox1.TabIndex = 6;
            // 
            // listBox9
            // 
            listBox9.Anchor = AnchorStyles.Left;
            listBox9.BackColor = SystemColors.ControlDarkDark;
            listBox9.BorderStyle = BorderStyle.None;
            listBox9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox9.ForeColor = Color.White;
            listBox9.FormattingEnabled = true;
            listBox9.ItemHeight = 20;
            listBox9.Items.AddRange(new object[] { "Total Hours Needed:" });
            listBox9.Location = new Point(5, 65);
            listBox9.Margin = new Padding(2);
            listBox9.Name = "listBox9";
            listBox9.SelectionMode = SelectionMode.None;
            listBox9.Size = new Size(153, 20);
            listBox9.TabIndex = 12;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(89, 0);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(103, 27);
            label10.TabIndex = 0;
            label10.Text = "Major(s):";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(88, 79);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 26);
            label11.TabIndex = 2;
            label11.Text = "Minor(s):";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(73, 296);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(134, 36);
            button2.TabIndex = 6;
            button2.Text = "Download data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // minorDisplay
            // 
            minorDisplay.Anchor = AnchorStyles.Top;
            minorDisplay.BackColor = SystemColors.ControlDark;
            minorDisplay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            minorDisplay.ForeColor = Color.White;
            minorDisplay.FormattingEnabled = true;
            minorDisplay.ItemHeight = 20;
            minorDisplay.Items.AddRange(new object[] { "Minor 1", "Minor 2" });
            minorDisplay.Location = new Point(50, 107);
            minorDisplay.Margin = new Padding(2);
            minorDisplay.Name = "minorDisplay";
            minorDisplay.SelectionMode = SelectionMode.None;
            minorDisplay.Size = new Size(180, 24);
            minorDisplay.TabIndex = 3;
            // 
            // majorDisplay
            // 
            majorDisplay.Anchor = AnchorStyles.Top;
            majorDisplay.BackColor = SystemColors.ControlDark;
            majorDisplay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            majorDisplay.ForeColor = Color.White;
            majorDisplay.FormattingEnabled = true;
            majorDisplay.ItemHeight = 20;
            majorDisplay.Items.AddRange(new object[] { "Major 1", "Major 2" });
            majorDisplay.Location = new Point(50, 29);
            majorDisplay.Margin = new Padding(2);
            majorDisplay.Name = "majorDisplay";
            majorDisplay.SelectionMode = SelectionMode.None;
            majorDisplay.Size = new Size(180, 24);
            majorDisplay.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(18, 14);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(134, 22);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openSaveFileDialog
            // 
            openSaveFileDialog.FileName = "openSaveFileDialog";
            openSaveFileDialog.Title = "Select your save data.";
            openSaveFileDialog.FileOk += openSaveFileDialog_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1199, 562);
            Controls.Add(mainScreenPanel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(button6);
            Controls.Add(MajorButton);
            Controls.Add(continueButton);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            mainScreenPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTheology).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRecommended).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridGenEd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCognate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMajors).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox MajorList;
        private ComboBox MinorBox;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label8;
        private Label label9;
        private Button button3;
        private Button button4;
        private Button continueButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button MajorButton;
        private ComboBox MajorList2;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox MinorBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel mainScreenPanel;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private Label label11;
        private ListBox majorDisplay;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox minorDisplay;
        private ListBox listBox4;
        private Button button2;
        private Label label13;
        private TextBox textBox74;
        private TextBox textBox42;
        private TextBox textBox3;
        private DataGridView dataGridMajors;
        private TextBox textBox4;
        private Label label12;
        private ListBox listBox2;
        private ListBox listBox5;
        private ListBox listBox6;
        private ListBox listBox7;
        private ListBox listBox8;
        private ListBox listBox1;
        private ListBox listBox9;
        private DataGridViewTextBoxColumn ClassCode;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Hours;
        private DataGridViewButtonColumn Details;
        private DataGridView dataGridCognate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridView dataGridRecommended;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private TextBox textBox6;
        private Panel panel1;
        private DataGridView dataGridGenEd;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridView dataGridTheology;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private OpenFileDialog openSaveFileDialog;
    }
}