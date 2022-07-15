using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4
{
    internal class Model
    {
        static List<Model> l = new List<Model>();

        public string Object_name{ get; set; }
        public string price { get; set; }
        public  string count { get; set; }
        public string Number { get; set; }
        public string date { get; set; }
        public string Inventory_Unit { get; set; }

        

        public void save()
        {

            l.Add(this);




        }

        public static List<Model> get_allProducts() { return l; }
           









    }
}
