namespace Auto_Advisor
{
    partial class CourseConflict
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 134);
            button1.Name = "button1";
            button1.Size = new Size(146, 54);
            button1.TabIndex = 0;
            button1.Text = "Replace existing courses";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(164, 134);
            button2.Name = "button2";
            button2.Size = new Size(132, 54);
            button2.TabIndex = 1;
            button2.Text = "Add to existing courses";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(302, 134);
            button3.Name = "button3";
            button3.Size = new Size(141, 54);
            button3.TabIndex = 2;
            button3.Text = "Continue without new courses";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(449, 148);
            button4.Name = "button4";
            button4.Size = new Size(107, 26);
            button4.TabIndex = 3;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.warning_sign_icon_transparent_background_free_png_ezgif_com_webp_to_png_converter;
            pictureBox1.Location = new Point(26, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 21);
            label1.Name = "label1";
            label1.Size = new Size(322, 80);
            label1.TabIndex = 5;
            label1.Text = "You have previously entered courses.\r\nWould you like to replace your existing courses,\r\nadd them to your new ones, or use only your\r\nexisting courses?";
            // 
            // CourseConflict
            // 
            AcceptButton = button4;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 200);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CourseConflict";
            Text = "Warning: course conflict";
            FormClosed += CourseConflict_FormClosed;
            Load += CourseConflict_Load;
            Shown += CourseConflict_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label label1;
    }
}