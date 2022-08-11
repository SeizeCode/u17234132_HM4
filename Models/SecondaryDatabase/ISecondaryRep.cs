using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models.SecondaryDatabase
{
    internal interface ISecondaryRep
    {
        List<SecondaryModel> SelectAllSecondary();

        SecondaryModel SelectById(int id);

        void CreateSecondary(SecondaryModel sec);
        void UpdateSecondary(SecondaryModel sec);
        void DeleteSecondary(int id,SecondaryModel sec);
    }
}
