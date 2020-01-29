using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkingCardHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /* Calculate the number of days of parking, and any remaining credit,
             * for an amount of credit added to a campus card */

            bool creditValid = Double.TryParse(txtCreditAdded.Text, out double creditAdded); //Inline variable 
            bool costOneParkWithCardValid = Double.TryParse(txtOneParkWithCard.Text, out double costOneParkWithCard);
            bool costOneParkWithoutCardValid = Double.TryParse(txtOneParkNoCard.Text, out double costOneParkNoCard);


            if (creditValid && costOneParkWithCardValid && costOneParkWithoutCardValid) //checks to see if all are True
            {
                //calculate number of times user can park and how much if any credit is left over
                int daysParking = (int)(creditAdded / costOneParkWithCard);
                double creditRemaining = creditAdded % costOneParkWithCard;
                //calculates total savings
                double savings = daysParking * (costOneParkNoCard - costOneParkWithCard);

                txtDaysParking.Text = daysParking.ToString();  //setting txtdaysparking to string
                txtCreditRemaining.Text = creditRemaining.ToString("c");
                txtSavings.Text = savings.ToString();


            }
            else
            { MessageBox.Show("please enter numbers", "Error");
            }
        }

        private void txtSavings_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOneParkNoCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreditRemaining_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreditAdded_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
