using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.SecondaryDatabase
{
    public class SecondaryList
    {
        private static readonly List<SecondaryModel> secondarylist = null;

        static SecondaryList()
        {
            secondarylist = new List<SecondaryModel>()
            {
                new SecondaryModel()
                {
                    //default data
                    mID=1,mName="John",mSurnname="Muller",mHome_Address="404A Mandela Street,Pretoria, 0087",mID_Number="95224489373"
                    ,mGrade=8,Current_School="Langehoven High School",Parent_Name="Mr Jacob Muller",First_Additional="English",Contact_Number=0613873892,
                    Subjects="English,Afrikaan,Mathematics,Physical Sciences,Life Science,Life Oreintation,AP Maths"
                }
            };
        }

        public static List<SecondaryModel> SelectAllSecondaryList()
        {
            return secondarylist;//get the current list of secondary applicants
        }

        public static void CreateSecondary(SecondaryModel sec)
        {
            secondarylist.Add(sec);//add new object into the exisiting list
        }

        public static void UpdateSecondary(SecondaryModel sec)
        {
            SecondaryModel secupdate = secondarylist.Find(x => x.mID == sec.mID);
            //secupdate.mID = sec.mID;
            secupdate.mSurnname = sec.mSurnname;
            secupdate.mName = sec.mName;
            secupdate.mGrade = sec.mGrade;
            secupdate.mID_Number = sec.mID_Number;
            secupdate.Contact_Number = sec.Contact_Number;
            secupdate.Current_School = sec.Current_School;
            secupdate.Parent_Name = sec.Parent_Name;
            secupdate.First_Additional = sec.First_Additional;
            secupdate.Subjects = sec.Subjects;
        }

        public static void DeleteSecondary(int id)
        {
            SecondaryModel secdelete = secondarylist.Find(x => x.mID == id);
            secondarylist.Remove(secdelete);//remove the object by its ID from the list
        }

    }
}