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
            CPCtotal.Text = "0"; //sets the default value for the credit box
            NOCtotal.Text = "0"; //Sets the default value for the number of credit box
        }

        private void UpdateTotals() // function to update the totals based added money
        {
            double calcs = (double) Ptotal/100; //creates a temp variable to store the total in £ and P
            PoundTotal.Text = calcs.ToString(); //displays the updated amount
             

            double NoCreds = Double.Parse(CPCtotal.Text); //parses the value of a credit
            NoCreds = NoCreds * 100; // turns the credit into an int to calculate number of credits
            

            int calcs1 = (int)NoCreds; // works out the credit in pence
            calcs1 = Ptotal / calcs1 ; // divides the pence total to calculate number of credits

            NOCtotal.Text = calcs1.ToString(); // displays the number of credits
        }

        private void Coins_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

       

        private void Button1P_Click(object sender, EventArgs e)
        {
            if (CPCtotal.Text=="0") // checks if credit value has been set
            {
                MessageBox.Show("You have not set the cost of a credit"); //if not show a message
            }
            else //else perform the actions below for functionality
            {
                P1 = P1 + 1; // When 1p button clicked add 1 to number.
                Ptotal = Ptotal + 1; // When 1p button clicked add 1 to total money
                PenceTotal.Text = Ptotal.ToString(); // updates the total displayed in the GUI.
                p1_count.Text = P1.ToString(); //updates the total number of coins label
                UpdateTotals(); // calls function to update totals on the screen
            }

        }

        private void Button50P_Click(object sender, EventArgs e)
        {
            if (CPCtotal.Text == "0") // checks if credit value has been set
            {
                MessageBox.Show("You have not set the cost of a credit"); //if not show a message
            }
            else //else perform the actions below for functionality
            {
                P50 = P50 + 1; // When 50p button clicked add 1 to number.
            Ptotal = Ptotal + 50; // When 5p button clicked add 50 to total money
            PenceTotal.Text = Ptotal.ToString(); // updates the total displayed in the GUI.
            p50_count.Text = P50.ToString(); //updates the total number of coins label
            UpdateTotals(); // calls function to update totals on the screen
        }

        private void Button5P_Click(object sender, EventArgs e)
        {
            if (CPCtotal.Text == "0") // checks if credit value has been set
            {
                MessageBox.Show("You have not set the cost of a credit"); //if not show a message
            }
            else //else perform the actions below for functionality
            {
                P5 = P5 + 1; // When 5p button clicked add 1 to number.
            Ptotal = Ptotal + 5; // When 5p button clicked add 5 to total money
            PenceTotal.Text = Ptotal.ToString(); // updates the total displayed in the GUI.
            p5_count.Text = P5.ToString(); //updates the total number of coins label
            UpdateTotals(); // calls function to update totals on the screen
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button20P_Click(object sender, EventArgs e)
        {
            if (CPCtotal.Text == "0") // checks if credit value has been set
            {
                MessageBox.Show("You have not set the cost of a credit"); //if not show a message
            }
            else //else perform the actions below for functionality
            {
                P20 = P20 + 1; // When 20p button clicked add 1 to number.
            Ptotal = Ptotal + 20; // When 20p button clicked add 20 to total money
            PenceTotal.Text = Ptotal.ToString(); // updates the total displayed in the GUI.
            p20_count.Text = P20.ToString(); //updates the total number of coins label
            UpdateTotals(); // calls function to update totals on the screen
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CPCtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2P_Click(object sender, EventArgs e)
        {
            if (CPCtotal.Text == "0") // checks if credit value has been set
            {
                MessageBox.Show("You have not set the cost of a credit"); //if not show a message
            }
            else //else perform the actions below for functionality
            {
                P2 = P2 + 1; // When 2p button clicked add 1 to number.
                Ptotal = Ptotal + 2; // When 2p button clicked add 2 to total money
                PenceTotal.Text = Ptotal.ToString(); // updates the total displayed in the GUI.
                p2_count.Text = P2.ToString(); //updates the total number of coins label
                UpdateTotals(); // calls function to update totals on screen
            }
        }

        private void Button10P_Click(object sender, EventArgs e)
        {
                        if (CPCtotal.Text == "0") // checks if credit value has been set
                        {
                            MessageBox.Show("You have not set the cost of a credit"); //if not show a message
                        }
                        else //else perform the actions below for functionality
                        {
                            P10 = P10 + 1; // When 10p button clicked add 1 to number.
            Ptotal = Ptotal + 10; // When 10p button clicked add 10 to total money
            PenceTotal.Text = Ptotal.ToString(); // updates the total displayed in the GUI.
            p10_count.Text = P10.ToString(); //updates the total number of coins label
            UpdateTotals(); // calls function to update totals on screen
        }

        private void Button1Q_Click(object sender, EventArgs e)
                              if (CPCtotal.Text == "0") // checks if credit value has been set
                        {
                            MessageBox.Show("You have not set the cost of a credit"); //if not show a message
                        }
                        else //else perform the actions below for functionality
                        {
                            {
            Q1 = Q1 + 1; // When 1 pound button clicked add 1 to number.
            Ptotal = Ptotal + 100; // When 1 pound button clicked add 100 to total money
            PenceTotal.Text = Ptotal.ToString(); // updates the total displayed in the GUI.
            q1_count.Text = Q1.ToString(); //updates the total number of coins label
            UpdateTotals(); // calls function to update totals on screen   
        }
    }
}
