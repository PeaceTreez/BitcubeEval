using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCubeTest.Models
{
    public class LecturerModel
    {
        public string[] Fornames { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DegreeModel[] Degrees { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }

        public LecturerModel()
        {
            FirstName = Fornames[0];

            foreach(var name in Fornames)
            {
                FullName += $"{name} ";
            }

            FullName += Surname;
        }
    }
}