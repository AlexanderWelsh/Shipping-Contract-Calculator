//Program 3
//CIS-199-50
//Due 11/9/2023
//By: A1029
//This program computes the contracted price of shiping based on the provider, business, and length of contract. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateBut_Click(object sender, EventArgs e)
        {
            double[] percentageDiscountRate = { 0.22, 0.18, 0.19, 0.20 }; //Creates a list of discounts related to the provider.
            int[] initialContractPrice = { 50000, 85000, 60000, 75000, 95000, 55000 }; //Creates a list of base prices related to the business.
            int[] additionalDiscount = { 0, 0, 10000, 1000, 1000, 20000, 20000, 20000, 30000, 30000, 30000 }; //Creates a list of whole discounts related to the length of contract.

            //declairing variables.
            int contractLength;
            double selectedBusinessPrice = 0.0;
            double selectedDiscountRate = 0.0;
            double companyDiscount = 0;
            int lengthDiscount = 0;
            double finalPriceTotal = 0;

            if (providerBox.SelectedIndex >= 0) //checks if the user selected a provider.
            {
                selectedDiscountRate = percentageDiscountRate[providerBox.SelectedIndex]; //creates a discount rate by finding its related discount in the percentageDiscountRate index.
                
                if (businessBox.SelectedIndex >= 0) //checks if the user selected a business.
                {
                    selectedBusinessPrice = initialContractPrice[businessBox.SelectedIndex]; //creates a base rate by finding its related rate in the initialContractPrice index.
                    companyDiscount = selectedBusinessPrice * selectedDiscountRate; //mulltiplys the base price by the discount to find the company discount.

                    if (int.TryParse(contractLengthBox.Text, out contractLength)) //checks if the user selected a contract length.
                    {
                        if (contractLength > 0 && contractLength <= 10) //checks if the contract length is inbetween 1-10.
                        {
                            lengthDiscount = additionalDiscount[contractLength]; //finds the length discount by related it to the additional discount array with the user entered contract length.
                        }
                    }
                    //All elses ask the user to enter proper inforamtion
                    else
                    {
                        MessageBox.Show("Please enter a valid integer for Contract length. (1-10)");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a business");
                }
            }
            else
            {
                MessageBox.Show("Please select a Provider");
            }

            //finds the final price with all the previous data
            finalPriceTotal = selectedBusinessPrice - companyDiscount - lengthDiscount;

            //prints the final data in dollar form as a string
            shippingProviderBox.Text = providerBox.Text;
            initialContractPriceBox.Text = selectedBusinessPrice.ToString("C2");
            companyDiscountBox.Text = companyDiscount.ToString("C2");
            lengthDiscountBox.Text = lengthDiscount.ToString("C2");
            finalPriceBox.Text = finalPriceTotal.ToString("C2");
        }

        private void contractLengthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void businessBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void providerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tittle_Click(object sender, EventArgs e)
        {

        }
    }
}
