using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    internal interface IPrimaryRep
    {
        List<PrimaryModel> SelectAllPrimary();

        PrimaryModel SelectByid(int id);

        void CreatePrimary(PrimaryModel prim);
        void UpdatePrimary(PrimaryModel primary);
        void DeletePrimary(int id,PrimaryModel prim);
    }
}
