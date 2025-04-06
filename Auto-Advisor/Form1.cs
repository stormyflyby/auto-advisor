using System.Linq;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

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
        private void LoadCoursesIntoGrid(string filePath)
        {
            string json = File.ReadAllText(filePath); // Read the file
            var courses = JsonSerializer.Deserialize<List<DegreeCourse>>(json);
            dataGridView1.Rows.Clear();

            foreach (var course in courses)
            {
                // Store each course in a grid row
                int rowIndex = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowIndex];
                row.Cells["ClassCode"].Value = course.code;
                row.Cells["ClassName"].Value = course.name;
                row.Cells["Hours"].Value = course.hours;
                row.Cells["Details"].Value = course.description;


                // Setup 'Prerequisites' cell with a dropdown
                //var comboCell = new DataGridViewComboBoxCell();
                //comboCell.Items.Add(""); // Blank entry as the default
                //comboCell.Items.AddRange(course.prerequisites.Any() ? course.prerequisites.ToArray() : new[] { "None" }); // If course has prereqs, add them. Otherwise just show "None"
                //comboCell.Value = "";
                //row.Cells["Prerequisites"] = comboCell; // Assign comboCell to the prereqs column
            }
        }

        private void moreButtonCell(object sender, EventArgs e)
        {

        }

        private void LoadElectivesIntoGrid(string filePath)
        {
            string json = File.ReadAllText(filePath); // Read the file
            var courses = JsonSerializer.Deserialize<List<DegreeCourse>>(json);
            dataGridView2.Rows.Clear();

            foreach (var course in courses)
            {
                // Store each course in a grid row
                int rowIndexs = dataGridView2.Rows.Add();
                var rows = dataGridView2.Rows[rowIndexs];
                rows.Cells["ClassCode2"].Value = course.code;
                rows.Cells["ClassName2"].Value = course.name;
                rows.Cells["Hours2"].Value = course.hours;

                // Setup 'Prerequisites' cell with a dropdown
                //var comboCell = new DataGridViewComboBoxCell();
                //comboCell.Items.Add(""); // Blank entry as the default
                //comboCell.Items.AddRange(course.prerequisites.Any() ? course.prerequisites.ToArray() : new[] { "None" }); // If course has prereqs, add them. Otherwise just show "None"
                //comboCell.Value = "";
                //row.Cells["Prerequisites"] = comboCell; // Assign comboCell to the prereqs column
            }
        }

        private void LoadGeneralEducationIntoGrid(string filePath)
        {
            string json = File.ReadAllText(filePath); // Read the file
            var courses = JsonSerializer.Deserialize<List<DegreeCourse>>(json);
            dataGridView5.Rows.Clear();

            foreach (var course in courses)
            {
                // Store each course in a grid row
                int rowIndexs = dataGridView5.Rows.Add();
                var rows = dataGridView5.Rows[rowIndexs];
                rows.Cells["ClassCode3"].Value = course.code;
                rows.Cells["ClassName3"].Value = course.name;
                rows.Cells["Hours3"].Value = course.hours;

                // Setup 'Prerequisites' cell with a dropdown
                //var comboCell = new DataGridViewComboBoxCell();
                //comboCell.Items.Add(""); // Blank entry as the default
                //comboCell.Items.AddRange(course.prerequisites.Any() ? course.prerequisites.ToArray() : new[] { "None" }); // If course has prereqs, add them. Otherwise just show "None"
                //comboCell.Value = "";
                //row.Cells["Prerequisites"] = comboCell; // Assign comboCell to the prereqs column
            }
        }

        private void LoadTheologyIntoGrid(string filePath)
        {
            string json = File.ReadAllText(filePath); // Read the file
            var courses = JsonSerializer.Deserialize<List<DegreeCourse>>(json);
            dataGridView3.Rows.Clear();

            foreach (var course in courses)
            {
                // Store each course in a grid row
                int rowIndexs = dataGridView3.Rows.Add();
                var rows = dataGridView3.Rows[rowIndexs];
                rows.Cells["ClassCode4"].Value = course.code;
                rows.Cells["ClassName4"].Value = course.name;
                rows.Cells["Hours4"].Value = course.hours;

                // Setup 'Prerequisites' cell with a dropdown
                //var comboCell = new DataGridViewComboBoxCell();
                //comboCell.Items.Add(""); // Blank entry as the default
                //comboCell.Items.AddRange(course.prerequisites.Any() ? course.prerequisites.ToArray() : new[] { "None" }); // If course has prereqs, add them. Otherwise just show "None"
                //comboCell.Value = "";
                //row.Cells["Prerequisites"] = comboCell; // Assign comboCell to the prereqs column
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            MajorList2.Visible = true;
        }

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
            // Populate Computer Science major courses from JSON file (other majors will be added later)
            LoadCoursesIntoGrid("major_classes.json");
            mainScreenPanel.Visible = true;

            LoadElectivesIntoGrid("Cognate.json");
            mainScreenPanel.Visible = true;

            LoadGeneralEducationIntoGrid("General_Education.json");
            mainScreenPanel.Visible = true;

            LoadTheologyIntoGrid("Theology_Courses.json");
            mainScreenPanel.Visible = true;
        }

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

        // Download button - places a json file containing course data in the user's Downloads folder
        private void button3_Click(object sender, EventArgs e)
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

        private void CourseListTestButton_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            string testtxt0 = new string(txt.Where(c => c != '\r').ToArray());
            string testtxt1 = new string(testtxt0.Select(c => c == '\n' ? '.' : c).ToArray());
            MessageBox.Show(testtxt1);
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