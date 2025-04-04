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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            listBox3 = new ListBox();
            minorDisplay = new ListBox();
            majorDisplay = new ListBox();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            mainScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(467, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(871, 67);
            label1.TabIndex = 1;
            label1.Text = "Please enter your information below - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(316, 232);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(309, 41);
            label2.TabIndex = 2;
            label2.Text = "Select your Major(s) - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(316, 302);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(303, 41);
            label3.TabIndex = 3;
            label3.Text = "Select your Minor(s)- ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(316, 377);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(416, 41);
            label4.TabIndex = 4;
            label4.Text = "Are you an Honors student? - ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(316, 447);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(558, 41);
            label5.TabIndex = 5;
            label5.Text = "What is your upcoming semester?(1-8) - ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(316, 518);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(499, 41);
            label6.TabIndex = 6;
            label6.Text = "What classes have you completed? -";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(316, 797);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(541, 41);
            label7.TabIndex = 7;
            label7.Text = "What classes are you currently taking?- ";
            // 
            // MajorList
            // 
            MajorList.DropDownStyle = ComboBoxStyle.DropDownList;
            MajorList.FormattingEnabled = true;
            MajorList.Items.AddRange(new object[] { "Computer Science(CS)", "Gender Studies" });
            MajorList.Location = new Point(4, 5);
            MajorList.Margin = new Padding(4, 5, 4, 5);
            MajorList.Name = "MajorList";
            MajorList.Size = new Size(165, 33);
            MajorList.TabIndex = 8;
            // 
            // MinorBox
            // 
            MinorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MinorBox.FormattingEnabled = true;
            MinorBox.Items.AddRange(new object[] { "None", "Biblical Studies" });
            MinorBox.Location = new Point(4, 5);
            MinorBox.Margin = new Padding(4, 5, 4, 5);
            MinorBox.Name = "MinorBox";
            MinorBox.Size = new Size(165, 33);
            MinorBox.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "No", "Yes" });
            comboBox3.Location = new Point(866, 385);
            comboBox3.Margin = new Padding(4, 5, 4, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(171, 33);
            comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBox4.Location = new Point(867, 457);
            comboBox4.Margin = new Padding(4, 5, 4, 5);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(171, 33);
            comboBox4.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(351, 567);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(312, 63);
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
            label9.Location = new Point(351, 858);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(312, 63);
            label9.TabIndex = 14;
            label9.Text = "Please enter class codes, separated by a line\r\n Example: COSC 1303\r\n                  BIBL 1023\r\n";
            // 
            // button3
            // 
            button3.Location = new Point(794, 1057);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(150, 38);
            button3.TabIndex = 18;
            button3.Text = "Download Data";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(984, 1058);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(150, 38);
            button4.TabIndex = 19;
            button4.Text = "Enter Saved Data";
            button4.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(1167, 1057);
            continueButton.Margin = new Padding(4, 5, 4, 5);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(104, 38);
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
            tableLayoutPanel3.Location = new Point(849, 232);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(351, 78);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // MajorList2
            // 
            MajorList2.DropDownStyle = ComboBoxStyle.DropDownList;
            MajorList2.FormattingEnabled = true;
            MajorList2.Items.AddRange(new object[] { "Computer Science(CS)", "Gender Studies" });
            MajorList2.Location = new Point(179, 5);
            MajorList2.Margin = new Padding(4, 5, 4, 5);
            MajorList2.Name = "MajorList2";
            MajorList2.Size = new Size(165, 33);
            MajorList2.TabIndex = 9;
            MajorList2.Visible = false;
            // 
            // MajorButton
            // 
            MajorButton.Location = new Point(739, 235);
            MajorButton.Margin = new Padding(4, 5, 4, 5);
            MajorButton.Name = "MajorButton";
            MajorButton.Size = new Size(106, 38);
            MajorButton.TabIndex = 21;
            MajorButton.Text = "Add Major";
            MajorButton.UseVisualStyleBackColor = true;
            MajorButton.Click += button6_Click;
            // 
            // button6
            // 
            button6.Location = new Point(739, 313);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(106, 38);
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
            tableLayoutPanel4.Location = new Point(849, 312);
            tableLayoutPanel4.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(351, 65);
            tableLayoutPanel4.TabIndex = 23;
            // 
            // MinorBox2
            // 
            MinorBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            MinorBox2.FormattingEnabled = true;
            MinorBox2.Items.AddRange(new object[] { "None", "Biblical Studies" });
            MinorBox2.Location = new Point(179, 5);
            MinorBox2.Margin = new Padding(4, 5, 4, 5);
            MinorBox2.Name = "MinorBox2";
            MinorBox2.Size = new Size(165, 33);
            MinorBox2.TabIndex = 24;
            MinorBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(849, 528);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(298, 261);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(849, 808);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(298, 194);
            textBox2.TabIndex = 25;
            // 
            // mainScreenPanel
            // 
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
            mainScreenPanel.Name = "mainScreenPanel";
            mainScreenPanel.Size = new Size(1921, 1142);
            mainScreenPanel.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClassCode, ClassName, Hours, Details });
            dataGridView1.Location = new Point(506, 401);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(710, 252);
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
            textBox74.Location = new Point(528, 674);
            textBox74.Margin = new Padding(4, 5, 4, 5);
            textBox74.Name = "textBox74";
            textBox74.Size = new Size(664, 74);
            textBox74.TabIndex = 208;
            textBox74.Text = "Electives";
            textBox74.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox42
            // 
            textBox42.BackColor = Color.DimGray;
            textBox42.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox42.ForeColor = Color.White;
            textBox42.Location = new Point(529, 319);
            textBox42.Margin = new Padding(4, 5, 4, 5);
            textBox42.Name = "textBox42";
            textBox42.Size = new Size(664, 74);
            textBox42.TabIndex = 183;
            textBox42.Text = "Major Classes";
            textBox42.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DimGray;
            textBox3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(529, 17);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(664, 74);
            textBox3.TabIndex = 158;
            textBox3.Text = "Recommended Classes";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.ControlLight;
            label13.Location = new Point(1499, -7);
            label13.MaximumSize = new Size(250, 2500);
            label13.Name = "label13";
            label13.Size = new Size(3, 1147);
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
            tableLayoutPanel1.Location = new Point(1514, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.410441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.370837F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.320432F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.830783F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.50225F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.840684F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.2646255F));
            tableLayoutPanel1.Size = new Size(401, 1112);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176F));
            tableLayoutPanel2.Controls.Add(listBox4, 1, 0);
            tableLayoutPanel2.Controls.Add(listBox3, 0, 0);
            tableLayoutPanel2.Location = new Point(16, 306);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RightToLeft = RightToLeft.No;
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(369, 182);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // listBox4
            // 
            listBox4.Anchor = AnchorStyles.Left;
            listBox4.BackColor = SystemColors.ControlDarkDark;
            listBox4.BorderStyle = BorderStyle.None;
            listBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 30;
            listBox4.Items.AddRange(new object[] { "0", "0", "0", "0" });
            listBox4.Location = new Point(196, 31);
            listBox4.Name = "listBox4";
            listBox4.SelectionMode = SelectionMode.None;
            listBox4.Size = new Size(168, 120);
            listBox4.TabIndex = 5;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.Anchor = AnchorStyles.Left;
            listBox3.BackColor = SystemColors.ControlDarkDark;
            listBox3.BorderStyle = BorderStyle.None;
            listBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 30;
            listBox3.Items.AddRange(new object[] { "Current semester:", "Total hours:", "Total needed", "Still need:" });
            listBox3.Location = new Point(3, 31);
            listBox3.Name = "listBox3";
            listBox3.SelectionMode = SelectionMode.None;
            listBox3.Size = new Size(185, 120);
            listBox3.TabIndex = 4;
            // 
            // minorDisplay
            // 
            minorDisplay.Anchor = AnchorStyles.Top;
            minorDisplay.BackColor = SystemColors.ControlDark;
            minorDisplay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            minorDisplay.FormattingEnabled = true;
            minorDisplay.ItemHeight = 30;
            minorDisplay.Items.AddRange(new object[] { "Minor 1", "Minor 2" });
            minorDisplay.Location = new Point(73, 190);
            minorDisplay.Name = "minorDisplay";
            minorDisplay.SelectionMode = SelectionMode.None;
            minorDisplay.Size = new Size(255, 64);
            minorDisplay.TabIndex = 3;
            // 
            // majorDisplay
            // 
            majorDisplay.Anchor = AnchorStyles.Top;
            majorDisplay.BackColor = SystemColors.ControlDark;
            majorDisplay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            majorDisplay.FormattingEnabled = true;
            majorDisplay.ItemHeight = 30;
            majorDisplay.Items.AddRange(new object[] { "Major 1", "Major 2" });
            majorDisplay.Location = new Point(73, 51);
            majorDisplay.Name = "majorDisplay";
            majorDisplay.SelectionMode = SelectionMode.None;
            majorDisplay.Size = new Size(255, 64);
            majorDisplay.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(126, 0);
            label10.Name = "label10";
            label10.Size = new Size(149, 46);
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
            label11.Location = new Point(125, 140);
            label11.Name = "label11";
            label11.Size = new Size(151, 46);
            label11.TabIndex = 2;
            label11.Text = "Minor(s):";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(105, 528);
            button2.Name = "button2";
            button2.Size = new Size(191, 60);
            button2.TabIndex = 6;
            button2.Text = "Download data";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(26, 22);
            button1.Name = "button1";
            button1.Size = new Size(191, 37);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewButtonColumn1 });
            dataGridView4.Location = new Point(506, 97);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.RowTemplate.Height = 33;
            dataGridView4.ScrollBars = ScrollBars.Vertical;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(710, 199);
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
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewButtonColumn2 });
            dataGridView2.Location = new Point(506, 756);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(710, 252);
            dataGridView2.TabIndex = 236;
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
            dataGridViewTextBoxColumn2.Width = 177;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1924, 1050);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            mainScreenPanel.ResumeLayout(false);
            mainScreenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private ListBox listBox3;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}