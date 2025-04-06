using System.Text.Json;

namespace Auto_Advisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainScreenPanel.Visible = false;
        }

        // Loads a JSON file with course info into the display grid
        private void LoadCoursesIntoGrid(string filePath, DataGridView grid)
        {
            string json = File.ReadAllText(filePath); // Read the file to a string
            var courses = JsonSerializer.Deserialize<List<DegreeCourse>>(json);
            grid.Rows.Clear();

            foreach (var course in courses)
            {
                // Store each course in a grid row
                int rowIndex = grid.Rows.Add();
                var row = grid.Rows[rowIndex];
                row.Cells[0].Value = course.code;
                row.Cells[1].Value = course.name;
                row.Cells[2].Value = course.hours;
            }
        }

        private void moreButtonCell(object sender, EventArgs e)
        {

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

        // Adding a second major
        private void button6_Click(object sender, EventArgs e)
        {
            MajorList2.Visible = true;
        }

        // Adding a second minor
        private void button6_Click_1(object sender, EventArgs e)
        {
            MinorBox2.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        // This is the continue button
        private void button5_Click(object sender, EventArgs e)
        {
            // First, check that all boxes are populated
            if (MajorList.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Fields missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Populate majors display
            majorDisplay.Items.Clear();
            majorDisplay.Items.Add(MajorList.SelectedItem);
            if (MajorList2.SelectedItem != null)
            {
                majorDisplay.Items.Add(MajorList2.SelectedItem);
            }
            // Populate minors display
            minorDisplay.Items.Clear();
            if (MinorBox.SelectedItem != null && MinorBox.SelectedItem.ToString() != "None")
            {
                minorDisplay.Items.Add(MinorBox.SelectedItem);
            }
            if (MinorBox2.SelectedItem != null)
            {
                majorDisplay.Items.Add(MinorBox2.SelectedItem);
            }
            // Populate other sidebar data
            listBox4.Items.Clear();
            listBox4.Items.Add(comboBox4.SelectedItem); // Load current semester
            
            // Populate Computer Science courses from JSON files (other majors will be added later)
            LoadCoursesIntoGrid("major_classes.json", dataGridMajors);
            LoadCoursesIntoGrid("Cognate.json", dataGridCognate);
            LoadCoursesIntoGrid("General_Education.json", dataGridGenEd);
            LoadCoursesIntoGrid("Theology_Courses.json", dataGridTheology);

            // Only make main screen visible once everything has been loaded
            mainScreenPanel.Visible = true;
        }

        // Back to first screen
        private void button1_Click(object sender, EventArgs e)
        {
            mainScreenPanel.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // Class with properties for each course in the specified degree's catalog
    public class DegreeCourse
    {
        public string code { get; set; }
        public string name { get; set; }
        public List<string> prerequisites { get; set; }
        public int hours { get; set; }
        public string description { get; set; }
    }
}