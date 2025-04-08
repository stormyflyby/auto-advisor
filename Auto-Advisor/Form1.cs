using Microsoft.VisualBasic.ApplicationServices;
using System.Linq;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;

namespace Auto_Advisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainScreenPanel.Visible = false;
        }

        public class User
        {
            public string semester { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public int Hours { get; set; }
        }

        // Loads a JSON file with course info into the display grid
        private void LoadCoursesIntoGrid(string filePath, DataGridView grid)
        {
            string json = File.ReadAllText(filePath); // Read the file to a string
            var courses = JsonConvert.DeserializeObject<List<DegreeCourse>>(json);
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

        private void recommendedCourses(string filePath, DataGridView grid)
        {
            string json = File.ReadAllText(filePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            grid.Rows.Clear();
            foreach (var rec in users)
            {
                string dog = comboBox4.SelectedItem.ToString();
                if (rec.semester == dog)
                {
                    int rowIndex = grid.Rows.Add();
                    var row = grid.Rows[rowIndex];
                    row.Cells[0].Value = rec.Code;          // Course Code
                    row.Cells[1].Value = rec.Name;          // Course Name
                    row.Cells[2].Value = rec.Hours;         // Hours
                }
            }
        }

        private void moreButtonCell(object sender, EventArgs e)
        {

        }

        // Check that required course info is filled on first screen
        private bool CheckCourseInfo()
        {
            if (MajorList.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        private void FieldsMissingError()
        {
            MessageBox.Show("Fields missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
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
            if (!CheckCourseInfo())
            {
                FieldsMissingError();
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
            recommendedCourses("recommended.json", dataGridRecommended);

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

        // This currently only applies to the majors datagridview buttons, will be generalized later
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridMajors, e.RowIndex, "major_classes.json");
            }
        }

        private void displayCourseDetails(DataGridView grid, int rowIndex, string filePath)
        {
            string? className = grid.Rows[rowIndex].Cells[1].Value.ToString(); // Determine which course the user clicked
            string json = File.ReadAllText(filePath);
            var courses = JsonConvert.DeserializeObject<List<DegreeCourse>>(json);
            foreach (var course in courses)
            {
                if (course.name == className)
                {
                    // Pass course details to form2 for display (course.code may be null)
                    Form2 form2 = new Form2(course.code, course.name, course.prerequisites, course.hours, course.description);
                    form2.Show();
                    break;
                }
            }
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Download();
        }

        // Download button - places a json file containing course data in the user's Downloads folder
        private void Download()
        {
            if (!CheckCourseInfo())
            {
                FieldsMissingError();
                return;
            }

            CourseInfoMediator.Instance.Major0 = MajorList.Text;
            CourseInfoMediator.Instance.Major1 = MajorList2.Text;
            CourseInfoMediator.Instance.Minor0 = MinorBox.Text;
            CourseInfoMediator.Instance.Minor1 = MinorBox2.Text;
            CourseInfoMediator.Instance.Honors = comboBox3.SelectedItem == comboBox3.Items[1] ? true : false;
            CourseInfoMediator.Instance.SemesterNumber = short.Parse(comboBox4.SelectedItem.ToString());

            string tb1Txt = textBox1.Text;
            string compCourseStr = new string(tb1Txt.Where(c => c != '\r').ToArray());
            string[] compCourses = compCourseStr.Split('\n');

            CourseInfoMediator.Instance.ClearCompletedCourses();
            foreach (string s in compCourses)
            {
                CourseInfoMediator.Instance.AddCompletedCourse(s);
            }

            string tb2Txt = textBox2.Text;
            string inPrCourseStr = new string(tb2Txt.Where(c => c != '\r').ToArray());
            string[] inPrCourses = inPrCourseStr.Split('\n').Where(s => s.Length != 0).ToArray();

            CourseInfoMediator.Instance.ClearInProgressCourses();
            foreach (string s in inPrCourses)
            {
                CourseInfoMediator.Instance.AddInProgressCourse(s);
            }

            // Download save
            CourseInfoMediator.Instance.SendToDownloads();

            // Notify user of download
            MessageBox.Show("A save file has been sent to your downloads folder.");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // Save button; display an open file dialog and populate input boxes if the file is save data
        private void button4_Click(object sender, EventArgs e)
        {
            if (openSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jstring = File.ReadAllText(openSaveFileDialog.FileName);
                    CourseInfoStructure? cis = JsonConvert.DeserializeObject<CourseInfoStructure>(jstring);
                    MajorList.Text = cis.Major0;
                    MajorList2.Text = cis.Major1;
                    MinorBox.Text = cis.Minor0;
                    MinorBox2.Text = cis.Minor1;
                    comboBox3.SelectedItem = cis.Honors ? comboBox3.Items[1] : comboBox3.Items[0];
                    comboBox4.SelectedItem = comboBox4.Items[cis.SemesterNumber - 1];

                    textBox1.Clear();
                    foreach (string s in cis.CompletedCourses)
                    {
                        textBox1.Text += $"{s} \r\n";
                    }

                    textBox2.Clear();
                    foreach (string s in cis.InProgressCourses)
                    {
                        textBox2.Text += $"{s} \r\n";
                    }
                }
                catch
                {
                    MessageBox.Show("Error: Selected file is not save data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void openSaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridRecommended_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridRecommended, e.RowIndex, "recommended.json");
            }
        }

        private void dataGridCognate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridCognate, e.RowIndex, "Cognate.json");
            }
        }

        private void dataGridGenEd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridGenEd, e.RowIndex, "General_Education.json");
            }
        }

        private void dataGridTheology_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridTheology, e.RowIndex, "Theology_Courses.json");
            }
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