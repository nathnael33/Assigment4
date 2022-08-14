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

        private string Price;
        public string price
        {
            get { return Price; }
            set { Price = value;label2.Text = value; }


        }

        private string Number;
        public string number
        {
            get { return Number; }
            set { Number = value;label3.Text = value; }
        }



    }
}
