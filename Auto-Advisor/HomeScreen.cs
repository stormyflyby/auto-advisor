
using Newtonsoft.Json;
using System.Diagnostics;

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
            public int hours { get; set; }
            public string description { get; set; }

            public int honors { get; set; }
        }

        // This class is used to store recommended course info
        public class User
        {
            public int semester { get; set; }
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

                // Store each course and its values in a grid row
                int rowIndex = grid.Rows.Add();
                var row = grid.Rows[rowIndex];
                row.Cells[0].Value = course.code;          // Course Code
                row.Cells[1].Value = course.name;          // Course Name
                row.Cells[2].Value = course.hours;         // Hours

                // Update the total hours for the given major
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
            string json = File.ReadAllText(filePath); // Read the file to a string
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            grid.Rows.Clear();
            foreach (var course in users)
            {
                int sem = int.Parse(comboBox4.SelectedItem.ToString());
                DataGridViewRow row = null;
                // Doesn't load courses beyond current semester or courses already/currently taken
                if (course.semester <= sem && (!courseInTextBox(course.code, textBox1) && !courseInTextBox(course.code, textBox2)))
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
                    else // Course not taken yet
                    {
                        row.DefaultCellStyle.SelectionBackColor = grid.DefaultCellStyle.BackColor;
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
            textBox7.Visible = false;
            button5.Visible = false;

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
            recommendedCourses(Path.Combine(majorPath, "recommended.json"), dataGridRecommended);
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
                    CourseDescription form2 = new CourseDescription(course.code, course.name, course.prerequisites, course.hours, course.description);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridTheology_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridTheology, e.RowIndex, Path.Combine(majorPath, "Theology_Courses.json"));
            }
        }



        private void dataGridMinors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(dataGridMinors, e.RowIndex, Path.Combine(minorPath, "minor_classes.json"));
            }
        }
        private void DataGridHonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                displayCourseDetails(DataGridHonors, e.RowIndex, Path.Combine(majorPath, "Honors_classes.json"));
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
            System.Windows.Forms.MessageBox.Show("The AutoAdvisor helps you with knowing what classes you need to take for your Major(s) and Minor(s)\n\nFor help with Majors/Minors -\nSelect a Major/Minor from the dropdown menu and if you are double Majoring/Minoring then hit the add Major/Minor button then select your second Major/Minor from the dropdown menu\n\nFor help with Honors - \nIf you are a Honors student hit 'yes' and if you're not then hit 'no' \n\nFor help with Upcoming Semester - \nUpcoming semester means the next semester such as if you are currently in semester 4, your upcoming semester will be semester 5\n\nFor help with Completed or Currently Taking courses - \nEnter your Course Code in all caps and hit enter after every entry and only have one course code on every line\n\nFor help with Download data - \nWhen you click download data all of your dropdown menu and data entered will be saved to a document so when you use AutoAdvisor again you do not need to readd the info\n\nFor help with Enter Saved Data - \nIf you have a data file from the Download Data button then you can click the Enter Saved Data button and have all of your info reentered for you. ");
        }

        private void mainScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("The AutoAdvisor splits your classes into different tables to help show what classes you need to take and what category each class is in\n\n                                        Some Helpful Questions - \n\nWhat are Recommended Classes - \nRecommended Classes are the classes that are the highest priority to take whether that be classes that you were meant to take in previous semesters or classes that are made for the upcoming semester, all of your classes that you have not taken will show up in this table.\n\nWhat do the different colors mean -\nThe different colors are Green meaning you have completed the class, Yellow meaning you are currently taking the class and white meaning that you have not taken the class and are not currently in the class.\n\nHow do I find the course description or the Prerequisites - \nIf you find the more button under details on the tables that will display the course info, Prerequisites and additional info.   \n\nHow do I switch between Majors/Minors - \nIf you are trying to switch between different Majors/Minors all you need to do it click the drop down menu and select which Major/Minor you want to see classes for.\n\n What does the box with different hour totals mean - That box tells you five things 1. What semester you are picking classes for, 2. How many hours you have completed, 3. How many hours you are currently taking, 4. How many hours your degree needs to graduate, 5. How many hours you still need to earn to graduate(classes in progress will still show here ");
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
                    row.Visible = true;
                }
            }
        }

        private void searchClear()
        {
            searchBackButton.Visible = false;
        }
    }
}