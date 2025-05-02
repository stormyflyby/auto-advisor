using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Auto_Advisor
{
    /* Stores course info given by user for other parts of the system to use
     * To use, refer to CourseInfoMediator.Instance.
     * For example, to add a major, set CourseInfoMediator.Instance.Major0.
     */
    internal sealed class CourseInfoMediator
    {
        // CourseInfoMediator is a singleton. This code ensures only one instance of it can exist.
        // To use it, refer to CourseInfoMediator.Instance
        private static readonly Lazy<CourseInfoMediator> instance = new Lazy<CourseInfoMediator>(() => new CourseInfoMediator());
        public static CourseInfoMediator Instance => instance.Value;

        // ID for the Windows downloads folder
        public static readonly Guid FOLDERID_Downloads = new("374DE290-123F-4565-9164-39C4925E467B");

        // shell32.dll and ole32.dll contain necessary functions to access the Downloads folder
        [DllImport("shell32.dll")]
        public static extern int SHGetKnownFolderPath(
            [MarshalAs(UnmanagedType.LPStruct)] Guid rfid,
            uint dwFlags,
            IntPtr hToken,
            out IntPtr ppszPath);

        [DllImport("ole32.dll")]
        public static extern void CoTaskMemFree(IntPtr ptr);

        public string Major0 { get; set; }
        public string Major1 { get; set; }
        public string Minor0 { get; set; }
        public string Minor1 { get; set; }
        public bool Honors { get; set; }
        public short SemesterNumber { get; set; }
        public HashSet<string> CompletedCourses { get; set; }
        public HashSet<string> InProgressCourses { get; set; }

        private CourseInfoMediator()
        {
            Major0 = string.Empty;
            Major1 = string.Empty;
            Minor0 = string.Empty;
            Minor1 = string.Empty;
            Honors = false;
            SemesterNumber = 0;
            CompletedCourses = new HashSet<string>();
            InProgressCourses = new HashSet<string>();
        }

        public void AddCompletedCourse(string course)
        {
            CompletedCourses.Add(course);
        }

        public void RemoveCompletedCourse(string course)
        {
            CompletedCourses.Remove(course);
        }

        public void ClearCompletedCourses()
        {
            CompletedCourses.Clear();
        }

        public void AddInProgressCourse(string course)
        {
            InProgressCourses.Add(course);
        }

        public void RemoveInProgressCourse(string course)
        {
            InProgressCourses.Remove(course);
        }

        public void ClearInProgressCourses()
        {
            InProgressCourses.Clear();
        }

        public bool IsTaken(string course)
        {
            return CompletedCourses.FirstOrDefault(s => s.Equals(course), null) != null;
        }

        public bool IsInProgress(string course)
        {
            return InProgressCourses.FirstOrDefault(s => s.Equals(course), null) != null;
        }

        public void AllCompleted()
        {
            foreach (string course in CompletedCourses)
            {
                MessageBox.Show(course);
            }
        }

        public void AllInProgress()
        {
            foreach (string course in InProgressCourses)
            {
                MessageBox.Show(course);
            }
        }

        // Returns a JSON string representing this object
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        // Sends a JSON file representing this objects to the user's downloads folder
        public void SendToDownloads()
        {
            string jString = ToJson();
            string sPath = "./auto_advisor_save.json";

            File.WriteAllText(sPath, jString);

            IntPtr outPath;
            int hr = SHGetKnownFolderPath(FOLDERID_Downloads, 0, IntPtr.Zero, out outPath);
            if (hr == 0) // S_OK
            {
                string downPath = Marshal.PtrToStringUni(outPath);
                CoTaskMemFree(outPath);
                downPath += "/auto_advisor_save.json";
                if (File.Exists(downPath))
                {
                    File.Delete(downPath);
                }

                File.Move(sPath, downPath);
            }
            else
            {
                throw new Exception("Downloads folder not found");
            }
        }
    }
}

