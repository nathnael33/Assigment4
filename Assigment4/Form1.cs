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

        public Form1()
        {
            InitializeComponent();
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

            if (string.IsNullOrEmpty(text_ObjectName.Text)){

                errorProvider1.SetError(text_ObjectName, "Name required");
                
            }

            else { errorProvider1.Clear(); obj.Object_name = text_ObjectName.Text; checker_name = true; }


            if (string.IsNullOrEmpty(txt_Count.Text))
            {

                errorProvider1.SetError(txt_Count, "Number required");
            }

            else { errorProvider1.Clear(); obj.count = txt_Count.Text; checker_type = true; }


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

                obj.Number = txt_Number.Text;
                checker_Item = true; 
            }


            if (string.IsNullOrEmpty(txt_price.Text))
            {
                errorProvider1.SetError(txt_price, "price required");

            }

            else
            {
                errorProvider1.Clear();  obj.price = txt_price.Text;

                checker_Price = true;











            }



        obj.date = dateTimePicker1.Value.ToString();








            if (checker_name==true&&checker_type==true&&checker_Price==true&&checker_Item==true&&checker_Inventory==true)
            {
                MessageBox.Show("List Added!!");
                obj.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Model.get_allProducts();
            }

           /* 
            MessageBox.Show("No of the Item :" + obj.Number);
            MessageBox.Show("Count of the iteam that is added:" + obj.count);
            MessageBox.Show("Price of the iteam that is Added:" + obj.price);
            MessageBox.Show("When the iteam is added:" + obj.date);
            MessageBox.Show("The inventory Unit:" + obj.Inventory_Unit);*/


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
    }
}