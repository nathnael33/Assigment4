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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string username = textBox1.Text; 
            string password = textBox2.Text;

            if(username=="Admin"&& password == "Admin")
            {
                
                Form1 screen =new Form1(username);
                screen.Show();
                MessageBox.Show("Welcome!!");
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect");



            }
        }
    }
}
