namespace Auto_Advisor
{
    partial class CourseDescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseDescription));
            courseDetailsLabel = new Label();
            courseTitleLabel = new Label();
            descriptionLabel = new Label();
            descriptionTitle = new Label();
            label1 = new Label();
            prereqsLabel = new Label();
            infoTitle = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // courseDetailsLabel
            // 
            courseDetailsLabel.AutoSize = true;
            courseDetailsLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            courseDetailsLabel.ForeColor = Color.White;
            courseDetailsLabel.Location = new Point(256, 3);
            courseDetailsLabel.Margin = new Padding(2, 0, 2, 0);
            courseDetailsLabel.Name = "courseDetailsLabel";
            courseDetailsLabel.Size = new Size(140, 28);
            courseDetailsLabel.TabIndex = 0;
            courseDetailsLabel.Text = "Course Details:";
            // 
            // courseTitleLabel
            // 
            courseTitleLabel.Anchor = AnchorStyles.None;
            courseTitleLabel.AutoSize = true;
            courseTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            courseTitleLabel.ForeColor = Color.White;
            courseTitleLabel.Location = new Point(194, 30);
            courseTitleLabel.Margin = new Padding(2, 0, 2, 0);
            courseTitleLabel.Name = "courseTitleLabel";
            courseTitleLabel.Size = new Size(262, 28);
            courseTitleLabel.TabIndex = 1;
            courseTitleLabel.Text = "ABCD 1234 - Intro to English";
            courseTitleLabel.Click += label1_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.Location = new Point(49, 93);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(232, 223);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // descriptionTitle
            // 
            descriptionTitle.BackColor = SystemColors.ControlDark;
            descriptionTitle.BorderStyle = BorderStyle.Fixed3D;
            descriptionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTitle.ForeColor = Color.White;
            descriptionTitle.Location = new Point(49, 68);
            descriptionTitle.Margin = new Padding(2, 0, 2, 0);
            descriptionTitle.Name = "descriptionTitle";
            descriptionTitle.Size = new Size(232, 23);
            descriptionTitle.TabIndex = 3;
            descriptionTitle.Text = "Description:";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(358, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 23);
            label1.TabIndex = 5;
            label1.Text = "Prerequisites:";
            label1.Click += label1_Click_1;
            // 
            // prereqsLabel
            // 
            prereqsLabel.ForeColor = Color.White;
            prereqsLabel.Location = new Point(358, 93);
            prereqsLabel.Margin = new Padding(2, 0, 2, 0);
            prereqsLabel.Name = "prereqsLabel";
            prereqsLabel.Size = new Size(232, 96);
            prereqsLabel.TabIndex = 4;
            prereqsLabel.Text = "List of prereqs\r\nList of prereqs\r\nList of prereqs\r\nList of prereqs\r\nList of prereqs\r\n";
            // 
            // infoTitle
            // 
            infoTitle.BackColor = SystemColors.ControlDark;
            infoTitle.BorderStyle = BorderStyle.Fixed3D;
            infoTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            infoTitle.ForeColor = Color.White;
            infoTitle.Location = new Point(358, 198);
            infoTitle.Margin = new Padding(2, 0, 2, 0);
            infoTitle.Name = "infoTitle";
            infoTitle.Size = new Size(232, 23);
            infoTitle.TabIndex = 7;
            infoTitle.Text = "Additional info:";
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(358, 223);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 81);
            label4.TabIndex = 6;
            label4.Text = "N/A\r\n";
            // 
            // CourseDescription
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(644, 348);
            Controls.Add(infoTitle);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(prereqsLabel);
            Controls.Add(descriptionTitle);
            Controls.Add(descriptionLabel);
            Controls.Add(courseTitleLabel);
            Controls.Add(courseDetailsLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CourseDescription";
            Text = "CourseDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label courseDetailsLabel;
        private Label courseTitleLabel;
        private Label descriptionLabel;
        private Label descriptionTitle;
        private Label label1;
        private Label prereqsLabel;
        private Label infoTitle;
        private Label label4;
    }
}