using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Advisor
{
    public partial class CourseDescription : Form
    {
        public CourseDescription(string code, string name, List<String> prerequisites, int hours, string description)
        {
            InitializeComponent();
            if (code != null)
            {
                courseTitleLabel.Text = code + " - " + name;
            }
            else
            {
                courseTitleLabel.Text = name;
            }
            courseTitleLabel.Left = (this.ClientSize.Width - courseTitleLabel.Width) / 2;
            descriptionLabel.Text = description;
            prereqsLabel.Text = "";
            if (prerequisites != null)
            {
                foreach (string prerequisite in prerequisites)
                {
                    prereqsLabel.Text += prerequisite + "\n";
                }
            }
            else
            {
                prereqsLabel.Text = "Not applicable.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
