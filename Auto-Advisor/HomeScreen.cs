
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Auto_Advisor
{
    public partial class Form1 : Form
    {
        /* Global variables */
        string majorPath = ""; // File paths for the selected major/minor
        string minorPath = "";
        string removedMajor = null; // Major/minor that can't be displayed in the second dropdown because it was selected in the first
        string removedMinor = null;
        int TotalHours = 0; // Hours the student has taken already
        int TotalHoursStillNeeded = 0; // Remaining hours the student needs to graduate
        int TotalHoursNeeded = 0; // Total hours for the selected major
        int HoursInProgress = 0; // Hours currently being taken
        bool suppressMajorDisplayEvent = false; // Prevents major display update from retriggering itself

        DataGridView[] dgvs;

        public Form1()
        {
            InitializeComponent();
            mainScreenPanel.Visible = false;

            dgvs = new DataGridView[] {
                dataGridRecommended,
                dataGridCognate,
                dataGridGenEd,
                dataGridMajors,
                dataGridMinors,
                dataGridTheology,
                DataGridHonors
            };
        }

        // This class stores properties for each course in the specified degree's catalog
        public class DegreeCourse
        {
            public string code { get; set; }
            public string name { get; set; }
            public List<string> prerequisites { get; set; }
            [JsonConverter(typeof(IntOrArrConverter))]
            public object semester { get; set; }
            private int hrs;
            public int hours
            {
                get
                {
                    return hrs;
                }

                set { hrs = value; }
            }
            public string description { get; set; }

            public int honors { get; set; }
        }

        public void SetDegreeCourseHours(DegreeCourse dc)
        {
            dc.hours = dc.hours;
        }

        public class IntOrArrConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => true;

            public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var token = JToken.Load(reader);
                if (token.Type == JTokenType.Integer)
                    return token.ToObject<int>();
                if (token.Type == JTokenType.Array)
                    return token.ToObject<int[]>();
                return null;
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                JToken t = JToken.FromObject(value);
                t.WriteTo(writer);
            }
        }

        // This class is used to store recommended course info
        public class User
        {
            private int semInt;
            private List<int> semList = new List<int>();
            [JsonConverter(typeof(IntOrArrConverter))]
            public object semester { get; set; }
            public string code { get; set; }
            public string name { get; set; }
            public int hours { get; set; }
        }

        /**
         * Loads a json file with course info into the display grid
         * @param filePath the location of the json file to be loaded
         * @param grid the grid where data is being sent
         */
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
                //Filters out the classes that are replaced with the honor classes
                if (course.honors == 1 && comboBox3.Text == "Yes")
                {
                    continue; // The student is in honors, but this class is replaced by an honors version
                }
                else if (course.honors == 2 && comboBox3.Text == "No")
                {
                    continue; // This is an honors class, but the student is not in honors
                }

                int end = 1;
                bool isArr = false;
                if (course.semester is int[])
                {
                    end = ((int[])course.semester).Length;
                    isArr = true;
                }

                for (int i = 0; i < end; i++)
                {
                    int rowIndex = grid.Rows.Add();
                    var row = grid.Rows[rowIndex];
                    row.Cells[0].Value = course.code + (isArr ? i.ToString() : "");          // Course Code
                    row.Cells[1].Value = course.name;          // Course Name
                    row.Cells[2].Value = course.hours;         // Hours


                    // Update the total hours for the given major
                    if (grid != dataGridMinors)
                        TotalHoursNeeded += course.hours;

                    // Determine color of the row
                    if (courseInTextBox(course.code, textBox1)) // Course already taken
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                        TotalHours += course.hours; // Update hours already taken
                    }
                    else if (courseInTextBox(course.code, textBox2)) // Course currently being taken
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                        HoursInProgress += course.hours; // Update hours in progress
                    }
                    else // Course not taken yet
                    {
                        row.DefaultCellStyle.SelectionBackColor = grid.DefaultCellStyle.BackColor;
                    }
                }
            }
            grid.DefaultCellStyle.SelectionForeColor = grid.DefaultCellStyle.ForeColor;
        }

        /**
         * Loads recommended course up to and including the current semester
         * from the json file into the display grid. Hours are not recalculated.
         * @param filePath the location of the json file to be loaded
         * @param grid the grid where data is being sent
         */
        private void recommendedCourses(string filePath, DataGridView grid)
        {
            string fullPath = Path.GetFullPath(filePath);
            DirectoryInfo di = new DirectoryInfo(fullPath);

            grid.Rows.Clear();

            foreach (FileInfo fi in di.GetFiles())
            {



                string json = File.ReadAllText(Path.Combine(filePath, fi.Name)); // Read the file to a string
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

                foreach (var course in users)
                {
                    int sem = int.Parse(comboBox4.SelectedItem.ToString());
                    DataGridViewRow row = null;
                    bool inTxtBx1 = courseInTextBox(course.code, textBox1);
                    bool inTxtBx2 = courseInTextBox(course.code, textBox2);
                    // Doesn't load courses beyond current semester or courses already/currently taken


                    if (course.semester.GetType().BaseType != typeof(Array))
                    {
                        if ((int)course.semester <= sem)
                        {
                            int rowIndex = grid.Rows.Add();
                            row = grid.Rows[rowIndex];
                            row.Cells[0].Value = course.code;          // Course Code.User.semester.get returned null.
                            row.Cells[1].Value = course.name;          // Course Name
                            row.Cells[2].Value = course.hours;         // Hours

                            if (inTxtBx1 || inTxtBx2) row.Visible = false;
                        }
                    }

                    else
                    {
                        int i = 0;
                        foreach (int semInt in (int[])course.semester)
                        {
                            if (semInt <= sem)
                            {
                                int rowIndex = grid.Rows.Add();
                                row = grid.Rows[rowIndex];
                                row.Cells[0].Value = course.code + i.ToString();          // Course Code
                                row.Cells[1].Value = course.name;          // Course Name
                                row.Cells[2].Value = course.hours;         // Hours

                                if (inTxtBx1 || inTxtBx2) row.Visible = false;
                            }
                            i++;
                        }
                    }

                    // Determine color of row
                    if (row != null)
                    {
                        if (inTxtBx1) // Course already taken
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

                        }
                        else if (inTxtBx2) // Course currently being taken
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                        }
                        else // Course not taken yet
                        {
                            row.DefaultCellStyle.SelectionBackColor = grid.DefaultCellStyle.BackColor;
                        }
                    }

                }
            }
            grid.DefaultCellStyle.SelectionForeColor = grid.DefaultCellStyle.ForeColor;
        }

        /**
         * Checks to see if a given course was entered in a start screen textbox.
         * @param code the class code being checked
         * @param grid the textbox where the code may have been entered
         * @return true if course found
         */
        private bool courseInTextBox(string code, TextBox textbox)
        {
            if (code == null) return false;

            // Split textbox content by line
            string[] lines = textbox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            // Check if code exists on any line
            foreach (var line in lines)
            {
                string lineStr = string.Concat(line.Trim().ToLower().Where(ch => ch != ' '));
                string codeStr = string.Concat(code.ToLower().Where(ch => ch != ' '));
                if (lineStr == codeStr)
                {
                    return true; // Code was found
                }
            }
            return false; // Code not found
        }

        /**
         * Checks to see if required course info is fully filled on start screen
         * @return true if all data entered
         */
        private bool CheckCourseInfo()
        {
            if (MajorList.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        /**
         * Displays an error message indicating start screen info is missing
         */
        private void FieldsMissingError()
        {
            MessageBox.Show("Fields missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
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
            suppressMajorDisplayEvent = true; // Prevents major display update from retriggering itself
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
            HoursInProgress = 0;

            // Populate majors sidebar display
            majorDisplay1.Items.Clear();
            majorDisplay1.Items.Add(MajorList.SelectedItem);
            if (MajorList2.SelectedItem != null)
            {
                majorDisplay1.Items.Add(MajorList2.SelectedItem);
            }
            majorDisplay1.SelectedItem = MajorList.SelectedItem;

            // Populate minors sidebar display
            minorDisplay1.Items.Clear();
            if (MinorBox.SelectedItem != null && MinorBox.SelectedItem.ToString() == "None")
            {
                MinorBox.SelectedItem = MinorBox2.SelectedItem;
                MinorBox2.SelectedItem = null;
            }
            if (MinorBox2.SelectedItem != null && MinorBox2.SelectedItem.ToString() == "None")
            {
                MinorBox2.SelectedItem = null;
            }
            if (MinorBox.SelectedItem != null)
            {
                minorDisplay1.Items.Add(MinorBox.SelectedItem);
            }
            if (MinorBox2.SelectedItem != null)
            {
                minorDisplay1.Items.Add(MinorBox2.SelectedItem);
            }
            minorDisplay1.SelectedItem = MinorBox.SelectedItem;

            // Establish file path for selected major and minor
            string majorsRootPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Majors");
            string selectedMajor = MajorList.SelectedItem.ToString();
            majorPath = Path.Combine(majorsRootPath, selectedMajor);
            if (MinorBox.SelectedItem != null && MinorBox.SelectedItem.ToString() != "None")
            {
                string minorsRootPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Minors");
                string selectedMinor = MinorBox.SelectedItem.ToString();
                minorPath = Path.Combine(minorsRootPath, selectedMinor);
            }

            // Populate all major courses from JSON files
            LoadCoursesIntoGrid(Path.Combine(majorPath, "major_classes.json"), dataGridMajors);
            LoadCoursesIntoGrid(Path.Combine(majorPath, "Cognate.json"), dataGridCognate);
            LoadCoursesIntoGrid(Path.Combine(majorPath, "General_Education.json"), dataGridGenEd);
            LoadCoursesIntoGrid(Path.Combine(majorPath, "Theology_Courses.json"), dataGridTheology);
            recommendedCourses(majorPath, dataGridRecommended);
            LoadCoursesIntoGrid("Honors_classes.json", DataGridHonors);

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
            listBox10.Items.Clear();
            listBox10.Items.Add(HoursInProgress); // Load hours currently being taken

            // Load minor courses if one was selected, else delete display box
            if (MinorBox.SelectedItem != null)
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

        private void RefreshSidebar()
        {
            listBox4.Items.Clear();
            listBox4.Items.Add(comboBox4.SelectedItem); // Load current semester
            listBox6.Items.Clear();
            listBox6.Items.Add(TotalHours); // Load total hours taken
            TotalHoursStillNeeded = TotalHoursNeeded - TotalHours;
            listBox5.Items.Clear();
            listBox5.Items.Add(TotalHoursStillNeeded); // Load hours still needed
            listBox2.Items.Clear();
            listBox2.Items.Add(TotalHoursNeeded); // Load total hours for major
            listBox10.Items.Clear();
            listBox10.Items.Add(HoursInProgress); // Load hours currently being taken
        }

        // Back to first screen
        private void button1_Click(object sender, EventArgs e)
        {
            mainScreenPanel.Visible = false;
            textBox7.Visible = true;
            button5.Visible = true;
            TotalHours = 0;
            searchClear();
            searchTextBox.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Displays details view for major classes
        private void dataGridViewMajors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridMajors, e.RowIndex, Path.Combine(majorPath, "major_classes.json"));
            }
            else
            {
                var code = dataGridMajors.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (code != null)
                {
                    SetCourseStatus(code.ToString(), courseClickComBox.SelectedIndex);
                }
            }
        }

        private void recommendedCourseDetails(DataGridView grid, int rowIndex, string majorPath)
        {
            if (displayCourseDetails(grid, rowIndex, Path.Combine(majorPath, "Cognate.json"))) return;
            else if (displayCourseDetails(grid, rowIndex, Path.Combine(majorPath, "General_Education.json"))) return;
            else if (displayCourseDetails(grid, rowIndex, Path.Combine(majorPath, "major_classes.json"))) return;
            else if (displayCourseDetails(grid, rowIndex, Path.Combine(majorPath, "Theology_Courses.json"))) return;
        }

        private bool displayCourseDetails(DataGridView grid, int rowIndex, string filePath)
        {
            string? className = grid.Rows[rowIndex].Cells[1].Value.ToString(); // Determine which course the user clicked
            string json = File.ReadAllText(filePath);
            var courses = JsonConvert.DeserializeObject<List<DegreeCourse>>(json);
            foreach (var course in courses)
            {
                if (course.name == className)
                {
                    // Pass course details to form2 for display (course.code may be null)
                    CourseDescription form2 = new CourseDescription(course.code, course.name, course.prerequisites, course.hours, course.description);
                    form2.ShowDialog();
                    return true;
                }
            }
            return false;
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
            if (!mainScreenPanel.Visible)
            {
                foreach (string s in compCourses)
                {
                    CourseInfoMediator.Instance.AddCompletedCourse(s);
                }
            }
            // Get courses from second screen
            foreach (DataGridView dgv in dgvs)
            {
                if (dgv != dataGridRecommended)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.DefaultCellStyle.BackColor == Color.LightGreen)
                        {
                            CourseInfoMediator.Instance.AddCompletedCourse(row.Cells[0].Value.ToString());
                        }
                    }
                }
            }

            string tb2Txt = textBox2.Text;
            string inPrCourseStr = new string(tb2Txt.Where(c => c != '\r').ToArray());
            string[] inPrCourses = inPrCourseStr.Split('\n').Where(s => s.Length != 0).ToArray();

            CourseInfoMediator.Instance.ClearInProgressCourses();
            if (mainScreenPanel.Visible)
            {
                foreach (string s in inPrCourses)
                {
                    CourseInfoMediator.Instance.AddInProgressCourse(s);
                }
            }
            // Get courses from second screen
            foreach (DataGridView dgv in dgvs)
            {
                if (dgv != dataGridRecommended)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.DefaultCellStyle.BackColor == Color.Yellow)
                        {
                            CourseInfoMediator.Instance.AddInProgressCourse(row.Cells[0].Value.ToString());
                        }
                    }
                }
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

                    if (cis.Major1 != string.Empty)
                    {
                        MajorList2.Visible = true;
                        MajorButton.Text = "Remove";
                    }
                    else
                    {
                        MajorList2.Visible = false;
                        MajorButton.Text = "Add";
                        MajorList2.SelectedItem = null;
                    }

                    if (cis.Minor1 != string.Empty)
                    {
                        MinorBox2.Visible = true;
                        button6.Text = "Remove";
                    }
                    else
                    {
                        MinorBox2.Visible = false;
                        button6.Text = "Add";
                        MinorBox2.SelectedItem = null;
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

        private void dataGridRecommended_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3)
            {
                recommendedCourseDetails(dataGridRecommended, e.RowIndex, majorPath);
            }
            else
            {
                var code = dataGridRecommended.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (code != null)
                {
                    SetCourseStatus(code.ToString(), courseClickComBox.SelectedIndex);
                }
            }
        }

        private void dataGridCognate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridCognate, e.RowIndex, Path.Combine(majorPath, "Cognate.json"));
            }
            else
            {
                var code = dataGridCognate.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (code != null)
                {
                    SetCourseStatus(code.ToString(), courseClickComBox.SelectedIndex);
                }
            }
        }

        private void dataGridGenEd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridGenEd, e.RowIndex, Path.Combine(majorPath, "General_Education.json"));
            }
            else
            {
                var code = dataGridGenEd.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (code != null)
                {
                    SetCourseStatus(code.ToString(), courseClickComBox.SelectedIndex);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            courseClickComBox.SelectedIndex = 0;
        }

        private DataGridViewRow hasCode(string code, DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var str = row.Cells[0].Value;
                if (str != null)
                {
                    if (str.ToString().Equals(code))
                    {
                        return row;
                    }
                }
            }
            return null;
        }

        private void SetCourseStatus(string code, int status)
        {
            if (status == 0)
            {
                bool hoursSet = false;
                foreach (DataGridView dgv in dgvs)
                {
                    DataGridViewRow row = hasCode(code, dgv);
                    if (row != null)
                    {
                        if (row.Cells[0].Value.ToString().Equals(code))
                        {
                            if (!hoursSet && row.DefaultCellStyle.BackColor == Color.Empty)
                            {
                                hoursSet = true;
                                TotalHours += (int)row.Cells[2].Value;
                                RefreshSidebar();
                            }
                            if (!hoursSet && row.DefaultCellStyle.BackColor == Color.Yellow)
                            {
                                hoursSet = true;
                                HoursInProgress -= (int)row.Cells[2].Value;
                                TotalHours += (int)row.Cells[2].Value;
                                RefreshSidebar();
                            }
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                            if (dgv == dataGridRecommended)
                            {
                                row.Visible = false;
                            }
                        }
                    }
                }
            }

            else if (status == 1)
            {
                bool hoursSet = false;
                foreach (DataGridView dgv in dgvs)
                {
                    DataGridViewRow row = hasCode(code, dgv);
                    if (row != null)
                    {
                        if (row.Cells[0].Value.ToString().Equals(code))
                        {
                            if (!hoursSet && row.DefaultCellStyle.BackColor == Color.LightGreen)
                            {
                                hoursSet = true;
                                TotalHours -= (int)row.Cells[2].Value;
                                HoursInProgress += (int)row.Cells[2].Value;
                                RefreshSidebar();
                            }
                            if (!hoursSet && row.DefaultCellStyle.BackColor == Color.Empty)
                            {
                                hoursSet = true;
                                HoursInProgress += (int)row.Cells[2].Value;
                                RefreshSidebar();
                            }
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                            if (dgv == dataGridRecommended)
                            {
                                row.Visible = false;
                            }
                        }
                    }
                }
            }

            else if (status == 2)
            {
                bool hoursSet = false;
                foreach (DataGridView dgv in dgvs)
                {
                    DataGridViewRow row = hasCode(code, dgv);
                    if (row != null)
                    {
                        if (row.Cells[0].Value.ToString().Equals(code))
                        {
                            if (!hoursSet && row.DefaultCellStyle.BackColor == Color.LightGreen)
                            {
                                hoursSet = true;
                                TotalHours -= (int)row.Cells[2].Value;
                                RefreshSidebar();
                            }
                            if (!hoursSet && row.DefaultCellStyle.BackColor == Color.Yellow)
                            {
                                hoursSet = true;
                                HoursInProgress -= (int)row.Cells[2].Value;
                                RefreshSidebar();
                            }
                            row.DefaultCellStyle.BackColor = Color.Empty;
                            row.DefaultCellStyle.SelectionBackColor = Color.Empty;
                            if (dgv == dataGridRecommended)
                            {
                                row.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void dataGridTheology_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridTheology, e.RowIndex, Path.Combine(majorPath, "Theology_Courses.json"));
            }
            else
            {
                var code = dataGridTheology.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (code != null)
                {
                    SetCourseStatus(code.ToString(), courseClickComBox.SelectedIndex);
                }
            }
        }

        private void dataGridMinors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridMinors, e.RowIndex, Path.Combine(minorPath, "minor_classes.json"));
            }
            else
            {
                var code = dataGridMinors.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (code != null)
                {
                    SetCourseStatus(code.ToString(), courseClickComBox.SelectedIndex);
                }
            }
        }
        private void DataGridHonors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(DataGridHonors, e.RowIndex, Path.Combine("Honors_classes.json"));
            }
            else
            {
                var code = DataGridHonors.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (code != null)
                {
                    SetCourseStatus(code.ToString(), courseClickComBox.SelectedIndex);
                }
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
        // Switch which major is displayed from the main page
        private void majorDisplay1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressMajorDisplayEvent) return; // When set to true, display is being changed by the continue button and should not cause this method to execute
            if (MajorList2.SelectedItem == null) return; // no second major was selected
            suppressMajorDisplayEvent = true;

            var temp = MajorList.SelectedItem;
            MajorList.SelectedItem = MajorList2.SelectedItem;
            MajorList2.SelectedItem = temp;
            continueFunction();
            searchClear();

            suppressMajorDisplayEvent = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minorDisplay1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressMajorDisplayEvent) return; // When set to true, display is being changed by the continue button and should not cause this method to execute
            if (MinorBox2.SelectedItem == null) return; // no second minor was selected
            suppressMajorDisplayEvent = true;

            var temp = MinorBox.SelectedItem;
            MinorBox.SelectedItem = MinorBox2.SelectedItem;
            MinorBox2.SelectedItem = temp;
            continueFunction();
            searchClear();

            suppressMajorDisplayEvent = false;
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(
                "The AutoAdvisor displays the classes you need to take for your Major(s) and Minor(s).\n\n" +
                "Major(s)/Minor(s) -\nSelect a Major/Minor from the dropdown menu. If you have two Majors or Minors, hit the Add Major/Minor button and select your second Major/Minor from the dropdown menu.\n\n" +
                "Honors - \nIf you are an Honors student, hit 'yes'. Otherwise, hit 'no'. \n\n" +
                "Upcoming Semester - \nEnter the number of your next semester. If you are currently in semester 4 (second sophomore year), your upcoming semester will be semester 5 (first junior semester).\n\n" +
                "Completed or Currently Taking courses - \nEnter each of your course's codes. Only enter one course code per line.\n\n" +
                "Download Data - \nClick the Download Data button to save your input to a file. When you use AutoAdvisor again, you can reenter your info with the file.\n\n" +
                "Enter Saved Data - \nIf you have a saved data file, enter it from the files on your device. The software will rebuild your input from this file.\n" +
                "\nWhat does 'Add them on the next page' mean? \nWhen you hit continue it will show you your classes and you can select the option on the left side of the screen to mark them as complete, in progress or not taking.");
        }

        private void mainScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("The tables on this screen show you classes you need to take for various class categories.\n\n" +
                "                                        Some Helpful Questions - \n\n" +
                "What are Recommended Classes?\nRecommended Classes are high-priority. Classes in this table are suited for the upcoming semester or previous semesters and have not been taken.\n\n" +
                "What do the different colors mean?\nGreen indicates taken classes. Yellow indicates in-progress classes. White indicates untaken classes.\n\n" +
                "How do I mark my classes? \nThe dropdown menu that says On course click is where you can change what happens when you click each course. You can change between completed(green & the default), in progress(yellow) and have not taken(white) \n\n" +
                "How do I find course descriptions or prerequisites? \nClick a class's More button to display additional information.   \n\n" +
                "How do I switch between Majors/Minors? \nClick the drop down menu and select your desired Major/Minor.\n\n" +
                "What do the different hour totals mean? \n" +
                "Hours completed: The total hours of classes you have already taken.\n\n" +
                "Hours in progress: The total hours of classes you are currently taking.\n\n" +
                "Total hours needed: The total hours needed for your major (not including minor hours).\n\n" +
                "Hours still needed: The difference between your completed hours and your total needed hours.");
        }


        //The Honors combobox that shows the honors box
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "No")
            {
                DataGridHonors.Visible = false;
                HonorsBox.Visible = false;

            }
            else if (comboBox3.Text == "Yes")
            {
                DataGridHonors.Visible = true;
                HonorsBox.Visible = true;
            }

        }

        // Searches one data grid box; returns true if match found
        private bool courseSearch(string txt, DataGridViewCell cell)
        {
            if (cell.Value != null)
            {
                if ((cell.Value?.ToString().ToLower()).Contains(txt.ToLower())) return true;
            }

            return false;
        }

        // Performs a course search; makes all listed courses that do not match the search invisible; does not seach if user does not enter string
        private void searchButton_Click(object sender, EventArgs e)
        {
            string txt = searchTextBox.Text;

            if (txt == null || txt.Equals("")) return;

            searchBackButton.Visible = true;

            foreach (DataGridView dgv in dgvs)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Visible = true;
                    if (!(courseSearch(txt, row.Cells[0]) || courseSearch(txt, row.Cells[1])))
                    {
                        row.Visible = false;
                        Debug.WriteLine($"Invisible: {row.Cells[0].Value}");
                    }
                }
            }
        }

        // Makes all course rows visible, undoing a search
        private void searchBackButton_Click(object sender, EventArgs e)
        {
            searchClear();

            foreach (DataGridView dgv in dgvs)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (dgv != dataGridRecommended || row.DefaultCellStyle.BackColor != Color.White)
                        row.Visible = true;
                }
            }
        }

        private void searchClear()
        {
            searchBackButton.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}