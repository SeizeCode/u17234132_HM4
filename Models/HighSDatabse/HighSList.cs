using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.HighSDatabse
{
    public class HighSList
    {
        private static readonly List<HighSModel> highSList = null;

        static HighSList()
        {
            highSList = new List<HighSModel>()
            {
                new HighSModel()
                {
                    mID=1,mName="Hendrick",mSurnname="Van Burren",mID_Number="9619347383",Email="HednrickVb@gmail.com",
                    mHome_Address="Lunnon Road,Lunnon Crest,Hatfield,Pretoria,0083",Parent_Name="Mr Collin Vav Burren",
                    Contact_Number=076535288,mGrade=11,mCareerField="Business Management",mSchoolName="Pretoria Boys High School",
                    mSubjects="Biology,Mathematics,Life Orientaton,English,Afrikaans,Information Technology,Physical Sciences"
                }
            };
        }

        public static List<HighSModel> SelectAllHighList()
        {
            return highSList;//return the list of high school applicants
        }

        public static void CreateHigh(HighSModel high)
        {
            highSList.Add(high);//add new high school applicnt into the exisiting list
        }

        public static void UpdateHigh(HighSModel high)
        {
            HighSModel highUpdate = highSList.Find(x => x.mID == high.mID);
            highUpdate.mName=high.mName;
            highUpdate.mSurnname = high.mSurnname;
            highUpdate.mID_Number = high.mID_Number;
            highUpdate.Email = high.Email;
            highUpdate.mHome_Address = high.mHome_Address;
            highUpdate.Parent_Name = high.Parent_Name;
            highUpdate.Contact_Number = high.Contact_Number;
            highUpdate.mGrade = high.mGrade;
            highUpdate.mSubjects = high.mSubjects;
            highUpdate.mCareerField = high.mCareerField;
        }
        public static void DeleteHigh(int id)
        {
            HighSModel highdelete = highSList.Find(x => x.mID == id);
            highSList.Remove(highdelete);
        }
    }
}