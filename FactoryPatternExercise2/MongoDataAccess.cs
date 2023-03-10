using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name ="Hand Towels", Price=20},
            new Product() {Name ="Candles", Price = 16},
            new Product() {Name = "WebCam", Price = 45},
            new Product() {Name = "Dog Food", Price = 65},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading Data from Mongo Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from Mongo Data Access");
        }
    }
}
