using Colonies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonies.DataAccess
{
    public interface InterfazHouseDAO
    {
        HouseDTO GetHouse(int id);
        void AddHouse(HouseDTO house);
        void UpdateHouse(HouseDTO house);
        void DeleteHouse(int id);
    }
}
