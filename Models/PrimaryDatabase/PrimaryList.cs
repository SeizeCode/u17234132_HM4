using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class PrimaryList
    {

        private static readonly List<PrimaryModel> primarylist = null;

        static PrimaryList()
        {
            primarylist = new List<PrimaryModel>()
            {
                new PrimaryModel()
                {
                    mID=1,
                    mName="Nkosinathi",
                    mSurnname="Msiza",
                    mHome_Address="280 Block ss Ext1 Soshanguve 0152",
                    mCurrentGrade=7,
                    mID_Number="9810055339082",
                    mPrimaryID=1,
                    mPrimaryName="Prestige College",
                    Parent_Name="Vusi Mashabela",
                    Contact_Number=0612342445
                    
                }
            };
        }

        public static List<PrimaryModel> SelectAllPrimaryList()
        {
            return primarylist;
        }

        public static void CreatePrimary(PrimaryModel prim)
        {
            primarylist.Add(prim);
        }

        public static void UpdatePrimary(PrimaryModel prim)
        {
            PrimaryModel primUpdate = primarylist.Find(x => x.mID == prim.mID);
            primUpdate.mName = prim.mName;
            primUpdate.mSurnname = prim.mSurnname;
            primUpdate.mPrimaryName = prim.mPrimaryName;
            primUpdate.mPrimaryID = prim.mPrimaryID;
            primUpdate.Parent_Name = prim.Parent_Name;
            primUpdate.mCurrentGrade=prim.mCurrentGrade;
            primUpdate.Contact_Number = prim.Contact_Number;
            primUpdate.mHome_Address = prim.mHome_Address;
        }

        public static void DeletePrimary(int id)
        {
            PrimaryModel primdelete = primarylist.Find(x => x.mID == id);
            primarylist.Remove(primdelete);
        }
    }
}