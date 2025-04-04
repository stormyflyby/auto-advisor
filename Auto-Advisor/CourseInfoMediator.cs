using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
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

        public string Major0 { get; set; }
        public string Major1 { get; set; }
        public string Minor0 { get; set; }
        public string Minor1 { get; set; }
        public bool Honors { get; set; }
        public short SemesterNumber { get; set; }
        public List<string> CompletedCourses { get; }
        public List<string> InProgressCourses { get; }




        private CourseInfoMediator()
        {
            Major0 = string.Empty;
            Major1 = string.Empty;
            Honors = false;
            SemesterNumber = 0;
            CompletedCourses = new List<string>();
            InProgressCourses = new List<string>();
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
    }
}
