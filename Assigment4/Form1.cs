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
    public partial class Form1 : Form
    {

        public Form1(string name)
        {
            InitializeComponent();
            label2.Text = name;
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            Model obj = new Model();
            bool checker_name = false;
            bool checker_type = false;
            bool checker_Inventory=false;
            bool checker_Item=false;
            bool checker_Price = false;

            string Count;
            string number;
            string price;

            if (string.IsNullOrEmpty(text_ObjectName.Text)){

                errorProvider1.SetError(text_ObjectName, "Name required");
                
            }

            else { errorProvider1.Clear(); obj.Object_name = text_ObjectName.Text; checker_name = true; }


            if (string.IsNullOrEmpty(txt_Count.Text))
            {

                errorProvider1.SetError(txt_Count, "Number required");
            }

            else {


                errorProvider1.Clear();
                try
                {
                    Count = txt_Count.Text; checker_type = true; obj.count = Int16.Parse(Count);
                }

                catch (System.FormatException)
                {
                    System.Console.WriteLine("Please enter  a number");

                }
                }


            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Inventory required");
            }
            else
            {
                errorProvider1.Clear();
                obj.Inventory_Unit = textBox1.Text; checker_Inventory = true;
            }



            if (string.IsNullOrEmpty(txt_Number.Text)){
                errorProvider1.SetError(txt_Number, "Number required");
            }
            else
            {
                errorProvider1.Clear();
              

               try
                {
                    number = txt_Number.Text;
                    obj.Number = Int16.Parse(number);
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Please enter  a number");
                }
                checker_Item = true; 
            }


            if (string.IsNullOrEmpty(txt_price.Text))
            {
                errorProvider1.SetError(txt_price, "price required");

            }

            else
            {
                errorProvider1.Clear(); 
               

                try
                {
                    price = txt_price.Text;
                    obj.price = double.Parse(price);
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Please Enter a Number");
                }


                checker_Price = true;











            }



        obj.date = dateTimePicker1.Value.ToString();


                


            
            obj.isAvaliable = chkProductAvaliable.Checked;

            if (checker_name==true&&checker_type==true&&checker_Price==true&&checker_Item==true&&checker_Inventory==true)
            {
              
                if (obj.isAvaliable == true)
                {
                    obj.save();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Model.get_allProducts();

                     string items = " ";
                     foreach (var iteam in chk_options.CheckedItems)
                     {

                         items =items+"  "+ iteam.ToString();
                     }

                     MessageBox.Show(" Delivery Method: "+items);

                   
                   if( radioButton1.Checked == true)
                    {
                        MessageBox.Show("Payment Method :PayPal");
                    }
                   else if( radioButton2.Checked == true)
                    {
                        MessageBox.Show("Payment Method :TeleBirr");

                    }
                   else
                    {
                        MessageBox.Show("Payment Method :You have not chosen a payement system");
                    }

                }
                else
                {
                    MessageBox.Show("not available");
                }
               
            }

   


        }

        private void text_ObjectName_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }



        private void txt_Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_options_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}