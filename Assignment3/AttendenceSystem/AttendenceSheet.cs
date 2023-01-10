using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendenceSystem
{
    public class AttendenceSheet
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Date { get; set; }
        //public string AttendenceSymbol { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
