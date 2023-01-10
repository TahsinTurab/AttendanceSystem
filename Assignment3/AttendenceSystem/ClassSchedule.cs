using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendenceSystem
{
    public class ClassSchedule
    {
        public int Id { get; set; }
        public string Day { get; set; }
        
        public string StartingTime { get; set; }
        public string EndingTime { get; set; }
        public int TotalNumberOfClasses { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
