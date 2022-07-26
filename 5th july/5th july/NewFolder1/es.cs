using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_july.NewFolder1
{
    internal class es
    {
        private static List<es>  items= new List<es>();
        public int num1 { get; set; }    
        public DateTime date { get; set; }  

        public string invname { get; set; }    

        public string objname { get; set; } 

        public string count { get; set; }  

        public string price { get; set; }

        public bool isAvailable { get; set; }
        public void save()
        {
            items.Add(this);

            Console.WriteLine("added ");
        }
        static public List<es> getallproduct()
        {
            
            return items;
        }
    }
}
