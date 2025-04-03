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
            button5 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            MajorList2 = new ComboBox();
            MajorButton = new Button();
            button6 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            MinorBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            label2.Location = new Point(316, 267);
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
            label3.Location = new Point(316, 338);
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
            label4.Location = new Point(316, 412);
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
            label5.Location = new Point(316, 483);
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
            label6.Location = new Point(316, 555);
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
            label7.Location = new Point(316, 833);
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
            comboBox3.Location = new Point(867, 412);
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
            comboBox4.Location = new Point(867, 483);
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
            label8.Location = new Point(351, 602);
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
            label9.Location = new Point(351, 895);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(312, 63);
            label9.TabIndex = 14;
            label9.Text = "Please enter class codes, separated by a line\r\n Example: COSC 1303\r\n                  BIBL 1023\r\n";
            // 
            // button3
            // 
            button3.Location = new Point(1050, 1200);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(150, 38);
            button3.TabIndex = 18;
            button3.Text = "Download Data";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1240, 1200);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(150, 38);
            button4.TabIndex = 19;
            button4.Text = "Enter Saved Data";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1423, 1200);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(104, 38);
            button5.TabIndex = 20;
            button5.Text = "Continue";
            button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(MajorList2, 1, 0);
            tableLayoutPanel3.Controls.Add(MajorList, 0, 0);
            tableLayoutPanel3.Location = new Point(849, 267);
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
            MajorButton.Location = new Point(739, 278);
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
            button6.Location = new Point(739, 347);
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
            tableLayoutPanel4.Location = new Point(849, 347);
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
            textBox1.Location = new Point(849, 565);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(299, 260);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(849, 844);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(299, 194);
            textBox2.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1924, 1050);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(button6);
            Controls.Add(MajorButton);
            Controls.Add(button5);
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
        private Button button5;
        private TableLayoutPanel tableLayoutPanel3;
        private Button MajorButton;
        private ComboBox MajorList2;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox MinorBox2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}