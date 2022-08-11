using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class PrimaryRep : IPrimaryRep
    {

        public void CreatePrimary(PrimaryModel prim)
        {
            PrimaryList.CreatePrimary(prim);
        }

        public void DeletePrimary(int id, PrimaryModel prim)
        {
            PrimaryList.DeletePrimary(id);
        }

        public List<PrimaryModel> SelectAllPrimary()
        {
            return PrimaryList.SelectAllPrimaryList();
        }

        public PrimaryModel SelectByid(int id)
        {
            return PrimaryList.SelectAllPrimaryList().Find(x => x.mID == id);
        }

        public void UpdatePrimary(PrimaryModel prim)
        {
            PrimaryList.UpdatePrimary(prim);
        }
    }
}