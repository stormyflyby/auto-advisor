namespace Auto_Advisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private int textBoxs1 = 6; // Tracks the number of textboxes
        private const int Rows = 6; // Fixed number of columns

        private void button1_Click(object sender, EventArgs e)
        {
            int row = textBoxs1 % Rows; // Calculates the number of rows
            int col = textBoxs1 / Rows; // Calculates the number of columns

            // If we exceed current coloums, add a new row
            if (col >= tableLayoutPanel1.ColumnCount)
            {
                tableLayoutPanel1.ColumnCount++;
            }

            TextBox newTextBox1 = new TextBox();
            newTextBox1.Width = 121; // Adjust width as needed

            tableLayoutPanel1.Controls.Add(newTextBox1, col, row);
            textBoxs1++; // Increment count
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int textBoxs2 = 6; // Tracks the number of textboxes
        private const int Rows2 = 6; // Fixed number of rows
        private void button2_Click(object sender, EventArgs e)
        {
            int row = textBoxs2 % Rows2; // Calculates the number of rows
            int col = textBoxs2 / Rows2; // Calculates the number of columns

            // If we exceed current coloums, add a new row
            if (col >= tableLayoutPanel2.ColumnCount)
            {
                tableLayoutPanel2.ColumnCount++;
            }

            TextBox newTextBox2 = new TextBox();
            newTextBox2.Width = 121; // Adjust width as needed

            tableLayoutPanel2.Controls.Add(newTextBox2, col, row);
            textBoxs2++; // Increment count
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MajorList2.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MinorBox2.Visible = true;
        }
    }
}