using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models.HighSDatabse
{
    internal interface IHighRep
    {

        List<HighSModel> SelectAllHigh();
        HighSModel SelecrById(int id);

        void CreateHigh(HighSModel high);
        void UpdateHigh(HighSModel high);
        void DeleteHigh(int id,HighSModel high);

    }
}
