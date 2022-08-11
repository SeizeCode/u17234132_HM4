using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.HighSDatabse
{
    public class HighRep : IHighRep
    {
        public void CreateHigh(HighSModel high)
        {
            HighSList.CreateHigh(high);
        }

        public void DeleteHigh(int id, HighSModel high)
        {
            HighSList.DeleteHigh(id);
        }

        public HighSModel SelecrById(int id)
        {
            return HighSList.SelectAllHighList().Find(x => x.mID == id);
        }

        public List<HighSModel> SelectAllHigh()
        {
            return HighSList.SelectAllHighList();
        }

        public void UpdateHigh(HighSModel high)
        {
            HighSList.UpdateHigh(high);
        }
    }
}