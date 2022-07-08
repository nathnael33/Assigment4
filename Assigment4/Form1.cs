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

        Model obj = new Model();
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

            obj.Number = txt_Number.Text;
            obj.price = txt_price.Text;
            obj.Object_name = text_ObjectName.Text;
            obj.count = txt_Count.Text;
            obj.date = dateTimePicker1.Value.ToString();
            obj.Inventory_Unit = textBox1.Text;

            MessageBox.Show("Name of the Iteam that is added:" + obj.Object_name);
            MessageBox.Show("No of the Item :" + obj.Number);
            MessageBox.Show("Count of the iteam that is added:" + obj.count);
            MessageBox.Show("Price of the iteam that is Added:" + obj.price);
            MessageBox.Show("When the iteam is added:" + obj.date);
            MessageBox.Show("The inventory Unit:" + obj.Inventory_Unit);


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
    }
}