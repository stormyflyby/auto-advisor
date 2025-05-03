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
    public partial class CourseConflict : Form
    {
        private bool set;

        public CourseConflict()
        {
            InitializeComponent();
        }

        private void CourseConflict_Load(object sender, EventArgs e)
        {
            set = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            set = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            set = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            set = true;
        }

        private void CourseConflict_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!set)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CourseConflict_Shown(object sender, EventArgs e)
        {
            button4.Focus();
        }
    }
}
