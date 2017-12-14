using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int P1= 0; //Declare variable to store number of 1p conins
        int P2 = 0; //Declare variable to store number of 2p conins
        int P5 = 0; //Declare variable to store number of 5p conins
        int P10 = 0; //Declare variable to store number of 10p conins
        int P20 = 0; //Declare variable to store number of 20p conins
        int P50 = 0; //Declare variable to store number of 50p conins
        int Q1 = 0; //Declare variable to store number of 1 pound conins
        int Q2 = 0; //Declare variable to store number of 2 pound conins
        int Ptotal = 0; //Declare variable to store total in pence

        public Form1()
        {
            InitializeComponent();
        }


        private void Coins_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Button1P_Click(object sender, EventArgs e)
        {
            P1 = P1 + 1; // When 1p button clicked add 1 to number.
            Ptotal = Ptotal + 1; // When 1p button clicked add 1 to total money
            textBox1.Text = Ptotal.ToString(); // updates the total displayed in the GUI.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button50P_Click(object sender, EventArgs e)
        {

        }
    }
}
