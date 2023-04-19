using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name ="Xbox", Price = 350},
             new Product (){Name ="Guitar", Price = 1000},
              new Product (){Name ="Blender", Price = 50},
               new Product (){Name ="Kite", Price = 25},

        };
        public List<Product> LoadData
        {
            get
            {
                Console.WriteLine("I am reading data from List Data Access");

                return Products;
            }
        }

        List<Product> IDataAccess.LoadData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Data Access");
        }
    }
}
