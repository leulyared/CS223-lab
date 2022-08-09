using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Product
    {
        public int Num { get; set; }
        public string Date { get; set; }
        public int Inventory_number { get; set; }
        public string Object_name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }
        private static List<Product> modelList = new List<Product>();
        public void save() 
        {
            modelList.Add(this);
        }
        public static List<Product> GetList()
        {
            return modelList;
        }
    }
    
}
