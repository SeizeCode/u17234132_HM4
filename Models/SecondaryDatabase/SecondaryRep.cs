using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.SecondaryDatabase
{
    public class SecondaryRep : ISecondaryRep
    {
        public void CreateSecondary(SecondaryModel sec)
        {
            SecondaryList.CreateSecondary(sec);
        }

        public void DeleteSecondary(int id, SecondaryModel sec)
        {
            SecondaryList.DeleteSecondary(id);
        }

        public List<SecondaryModel> SelectAllSecondary()
        {
            return SecondaryList.SelectAllSecondaryList();
        }

        public SecondaryModel SelectById(int id)
        {
            return SecondaryList.SelectAllSecondaryList().Find(x => x.mID == id);
        }

        public void UpdateSecondary(SecondaryModel sec)
        {
            SecondaryList.UpdateSecondary(sec);
        }
    }
}