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
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            MajorList2 = new ComboBox();
            MajorButton = new Button();
            button6 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            MinorBox2 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            label2.Location = new Point(221, 160);
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
            label3.Location = new Point(221, 203);
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
            label4.Location = new Point(221, 247);
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
            label5.Location = new Point(221, 290);
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
            label6.Location = new Point(221, 333);
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
            label7.Location = new Point(221, 500);
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
            comboBox3.Location = new Point(594, 252);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBox4.Location = new Point(594, 290);
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
            label8.Location = new Point(246, 361);
            label8.Name = "label8";
            label8.Size = new Size(251, 13);
            label8.TabIndex = 13;
            label8.Text = "Please enter the class code Example: COSC 1303";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(246, 537);
            label9.Name = "label9";
            label9.Size = new Size(251, 13);
            label9.TabIndex = 14;
            label9.Text = "Please enter the class code Example: COSC 1303";
            // 
            // button1
            // 
            button1.Location = new Point(513, 361);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Class";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox5, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox6, 0, 5);
            tableLayoutPanel1.Location = new Point(594, 331);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.45283F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.72327F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.Size = new Size(992, 184);
            tableLayoutPanel1.TabIndex = 15;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 123);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(118, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(3, 153);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(118, 23);
            textBox6.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Controls.Add(textBox7, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox8, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox9, 0, 2);
            tableLayoutPanel2.Controls.Add(textBox10, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox11, 0, 4);
            tableLayoutPanel2.Controls.Add(textBox12, 0, 5);
            tableLayoutPanel2.Location = new Point(594, 518);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.Size = new Size(992, 182);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(118, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(3, 33);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(118, 23);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(3, 63);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(118, 23);
            textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(3, 93);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(118, 23);
            textBox10.TabIndex = 9;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(3, 123);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(118, 23);
            textBox11.TabIndex = 10;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(3, 153);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(118, 23);
            textBox12.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(513, 537);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Add Class";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(735, 720);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 18;
            button3.Text = "Download Data";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(868, 720);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 19;
            button4.Text = "Enter Saved Data";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(996, 720);
            button5.Name = "button5";
            button5.Size = new Size(73, 23);
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
            tableLayoutPanel3.Location = new Point(594, 160);
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
            MajorButton.Location = new Point(517, 167);
            MajorButton.Name = "MajorButton";
            MajorButton.Size = new Size(74, 23);
            MajorButton.TabIndex = 21;
            MajorButton.Text = "Add Major";
            MajorButton.UseVisualStyleBackColor = true;
            MajorButton.Click += button6_Click;
            // 
            // button6
            // 
            button6.Location = new Point(517, 208);
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
            tableLayoutPanel4.Location = new Point(594, 208);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(246, 47);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1696, 926);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(button6);
            Controls.Add(MajorButton);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(button1);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button button3;
        private Button button4;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel3;
        private Button MajorButton;
        private ComboBox MajorList2;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox MinorBox2;
    }
}