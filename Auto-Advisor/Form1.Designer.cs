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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            TextBox textBox5;
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            label12 = new Label();
            dataGridView3 = new DataGridView();
            ClassCode4 = new DataGridViewTextBoxColumn();
            ClassName4 = new DataGridViewTextBoxColumn();
            Hours4 = new DataGridViewTextBoxColumn();
            Details4 = new DataGridViewButtonColumn();
            dataGridView5 = new DataGridView();
            ClassCode3 = new DataGridViewTextBoxColumn();
            ClassName3 = new DataGridViewTextBoxColumn();
            Hours3 = new DataGridViewTextBoxColumn();
            Details3 = new DataGridViewButtonColumn();
            textBox4 = new TextBox();
            dataGridView2 = new DataGridView();
            ClassCode2 = new DataGridViewTextBoxColumn();
            ClassName2 = new DataGridViewTextBoxColumn();
            Hours2 = new DataGridViewTextBoxColumn();
            Details2 = new DataGridViewButtonColumn();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridView1 = new DataGridView();
            ClassCode = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Hours = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            textBox74 = new TextBox();
            textBox42 = new TextBox();
            textBox3 = new TextBox();
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
            minorDisplay = new ListBox();
            majorDisplay = new ListBox();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            mainScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label2.Location = new Point(221, 139);
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
            label3.Location = new Point(221, 181);
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
            label6.Location = new Point(221, 311);
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
            label9.Location = new Point(246, 515);
            label9.Name = "label9";
            label9.Size = new Size(232, 39);
            label9.TabIndex = 14;
            label9.Text = "Please enter class codes, separated by a line\r\n Example: COSC 1303\r\n                  BIBL 1023\r\n";
            // 
            // button3
            // 
            button3.Location = new Point(556, 634);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 18;
            button3.Text = "Download Data";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(689, 635);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 19;
            button4.Text = "Enter Saved Data";
            button4.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(817, 634);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(73, 23);
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
            tableLayoutPanel3.Location = new Point(594, 139);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(246, 47);
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
            MajorButton.Size = new Size(74, 23);
            MajorButton.TabIndex = 21;
            MajorButton.Text = "Add Major";
            MajorButton.UseVisualStyleBackColor = true;
            MajorButton.Click += button6_Click;
            // 
            // button6
            // 
            button6.Location = new Point(517, 188);
            button6.Name = "button6";
            button6.Size = new Size(74, 23);
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
            tableLayoutPanel4.Location = new Point(594, 187);
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
            textBox1.Location = new Point(594, 317);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(210, 158);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(594, 485);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(210, 118);
            textBox2.TabIndex = 25;
            // 
            // mainScreenPanel
            // 
            mainScreenPanel.Controls.Add(label12);
            mainScreenPanel.Controls.Add(dataGridView3);
            mainScreenPanel.Controls.Add(dataGridView5);
            mainScreenPanel.Controls.Add(textBox4);
            mainScreenPanel.Controls.Add(textBox5);
            mainScreenPanel.Controls.Add(dataGridView2);
            mainScreenPanel.Controls.Add(dataGridView4);
            mainScreenPanel.Controls.Add(dataGridView1);
            mainScreenPanel.Controls.Add(textBox74);
            mainScreenPanel.Controls.Add(textBox42);
            mainScreenPanel.Controls.Add(textBox3);
            mainScreenPanel.Controls.Add(label13);
            mainScreenPanel.Controls.Add(tableLayoutPanel1);
            mainScreenPanel.Controls.Add(button1);
            mainScreenPanel.Location = new Point(0, 0);
            mainScreenPanel.Margin = new Padding(2);
            mainScreenPanel.Name = "mainScreenPanel";
            mainScreenPanel.Size = new Size(1345, 1274);
            mainScreenPanel.TabIndex = 26;
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
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { ClassCode4, ClassName4, Hours4, Details4 });
            dataGridView3.Location = new Point(271, 1032);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.ScrollBars = ScrollBars.Vertical;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(650, 158);
            dataGridView3.TabIndex = 240;
            // 
            // ClassCode4
            // 
            ClassCode4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassCode4.Frozen = true;
            ClassCode4.HeaderText = "Class Code";
            ClassCode4.MinimumWidth = 8;
            ClassCode4.Name = "ClassCode4";
            ClassCode4.ReadOnly = true;
            ClassCode4.Width = 178;
            // 
            // ClassName4
            // 
            ClassName4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassName4.Frozen = true;
            ClassName4.HeaderText = "Class Name";
            ClassName4.MinimumWidth = 8;
            ClassName4.Name = "ClassName4";
            ClassName4.ReadOnly = true;
            ClassName4.SortMode = DataGridViewColumnSortMode.NotSortable;
            ClassName4.Width = 177;
            // 
            // Hours4
            // 
            Hours4.HeaderText = "Hours";
            Hours4.MinimumWidth = 8;
            Hours4.Name = "Hours4";
            Hours4.ReadOnly = true;
            Hours4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Details4
            // 
            Details4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Details4.HeaderText = "Details";
            Details4.MinimumWidth = 8;
            Details4.Name = "Details4";
            Details4.Resizable = DataGridViewTriState.True;
            Details4.Text = "More...";
            Details4.UseColumnTextForButtonValue = true;
            Details4.Width = 178;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.AllowUserToResizeColumns = false;
            dataGridView5.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.BorderStyle = BorderStyle.None;
            dataGridView5.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { ClassCode3, ClassName3, Hours3, Details3 });
            dataGridView5.Location = new Point(270, 790);
            dataGridView5.Margin = new Padding(2);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersVisible = false;
            dataGridView5.RowHeadersWidth = 62;
            dataGridView5.RowTemplate.Height = 33;
            dataGridView5.ScrollBars = ScrollBars.Vertical;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.Size = new Size(650, 158);
            dataGridView5.TabIndex = 239;
            // 
            // ClassCode3
            // 
            ClassCode3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassCode3.Frozen = true;
            ClassCode3.HeaderText = "Class Code";
            ClassCode3.MinimumWidth = 8;
            ClassCode3.Name = "ClassCode3";
            ClassCode3.ReadOnly = true;
            ClassCode3.Width = 178;
            // 
            // ClassName3
            // 
            ClassName3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassName3.Frozen = true;
            ClassName3.HeaderText = "Class Name";
            ClassName3.MinimumWidth = 8;
            ClassName3.Name = "ClassName3";
            ClassName3.ReadOnly = true;
            ClassName3.SortMode = DataGridViewColumnSortMode.NotSortable;
            ClassName3.Width = 177;
            // 
            // Hours3
            // 
            Hours3.HeaderText = "Hours";
            Hours3.MinimumWidth = 8;
            Hours3.Name = "Hours3";
            Hours3.ReadOnly = true;
            Hours3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Details3
            // 
            Details3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Details3.HeaderText = "Details";
            Details3.MinimumWidth = 8;
            Details3.Name = "Details3";
            Details3.Resizable = DataGridViewTriState.True;
            Details3.Text = "More...";
            Details3.UseColumnTextForButtonValue = true;
            Details3.Width = 178;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DimGray;
            textBox4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(273, 983);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(650, 52);
            textBox4.TabIndex = 238;
            textBox4.Text = "Theology and Vocation Courses";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DimGray;
            textBox5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(271, 739);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(650, 52);
            textBox5.TabIndex = 237;
            textBox5.Text = "General Education Courses";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ClassCode2, ClassName2, Hours2, Details2 });
            dataGridView2.Location = new Point(271, 547);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(650, 158);
            dataGridView2.TabIndex = 236;
            // 
            // ClassCode2
            // 
            ClassCode2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassCode2.Frozen = true;
            ClassCode2.HeaderText = "Class Code";
            ClassCode2.MinimumWidth = 8;
            ClassCode2.Name = "ClassCode2";
            ClassCode2.ReadOnly = true;
            ClassCode2.Width = 178;
            // 
            // ClassName2
            // 
            ClassName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ClassName2.Frozen = true;
            ClassName2.HeaderText = "Class Name";
            ClassName2.MinimumWidth = 8;
            ClassName2.Name = "ClassName2";
            ClassName2.ReadOnly = true;
            ClassName2.SortMode = DataGridViewColumnSortMode.NotSortable;
            ClassName2.Width = 177;
            // 
            // Hours2
            // 
            Hours2.HeaderText = "Hours";
            Hours2.MinimumWidth = 8;
            Hours2.Name = "Hours2";
            Hours2.ReadOnly = true;
            Hours2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Details2
            // 
            Details2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Details2.HeaderText = "Details";
            Details2.MinimumWidth = 8;
            Details2.Name = "Details2";
            Details2.Resizable = DataGridViewTriState.True;
            Details2.Text = "More...";
            Details2.UseColumnTextForButtonValue = true;
            Details2.Width = 178;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewButtonColumn1 });
            dataGridView4.Location = new Point(271, 58);
            dataGridView4.Margin = new Padding(2);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.RowTemplate.Height = 33;
            dataGridView4.ScrollBars = ScrollBars.Vertical;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(650, 158);
            dataGridView4.TabIndex = 235;
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
            dataGridViewTextBoxColumn8.Width = 177;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Hours";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClassCode, ClassName, Hours, Details });
            dataGridView1.Location = new Point(271, 302);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(650, 158);
            dataGridView1.TabIndex = 233;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            ClassName.Width = 177;
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
            // textBox74
            // 
            textBox74.BackColor = Color.DimGray;
            textBox74.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox74.ForeColor = Color.White;
            textBox74.Location = new Point(271, 497);
            textBox74.Name = "textBox74";
            textBox74.ReadOnly = true;
            textBox74.Size = new Size(650, 52);
            textBox74.TabIndex = 208;
            textBox74.Text = "Cognate Courses";
            textBox74.TextAlign = HorizontalAlignment.Center;
            textBox74.TextChanged += textBox74_TextChanged;
            // 
            // textBox42
            // 
            textBox42.BackColor = Color.DimGray;
            textBox42.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox42.ForeColor = Color.White;
            textBox42.Location = new Point(271, 252);
            textBox42.Name = "textBox42";
            textBox42.ReadOnly = true;
            textBox42.Size = new Size(650, 52);
            textBox42.TabIndex = 183;
            textBox42.Text = "Major Classes";
            textBox42.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DimGray;
            textBox3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(271, 10);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(650, 52);
            textBox3.TabIndex = 158;
            textBox3.Text = "Recommended Classes";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
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
            tableLayoutPanel1.Controls.Add(minorDisplay, 0, 3);
            tableLayoutPanel1.Controls.Add(majorDisplay, 0, 1);
            tableLayoutPanel1.Controls.Add(label10, 0, 0);
            tableLayoutPanel1.Controls.Add(label11, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 0, 5);
            tableLayoutPanel1.Location = new Point(1060, 7);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.410441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.370837F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.320432F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.830783F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.50225F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.840684F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.2646255F));
            tableLayoutPanel1.Size = new Size(281, 667);
            tableLayoutPanel1.TabIndex = 1;
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
            tableLayoutPanel2.Location = new Point(11, 175);
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
            // minorDisplay
            // 
            minorDisplay.Anchor = AnchorStyles.Top;
            minorDisplay.BackColor = SystemColors.ControlDark;
            minorDisplay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            minorDisplay.ForeColor = Color.White;
            minorDisplay.FormattingEnabled = true;
            minorDisplay.ItemHeight = 20;
            minorDisplay.Items.AddRange(new object[] { "Minor 1", "Minor 2" });
            minorDisplay.Location = new Point(50, 114);
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
            majorDisplay.Location = new Point(50, 31);
            majorDisplay.Margin = new Padding(2);
            majorDisplay.Name = "majorDisplay";
            majorDisplay.SelectionMode = SelectionMode.None;
            majorDisplay.Size = new Size(180, 24);
            majorDisplay.TabIndex = 2;
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
            label10.Size = new Size(103, 29);
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
            label11.Location = new Point(88, 84);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 28);
            label11.TabIndex = 2;
            label11.Text = "Minor(s):";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(73, 316);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(134, 36);
            button2.TabIndex = 6;
            button2.Text = "Download data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 13);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(134, 22);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1347, 630);
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
            mainScreenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ClassCode;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Hours;
        private DataGridViewButtonColumn Details;
        private DataGridView dataGridView2;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridView dataGridView3;
        private DataGridView dataGridView5;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label12;
        private DataGridViewTextBoxColumn ClassCode3;
        private DataGridViewTextBoxColumn ClassName3;
        private DataGridViewTextBoxColumn Hours3;
        private DataGridViewButtonColumn Details3;
        private DataGridViewTextBoxColumn ClassCode2;
        private DataGridViewTextBoxColumn ClassName2;
        private DataGridViewTextBoxColumn Hours2;
        private DataGridViewButtonColumn Details2;
        private DataGridViewTextBoxColumn ClassCode4;
        private DataGridViewTextBoxColumn ClassName4;
        private DataGridViewTextBoxColumn Hours4;
        private DataGridViewButtonColumn Details4;
        private ListBox listBox2;
        private ListBox listBox5;
        private ListBox listBox6;
        private ListBox listBox7;
        private ListBox listBox8;
        private ListBox listBox1;
        private ListBox listBox9;
    }
}