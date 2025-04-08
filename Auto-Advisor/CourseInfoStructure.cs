using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Advisor
{
    internal class CourseInfoStructure
    {
        public string Major0 { get; set; }
        public string Major1 { get; set; }
        public string Minor0 { get; set; }
        public string Minor1 { get; set; }
        public bool Honors { get; set; }
        public short SemesterNumber { get; set; }
        public List<string> CompletedCourses { get; set; }
        public List<string> InProgressCourses { get; set; }

        public CourseInfoStructure()
        {
            Major0 = string.Empty;
            Major1 = string.Empty;
            Minor0 = string.Empty;
            Minor1 = string.Empty;
            Honors = false;
            SemesterNumber = 0;
            CompletedCourses = new List<string>();
            InProgressCourses = new List<string>();
        }
    }
}
