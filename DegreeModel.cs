using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCubeTest.Models
{
    public class DegreeModel
    {
        public string Name { get; set; }
        public int DurationYears { get; set; }
        public CourseModel[] Courses { get; set; }
        public LecturerModel Lecturer { get; set; }
    }
}