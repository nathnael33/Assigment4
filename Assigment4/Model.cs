using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assigment4
{
    internal class Model
    {
        static List<Model> l = new List<Model>();
   
        string  my_connection_string = "Data Source=DESKTOP-CRCECQ7\\SQLEXPRESS;" +
                                                "Initial Catalog=product;" +
                                                "Integrated Security=true;";

        public string Object_name{ get; set; }
        public string price { get; set; }
        public  string count { get; set; }
        public string Number { get; set; }
        public string date { get; set; }
        public string Inventory_Unit { get; set; }
        public bool isAvaliable { get; set; }

        
        
       

        public void save()
        {
           
            
            
            string command= "insert into obj (objectname,price,count_1,number,date_1,Inventory_Unit) values(@objectname,@price,@count_1,@number,@date_1,@Inventory_Unit)";

            using (SqlConnection conn = new SqlConnection(my_connection_string)) {

                conn.Open();
                SqlCommand cmd=new SqlCommand(command, conn);
                cmd.Parameters.Add(new SqlParameter("@objectname", System.Data.SqlDbType.VarChar, 200)).Value = Object_name;
                cmd.Parameters.Add(new SqlParameter("@price", System.Data.SqlDbType.Money)).Value = price;
                cmd.Parameters.Add(new SqlParameter("@count_1", System.Data.SqlDbType.Money)).Value = count;
                cmd.Parameters.Add(new SqlParameter("@number", System.Data.SqlDbType.Money)).Value = Number;
                cmd.Parameters.Add(new SqlParameter("@date_1", System.Data.SqlDbType.VarChar, 200)).Value = date;
                cmd.Parameters.Add(new SqlParameter("@Inventory_Unit", System.Data.SqlDbType.VarChar, 200)).Value = Inventory_Unit;
                cmd.ExecuteNonQuery();



            }


            l.Add(this);




        }

        public static List<Model> get_allProducts() {   
            return l; }

        public     List<Model> get_allproducts1()
        {
            
            

            string command = "select * from obj";
            using (SqlConnection conn = new SqlConnection(my_connection_string))
            {
                List<Model> temp = new List<Model>();

                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    temp.Add(new Model()
                    {
                        Object_name = dr[0].ToString(),
                        price = dr[1].ToString(),
                        count = dr[2].ToString(),
                        Number = dr[3].ToString(),
                        date = dr[4].ToString(),
                        Inventory_Unit=dr[5].ToString(),    



                    }) ;
                  


                }
                return temp;

            }
        }

        public static Model findone(string Name)
        {

            return l.Find(obj => obj.Object_name == Name);


        }
           









    }
}
