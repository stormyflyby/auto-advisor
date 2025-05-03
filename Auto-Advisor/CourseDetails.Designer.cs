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
            courseDetailsLabel.Location = new Point(384, 4);
            courseDetailsLabel.Name = "courseDetailsLabel";
            courseDetailsLabel.Size = new Size(215, 41);
            courseDetailsLabel.TabIndex = 0;
            courseDetailsLabel.Text = "Course Details:";
            // 
            // courseTitleLabel
            // 
            courseTitleLabel.AutoSize = true;
            courseTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            courseTitleLabel.ForeColor = Color.White;
            courseTitleLabel.Location = new Point(291, 45);
            courseTitleLabel.Name = "courseTitleLabel";
            courseTitleLabel.Size = new Size(395, 41);
            courseTitleLabel.TabIndex = 1;
            courseTitleLabel.Text = "ABCD 1234 - Intro to English";
            courseTitleLabel.Click += label1_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.Location = new Point(74, 140);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(348, 334);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // descriptionTitle
            // 
            descriptionTitle.BackColor = Color.FromArgb(0, 0, 64);
            descriptionTitle.BorderStyle = BorderStyle.Fixed3D;
            descriptionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTitle.ForeColor = Color.White;
            descriptionTitle.Location = new Point(74, 102);
            descriptionTitle.Name = "descriptionTitle";
            descriptionTitle.Size = new Size(348, 34);
            descriptionTitle.TabIndex = 3;
            descriptionTitle.Text = "Description:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(537, 102);
            label1.Name = "label1";
            label1.Size = new Size(348, 34);
            label1.TabIndex = 5;
            label1.Text = "Prerequisites:";
            label1.Click += label1_Click_1;
            // 
            // prereqsLabel
            // 
            prereqsLabel.ForeColor = Color.White;
            prereqsLabel.Location = new Point(537, 140);
            prereqsLabel.Name = "prereqsLabel";
            prereqsLabel.Size = new Size(348, 144);
            prereqsLabel.TabIndex = 4;
            prereqsLabel.Text = "List of prereqs\r\nList of prereqs\r\nList of prereqs\r\nList of prereqs\r\nList of prereqs\r\n";
            // 
            // infoTitle
            // 
            infoTitle.BackColor = Color.FromArgb(0, 0, 64);
            infoTitle.BorderStyle = BorderStyle.Fixed3D;
            infoTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            infoTitle.ForeColor = Color.White;
            infoTitle.Location = new Point(537, 297);
            infoTitle.Name = "infoTitle";
            infoTitle.Size = new Size(348, 34);
            infoTitle.TabIndex = 7;
            infoTitle.Text = "Additional info:";
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(537, 334);
            label4.Name = "label4";
            label4.Size = new Size(348, 122);
            label4.TabIndex = 6;
            label4.Text = "N/A\r\n";
            // 
            // CourseDescription
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(0, 0, 40);
            ClientSize = new Size(966, 522);
            Controls.Add(infoTitle);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(prereqsLabel);
            Controls.Add(descriptionTitle);
            Controls.Add(descriptionLabel);
            Controls.Add(courseTitleLabel);
            Controls.Add(courseDetailsLabel);
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