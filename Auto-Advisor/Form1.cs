
using Newtonsoft.Json;

namespace Auto_Advisor
{
    public partial class Form1 : Form
    {
        string majorPath = "";
        string minorPath = "";
        string removedMajor = null;
        string removedMinor = null;
        int TotalHours = 0;
        int TotalHoursStillNeeded = 0;
        int TotalHoursNeeded = 0;
        bool suppressMajorDisplayEvent = false;
        public Form1()
        {
            InitializeComponent();
            mainScreenPanel.Visible = false;
        }

        public class User
        {
            public string semester { get; set; }
            public string code { get; set; }
            public string name { get; set; }
            public int hours { get; set; }
        }

        // Loads a JSON file with course info into the display grid
        private void LoadCoursesIntoGrid(string filePath, DataGridView grid)
        {
            string json = File.ReadAllText(filePath); // Read the file to a string
            var courses = JsonConvert.DeserializeObject<List<DegreeCourse>>(json);

            if (courses == null)
            {
                courses = new List<DegreeCourse>();
            }
            grid.Rows.Clear();

            foreach (var course in courses)
            {
                // Store each course in a grid row
                int rowIndex = grid.Rows.Add();
                var row = grid.Rows[rowIndex];
                row.Cells[0].Value = course.code;
                row.Cells[1].Value = course.name;
                row.Cells[2].Value = course.hours;

                // Update the total hours for the given major
                TotalHoursNeeded += course.hours;

                // Determine color of row
                if (courseInTextBox(course.code, textBox1)) // Course already taken
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                    TotalHours += course.hours;
                }
                else if (courseInTextBox(course.code, textBox2)) // Course currently being taken
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                }
                else
                {
                    row.DefaultCellStyle.SelectionBackColor = grid.DefaultCellStyle.BackColor;
                }
            }
            grid.DefaultCellStyle.SelectionForeColor = grid.DefaultCellStyle.ForeColor;
        }

        private void recommendedCourses(string filePath, DataGridView grid)
        {
            string json = File.ReadAllText(filePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            grid.Rows.Clear();
            foreach (var course in users)
            {
                string sem = comboBox4.SelectedItem.ToString();
                DataGridViewRow row = null;
                if (course.semester == sem)
                {
                    int rowIndex = grid.Rows.Add();
                    row = grid.Rows[rowIndex];
                    row.Cells[0].Value = course.code;          // Course Code
                    row.Cells[1].Value = course.name;          // Course Name
                    row.Cells[2].Value = course.hours;         // Hours
                }

                // Determine color of row
                if (row != null)
                {
                    if (courseInTextBox(course.code, textBox1)) // Course already taken
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

                    }
                    else if (courseInTextBox(course.code, textBox2)) // Course currently being taken
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.SelectionBackColor = grid.DefaultCellStyle.BackColor;
                    }
                }

            }
            grid.DefaultCellStyle.SelectionForeColor = grid.DefaultCellStyle.ForeColor;
        }

        private bool courseInTextBox(string code, TextBox textbox)
        {
            // Split textbox content by line
            string[] lines = textbox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            // Check if code exists on any line
            foreach (var line in lines)
            {
                if (line.Trim() == code)
                {
                    return true; // Code was found
                }
            }
            return false; // Code not found
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

        // Adding/removing a second major
        private void button6_Click(object sender, EventArgs e)
        {
            if (MajorList2.Visible == false) // make visible
            {
                MajorList2.Visible = true;
                MajorButton.Text = "Remove";
            }
            else // make invisible
            {
                MajorList2.Visible = false;
                MajorButton.Text = "Add Major";
                MajorList2.SelectedItem = null;
            }
        }

        // Adding a second minor
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (MinorBox2.Visible == false) // make visible
            {
                MinorBox2.Visible = true;
                button6.Text = "Remove";
            }
            else // make invisible
            {
                MinorBox2.Visible = false;
                button6.Text = "Add Minor";
                MinorBox2.SelectedItem = null;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        // This is the continue button
        private void button5_Click(object sender, EventArgs e)
        {
            suppressMajorDisplayEvent = true;
            continueFunction();
            suppressMajorDisplayEvent = false;
        }

        public void continueFunction()
        {
            // First, check that all boxes are populated
            if (!CheckCourseInfo())
            {
                FieldsMissingError();
                return;
            }

            // Reset calculated hours values
            TotalHours = 0;
            TotalHoursStillNeeded = 0;
            TotalHoursNeeded = 0;

            // Establish file path for selected major
            string majorsRootPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Majors");
            string selectedMajor = MajorList.SelectedItem.ToString();
            majorPath = Path.Combine(majorsRootPath, selectedMajor);
            if (MinorBox.SelectedItem != null && MinorBox.SelectedItem.ToString() != "None")
            {
                string minorsRootPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Minors");
                string selectedMinor = MinorBox.SelectedItem.ToString();
                minorPath = Path.Combine(minorsRootPath, selectedMinor);
            }

            // Populate majors sidebar display
            majorDisplay1.Items.Clear();
            majorDisplay1.Items.Add(MajorList.SelectedItem);
            if (MajorList2.SelectedItem != null)
            {
                majorDisplay1.Items.Add(MajorList2.SelectedItem);
            }
            majorDisplay1.SelectedItem = MajorList.SelectedItem; // recursion error
            // Populate minors sidebar display
            minorDisplay1.Items.Clear();
            if (MinorBox.SelectedItem != null && MinorBox.SelectedItem.ToString() != "None")
            {
                minorDisplay1.Items.Add(MinorBox.SelectedItem);
            }
            if (MinorBox2.SelectedItem != null)
            {
                minorDisplay1.Items.Add(MinorBox2.SelectedItem);
            }
            minorDisplay1.SelectedItem = MinorBox.SelectedItem;

            // Populate all courses from JSON files
            LoadCoursesIntoGrid(Path.Combine(majorPath, "major_classes.json"), dataGridMajors);
            LoadCoursesIntoGrid(Path.Combine(majorPath, "Cognate.json"), dataGridCognate);
            LoadCoursesIntoGrid(Path.Combine(majorPath, "General_Education.json"), dataGridGenEd);
            LoadCoursesIntoGrid(Path.Combine(majorPath, "Theology_Courses.json"), dataGridTheology);
            recommendedCourses(Path.Combine(majorPath, "recommended.json"), dataGridRecommended);

            // Populate other sidebar data
            listBox4.Items.Clear();
            listBox4.Items.Add(comboBox4.SelectedItem); // Load current semester
            listBox6.Items.Clear();
            listBox6.Items.Add(TotalHours); // Load total hours taken
            TotalHoursStillNeeded = TotalHoursNeeded - TotalHours;
            listBox5.Items.Clear();
            listBox5.Items.Add(TotalHoursStillNeeded); // Load hours still needed
            listBox2.Items.Clear();
            listBox2.Items.Add(TotalHoursNeeded); // Load total hours for major

            // Load minor info if it exists, else delete it
            if (MinorBox.SelectedItem != null && MinorBox.SelectedItem.ToString() != "None")
            {
                LoadCoursesIntoGrid(Path.Combine(minorPath, "minor_classes.json"), dataGridMinors);
                dataGridMinors.Visible = true;
                textBox5.Visible = true;
            }
            else
            {
                dataGridMinors.Visible = false;
                textBox5.Visible = false;
            }

            // Only make main screen visible once everything has been loaded
            mainScreenPanel.Visible = true;
        }

        // Back to first screen
        private void button1_Click(object sender, EventArgs e)
        {
            mainScreenPanel.Visible = false;
            TotalHours = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Displays details view for major classes
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridMajors, e.RowIndex, Path.Combine(majorPath, "major_classes.json"));
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

                    if (cis.Major1 != string.Empty) MajorList2.Visible = true;
                    if (cis.Minor1 != string.Empty) MinorBox2.Visible = true;
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
                displayCourseDetails(dataGridRecommended, e.RowIndex, Path.Combine(majorPath, "recommended.json"));
            }
        }

        private void dataGridCognate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridCognate, e.RowIndex, Path.Combine(majorPath, "Cognate.json"));
            }
        }

        private void dataGridGenEd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridGenEd, e.RowIndex, Path.Combine(majorPath, "General_Education.json"));
            }
        }

        private void dataGridTheology_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridTheology, e.RowIndex, Path.Combine(majorPath, "Theology_Courses.json"));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridMinors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridMinors, e.RowIndex, Path.Combine(minorPath, "minor_classes.json"));
            }
        }

        // This method makes major selections non-duplicable
        private void MajorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = MajorList.SelectedItem;

            if (removedMajor != null && !MajorList2.Items.Contains(removedMajor))
            {
                MajorList2.Items.Add(removedMajor);
            }

            if (MajorList2.Items.Contains(item))
            {
                MajorList2.Items.Remove(item);
                removedMajor = item.ToString();
            }
        }

        // This method makes minor selections non-duplicable
        private void MinorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = MinorBox.SelectedItem;

            if (removedMinor != null && !MinorBox2.Items.Contains(removedMinor))
            {
                MinorBox2.Items.Add(removedMinor);
            }

            if (MinorBox2.Items.Contains(item))
            {
                MinorBox2.Items.Remove(item);
                removedMinor = item.ToString();
            }
        }

        private void majorDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void majorDisplay1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(suppressMajorDisplayEvent) return;
            suppressMajorDisplayEvent = true;

            var temp = MajorList.SelectedItem;
            MajorList.SelectedItem = MajorList2.SelectedItem;
            MajorList2.SelectedItem = temp;
            continueFunction();

            suppressMajorDisplayEvent = false;
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