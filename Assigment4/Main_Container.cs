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
    public partial class Main_Container : Form
    {
        public Main_Container()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {


            

        }

        private void Main_Container_Load(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void loginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {


         



        }

        private void openFormToolStripMenuItem_Click(object sender, EventArgs e)
        {


        

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {


                ActiveMdiChild.Close();


            }



            Form1 screen = new Form1(" ");
            screen.MdiParent = this;


            screen.Show();
           
            
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {


                ActiveMdiChild.Close();


            }



            Showcs screen = new Showcs();
            screen.MdiParent = this;


            screen.Show();
        }
    }
}
