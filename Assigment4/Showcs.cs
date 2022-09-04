using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment4
{
    public partial class Showcs : Form
    {
        public Showcs()
        {
            InitializeComponent();

        }
       /* private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliked");
        }*/


        private void Showcs_Load(object sender, EventArgs e)
        {
            List<Model> l = Model.get_allProducts();
            panel1.Controls.Clear();

            foreach (var iteam in l)
            {


                UserControl1 userControl = new UserControl1();
                userControl.product_name = iteam.Object_name;
                userControl.price = iteam.price;
                userControl.count = iteam.count;
              
                userControl.Click += (Object o, EventArgs e1) =>
                {
                    Table_Layoutcs table_Layoutcs = new Table_Layoutcs();
                   // table_Layoutcs.number = iteam.Number;
                    table_Layoutcs.date = iteam.date;
                    table_Layoutcs.iventory_number = iteam.Inventory_Unit;
                    Hide();
                    table_Layoutcs.Show();
                   
                };
                
                //userControl.Click+= label1_Click;
                panel1.Controls.Add(userControl);




             }





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackColor= Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor=Color.Blue;
        }
    }
}
