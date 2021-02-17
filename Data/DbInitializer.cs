using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ale_Hojda.Models;
namespace Ale_Hojda.Data
{
    public class DbInitializer
    {
        public static void Initialize(MagazinContext context)
        {
            context.Database.EnsureCreated();
            if (context.Restaurants.Any())
            {
                return;
            }
            var Restaurants = new Restaurant[]
            {
new Restaurant{Name="No Dinero",Adress="Tijuana",Specialty="Mexican"},
new Restaurant{Name="Popa Florin",Adress="Seoul",Specialty="Korean"},
new Restaurant{Name="Marinescu Iulia", Adress="Santorini",Specialty="Greek"},
            };
            foreach (Restaurant s in Restaurants)
            {
                context.Restaurants.Add(s);
            }
            context.SaveChanges();
            var products = new Product[]
            {
new Product{ProductID=55,Name="Taco",Price=Decimal.Parse("4")},
new Product{ProductID=45,Name="Ramen",Price=Decimal.Parse("5")},
new Product{ProductID=22,Name="Soulvaki",Price=Decimal.Parse("3")},
            };
            foreach (Product c in products)
            {
                context.Products.Add(c);
            }
            context.SaveChanges();
            var stores = new Store[]
            {
new Store{RestaurantID=1,ProductID=1050},
new Store{RestaurantID=3,ProductID=1045},
new Store{RestaurantID=1,ProductID=1040},
new Store{RestaurantID=2,ProductID=1050},
            };
            foreach (Store e in stores)
            {
                context.Stores.Add(e);
            }
            context.SaveChanges();
        }
    }
}