﻿using System;
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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string Product_Name;

        public string product_name
        {
           get {return Product_Name ;}
           set { Product_Name = value;label1.Text = value; }   
        }

        private double Price;
        public double price
        {
            get { return Price; }
            set { Price = value;label4.Text = value.ToString(); }


        }

        private double Count;
        public double count
        {
            get { return Count; }
            set { Count = value;label2.Text = value.ToString(); }
        }

        private double Number;
        public double number
        {
            get { return Number; }
            set { Number = value; label3.Text = value.ToString(); }
        }

        private string Date;
        public string date
        {
            get { return Date; }
            set { Date = value; label5.Text = value.ToString(); }
        }
        private string Iventory_Unit;
        public string iventory_unit
        {
            get { return Iventory_Unit; }
            set { Iventory_Unit = value; label5.Text = value.ToString(); }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        public void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliked");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
