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
    public partial class Form2 : Form
    {
        public Form2(string code, string name, List<String> prerequisites, int hours, string description)
        {
            InitializeComponent();
            courseTitleLabel.Text = code + " - " + name;
            courseTitleLabel.Left = (this.ClientSize.Width - courseTitleLabel.Width) / 2;
            descriptionLabel.Text = description;
            prereqsLabel.Text = "";
            foreach(string prerequisite in prerequisites)
            {
                prereqsLabel.Text += prerequisite + "\n";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
