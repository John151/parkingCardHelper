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

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /* Calculate the number of days of parking, and any remaining credit,
             * for an amount of credit added to a campus card */

            bool creditValid = Double.TryParse(txtCreditAdded.Text, out double creditAdded); //Inline variable 
            bool costOneParkWithCardValid = Double.TryParse(txtOneParkWithCard.Text, out double costOneParkWithCard);

            if (creditValid && costOneParkWithCardValid) //checks to see if both are True
            {
                //calculate number of times user can park and how much if any credit is left over
                int daysParking = (int)(creditAdded / costOneParkWithCard);
                double creditRemaining = creditAdded % costOneParkWithCard;

                txtDaysParking.Text = daysParking.ToString();  //setting txtdaysparking to string
                txtCreditRemaining.Text = creditRemaining.ToString("c");
            }
            else
            { MessageBox.Show("please enter numbers", "Error");
            }
        }

        private void txtSavings_TextChanged(object sender, EventArgs e)
        {
            bool daysParkingValid = Double.TryParse(txtDaysParking.Text, out double daysParking);
                
                )
            double txtSavings = int daysParking * double(txtOneParkNoCard - txtOneParkWithCard);
            txtSavings.Text = txtSavings.ToString("c");
            

        }
    }
}
