using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.HighSDatabse
{
    public class HighSModel : ApplicantModel
    {
        [Display(Name = "High School Grade")]
       // [Required]
        public int mGrade { get; set; }

        [Display(Name = "Current High School Name")]
       // [Required]
        public string mSchoolName { get; set; }

        [Display(Name = "Career Choise")]
       // [Required]
        public string mCareerField { get; set; }

        [Display(Name = "High School Subject stream")]
       // [Required]
        public string mSubjects { get; set; }

        [Display(Name = "Contact Email")]
        public string Email { get; set; }
        public override string names()
        {
            return "High School Applicants";
        }
        public override string WelcomeMessage()
        {
            return "Welcome to High School Education Level";
        }
    }
}