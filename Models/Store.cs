using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ale_Hojda.Models
{
    public class Store
    {   
        public int StoreID { get; set; }
        public int RestaurantID { get; set; }
        public int ProductID { get; set; }

        public Restaurant Restaurant { get; set; }
        public Product Product { get; set; }
    }
}
