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
    public partial class Table_Layoutcs : Form
    {
        public Table_Layoutcs()
        {
            InitializeComponent();
        }


        private double Number;

        public double number
        {
            get { return Number; }
            set { Number = value; label4.Text = value.ToString(); }
        }
        private string Date;

        public string date
        {
            get { return Date; }
            set { Date = value; label5.Text = value; }
        }

        private string Iventory_Number;

        public string iventory_number
        {
            get { return Iventory_Number; }
            set { Iventory_Number = value; label6.Text = value; }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
