using Colonies.DataAccess;
using Colonies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonies.Servicesa
{
    public class HouseService
    {
        private readonly HouseDAO _houseDAO;

        public HouseService(HouseDAO houseDAO)
        {
            _houseDAO = houseDAO;
        }

        public HouseDTO GetHouseById(int id)
        {
            return _houseDAO.GetHouse(id);
        }

        public void AddHouse(HouseDTO house)
        {
            ValidateHouse(house);
            _houseDAO.AddHouse(house);
        }

        public void UpdateHouse(HouseDTO house)
        {
            ValidateHouse(house);
            _houseDAO.UpdateHouse(house);
        }

        public void DeleteHouse(int id)
        {
            _houseDAO.DeleteHouse(id);
        }

        private void ValidateHouse(HouseDTO house) {
            if (string.IsNullOrEmpty(house.HouseName) ||
            string.IsNullOrEmpty(house.PostalAddress) ||
            house.PostalCode <= 0 ||
            string.IsNullOrEmpty(house.NameStreet) ||
            house.Capacity <= 0 ||
            house.RegiId <= 0)
            {
                throw new ArgumentException("Invalid house data.");
            }
        }
    }

}
