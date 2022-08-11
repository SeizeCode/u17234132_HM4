using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public abstract class ApplicantModel
    {
        [Display(Name = "ID")]
        public int mID { get; set; }

        [Display(Name = "First Name")]               //APPLICANT'S FIRST NAME
       
        //[MaxLength(50)] //vadlidation
        public string mName { get; set; }

        [Display(Name = "Last Name")]
        public string mSurnname { get; set; }

        [Display(Name = "ID Number")]              //APPLICANT'S ID NUMBER
        //[Required][Range(13,13)] //vadlidation
        public string mID_Number { get; set; }

        [Display(Name = "Home/Residential Address")]           //AAPLICANT'S HOME OR RESIDENTIAL ADDRESSS
        //[Required] //vadlidation
        public string mHome_Address { get; set; }

        //Gaurdian/Parent details
        [Display(Name = "Parent / Guardian Name & Surname")]
      //  [Required]
        [MaxLength(50)]
        public string Parent_Name { get; set; }

        [Display(Name = "Contact_Number")]
       // [Required]
        //[MaxLength(10)]
        // [MaxLength(10)][MinLength(10)]
        public int Contact_Number { get; set; }

       public virtual string WelcomeMessage()
        {
            return "Welcome to Admin Page";
        }
        public abstract string names();
    }
}