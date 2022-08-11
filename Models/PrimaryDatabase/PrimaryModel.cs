using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class PrimaryModel : ApplicantModel
    {
        [Display(Name = "Primary ID")]
        public int mPrimaryID { get; set; }

        [Display(Name = "Primary School Name")]
        public string mPrimaryName { get; set; }

        [Display(Name = "Current Grade")]
        public int mCurrentGrade { get; set; }
       public override string WelcomeMessage()
        {
            return "Welcome to Primary Education Level";
        }
       public override string names()
        {
            return "Primary Applicants";
        }
    }
}