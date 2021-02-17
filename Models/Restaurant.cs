using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ale_Hojda.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Specialty { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}