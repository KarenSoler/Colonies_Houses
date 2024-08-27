using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonies.Models
{
    public class HouseDTO
    {
        public int HouseId { get; set; }
        public string HouseName { get; set; }
        public string PostalAddress { get; set; }
        public int PostalCode { get; set; }
        public string NameStreet { get; set; }
        public int Capacity { get; set; }
        public int RegiId { get; set; }
    }
}