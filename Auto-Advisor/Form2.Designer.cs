namespace Auto_Advisor
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            courseDetailsLabel.Location = new Point(400, 5);
            courseDetailsLabel.Name = "courseDetailsLabel";
            courseDetailsLabel.Size = new Size(215, 41);
            courseDetailsLabel.TabIndex = 0;
            courseDetailsLabel.Text = "Course Details:";
            // 
            // courseTitleLabel
            // 
            courseTitleLabel.Anchor = AnchorStyles.None;
            courseTitleLabel.AutoSize = true;
            courseTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            courseTitleLabel.ForeColor = Color.White;
            courseTitleLabel.Location = new Point(303, 46);
            courseTitleLabel.Name = "courseTitleLabel";
            courseTitleLabel.Size = new Size(395, 41);
            courseTitleLabel.TabIndex = 1;
            courseTitleLabel.Text = "ABCD 1234 - Intro to English";
            courseTitleLabel.Click += label1_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.Location = new Point(76, 145);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(363, 187);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // descriptionTitle
            // 
            descriptionTitle.BackColor = SystemColors.ControlDark;
            descriptionTitle.BorderStyle = BorderStyle.Fixed3D;
            descriptionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTitle.ForeColor = Color.White;
            descriptionTitle.Location = new Point(76, 106);
            descriptionTitle.Name = "descriptionTitle";
            descriptionTitle.Size = new Size(363, 37);
            descriptionTitle.TabIndex = 3;
            descriptionTitle.Text = "Description:";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(558, 106);
            label1.Name = "label1";
            label1.Size = new Size(363, 37);
            label1.TabIndex = 5;
            label1.Text = "Prerequisites:";
            // 
            // prereqsLabel
            // 
            prereqsLabel.ForeColor = Color.White;
            prereqsLabel.Location = new Point(558, 145);
            prereqsLabel.Name = "prereqsLabel";
            prereqsLabel.Size = new Size(363, 150);
            prereqsLabel.TabIndex = 4;
            prereqsLabel.Text = "List of prereqs\r\nList of prereqs\r\nList of prereqs\r\nList of prereqs\r\nList of prereqs\r\n";
            // 
            // infoTitle
            // 
            infoTitle.BackColor = SystemColors.ControlDark;
            infoTitle.BorderStyle = BorderStyle.Fixed3D;
            infoTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            infoTitle.ForeColor = Color.White;
            infoTitle.Location = new Point(558, 310);
            infoTitle.Name = "infoTitle";
            infoTitle.Size = new Size(363, 37);
            infoTitle.TabIndex = 7;
            infoTitle.Text = "Additional info:";
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(558, 349);
            label4.Name = "label4";
            label4.Size = new Size(363, 126);
            label4.TabIndex = 6;
            label4.Text = "N/A\r\n";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1006, 543);
            Controls.Add(infoTitle);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(prereqsLabel);
            Controls.Add(descriptionTitle);
            Controls.Add(descriptionLabel);
            Controls.Add(courseTitleLabel);
            Controls.Add(courseDetailsLabel);
            Name = "Form2";
            Text = "Form2";
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