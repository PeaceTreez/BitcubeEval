using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCubeTest.Models
{
    public class CourseModel
    {
        public string Name { get; set; }
        public int DurationMonths { get; set; }
        public DegreeModel Degree { get; set; } //This is the degree the course is part of

    }
}