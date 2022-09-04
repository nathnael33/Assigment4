using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assigment4
{
    public partial class TestDBcs : Form
    {
        string my_connection_string = "Data Source=DESKTOP-CRCECQ7\\SQLEXPRESS;" +
                                                    "Initial Catalog=testlab;" +
                                                    "Integrated Security=true;";
        public TestDBcs()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (SqlConnection conn = new SqlConnection(my_connection_string))
                {

                    conn.Open();
                    MessageBox.Show("Connected");
                }
            }
            catch (SqlException k)
            {
                MessageBox.Show("Could not connect");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(my_connection_string))
            {

                conn.Open();
                string command = "insert into kop values(1,'nathnael')";
               
                SqlCommand cmd = new SqlCommand(command, conn);
              int check=  cmd.ExecuteNonQuery();
                if (check == 1)
                {
                    MessageBox.Show("Inserted");
                }
                else
                {
                    MessageBox.Show("Not Inserted");
                }
            }


        }
    }
}
