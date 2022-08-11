using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication2.Models;
namespace WebApplication2.Models.SecondaryDatabase
{
    public class SecondaryModel : ApplicantModel
    {
        //secondary level attributes
        [Display(Name = "First Additional Language")]        // langauge
        ///[Required]
        public string First_Additional { get; set; }

        [Display(Name = "Current Secondary School Name")]              //APPLICANT'S school name
       // [Required] //vadlidation
        public string Current_School { get; set; }

        [Display(Name = "Current Secondary Grade")]              //APPLICANT'S school grade
       // [Required] //vadlidation
        public int mGrade { get; set; }

        [Display(Name = "Subject currently enrolled for:")]              //
       // [Required] //vadlidation
        public string Subjects { get; set; }
        public override string WelcomeMessage()
        {
            return "Welcom to Secondary school Education Level";
        }
        public override string names()
        {
            return "Secondary Applicants";
        }
    }
}