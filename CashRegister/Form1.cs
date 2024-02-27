using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double rugbyBallPrice = 49.99;
        double rugbyCleatsPrice = 79.99;
        double rugbyJerseyPrice = 89.99;

        int rugbyBallPurchased = 0;
        int rugbyCleatsPurchased = 0;
        int rugbyJerseyPurchased = 0;

        double rugbyBallTotal = 0;
        double rugbyCleatsTotal = 0;
        double rugbyJerseyTotal = 0;

        double subTotal = 0;
        double taxRate = 0.13;
        double totalTax = 0;
        double totalCost = 0;

        int totalTendered = 0;
        double changeDue = 0;

        // Using int instead of double so that only full numbers can be used
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        { // Clear recipt
            reciptLabel.Text = "";
            try // Check if rugby ball input is number
            {
                rugbyBallPurchased = Convert.ToInt32(rugbyBallInput.Text);
                
                if (rugbyBallPurchased < 0)
                {
                    rugbyBallInput.Text = "0";
                    rugbyBallPurchased = 0;
                }
            }     
            catch
            {
                rugbyBallInput.Text = "0";
                rugbyBallPurchased = 0;
                this.Refresh();
            }

            try // Check if rugby cleats input is number
            {
                rugbyCleatsPurchased = Convert.ToInt32(rugbyCleatsInput.Text);

                if (rugbyCleatsPurchased < 0)
                {
                    rugbyCleatsInput.Text = "0";
                    rugbyCleatsPurchased = 0;
                }
            }
            catch
            {
                rugbyCleatsInput.Text = "0";
                rugbyCleatsPurchased = 0;
                this.Refresh();
            }

            try // Check if rugby jersey input is number
            {
                rugbyJerseyPurchased = Convert.ToInt32(rugbyJerseyInput.Text);

                if (rugbyJerseyPurchased < 0)
                {
                    rugbyJerseyInput.Text = "0";
                    rugbyJerseyPurchased = 0;
                }
            }
            catch
            {
                rugbyJerseyInput.Text = "0";
                rugbyJerseyPurchased = 0;
                this.Refresh();
            }

            // Set a maximum of 9999 purchase
            if (rugbyBallPurchased > 9999)
            {
                rugbyBallPurchased = 9999;
                rugbyBallInput.Text = "9999";
                this.Refresh();
            }
            if (rugbyCleatsPurchased > 9999)
            {
                rugbyCleatsPurchased = 9999;
                rugbyCleatsInput.Text = "9999";
                this.Refresh();
            }
            if (rugbyJerseyPurchased > 9999)
            {
                rugbyJerseyPurchased = 9999;
                rugbyJerseyInput.Text = "9999";
                this.Refresh();
            }

            // Calculation stuff
            rugbyBallTotal = rugbyBallPrice * rugbyBallPurchased;
            rugbyCleatsTotal = rugbyCleatsPrice * rugbyCleatsPurchased;
            rugbyJerseyTotal = rugbyJerseyPrice * rugbyJerseyPurchased;

            subTotal = rugbyBallTotal + rugbyCleatsTotal + rugbyJerseyTotal;
            totalTax = subTotal * taxRate;
            totalCost = totalTax + subTotal;

            subtotalOutput.Text = $"{subTotal.ToString("C")}";
            taxOutput.Text = $"{totalTax.ToString("C")}";
            totalOutput.Text = $"{totalCost.ToString("C")}";

            changeButton.Enabled = true;

            // Check if all purchases are 0
            if (rugbyBallPurchased == 0)
            {
                if (rugbyCleatsPurchased == 0)
                {
                    if (rugbyJerseyPurchased == 0)
                    {
                        reciptLabel.Text = "\n\nWhy would you buy nothing?";
                        changeButton.Enabled = false;

                        subtotalOutput.Text = $"";
                        taxOutput.Text = $"";
                        totalOutput.Text = $"";
                    }
                }
            }


        }

        private void changeButton_Click(object sender, EventArgs e)
        { // Clear recipt
            reciptLabel.Text = "";
            try // Check to see if tendered input is a number
            {
                totalTendered = Convert.ToInt32(tenderedInput.Text);               
            }
            catch 
            {
                reciptLabel.Text = $"\n\n\n {tenderedInput.Text}";
                reciptLabel.Text += "\nSomething is wrong with that.";
                reciptLabel.Text += "\nMake it a whole number or an actual number.";

                tenderedInput.Text = "";
                this.Refresh();

                totalTendered = 0;
                printButton.Enabled = false;
            }

            // Change calculation
            changeDue = totalTendered - totalCost;

            // Check that user is paying enough
            if (changeDue < 0)
            {
                reciptLabel.Text += "\n\n\nIncrease amount tendered!";
            }
            else
            {
                changeOutput.Text = $"{changeDue.ToString("C")}";
                reciptLabel.Text = "";

                printButton.Enabled = true;
                reciptLabel.Text = "";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        { // Clears recipt and gets ready to print text
            reciptLabel.Text = "";
            reciptNameLabel.Text = "Rugby Shop";
            Thread.Sleep(1000);
            this.Refresh();
            reciptLabel.Text = "\n\n";

            if (rugbyBallPurchased > 0) // Check if rugby balls where purchased
            {
                reciptLabel.Text += $"\nRugby Balls X{rugbyBallPurchased} @ {rugbyBallTotal.ToString("C")}";
                Thread.Sleep(1000);
                this.Refresh();
            }
            
            if (rugbyCleatsPurchased > 0) // Check if rugby cleats where purchased
            {
                reciptLabel.Text += $"\nRugby Cleats X{rugbyCleatsPurchased} @ {rugbyCleatsTotal.ToString("C")}";
                Thread.Sleep(1000);
                this.Refresh();
            }
            
            if (rugbyJerseyPurchased > 0) // Check if rugby jerseys where purchased
            {
                reciptLabel.Text += $"\nRugby Jerseys X{rugbyJerseyPurchased} @ {rugbyJerseyTotal.ToString("C")}";
                Thread.Sleep(1000);
                this.Refresh();
            }
            
            // Print other importat stuff
            reciptLabel.Text += $"\n\nSubtotal   {subTotal.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            reciptLabel.Text += $"\nTax   {totalTax.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            reciptLabel.Text += $"\nTotal   {totalCost.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();

            reciptLabel.Text += $"\n\nTendered   {totalTendered.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();
            reciptLabel.Text += $"\nChange   {changeDue.ToString("C")}";
            Thread.Sleep(1000);
            this.Refresh();

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        { // Resets everything
            reciptLabel.Text = "";
            rugbyBallInput.Text = "";
            rugbyCleatsInput.Text = "";
            rugbyJerseyInput.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Text = "";
            changeOutput.Text = "";
            reciptLabel.Text = "";
            reciptNameLabel.Text = "";

            rugbyBallPurchased = 0;
            rugbyCleatsPurchased = 0;
            rugbyJerseyPurchased = 0;

            rugbyBallTotal = 0;
            rugbyCleatsTotal = 0;
            rugbyJerseyTotal = 0;

            subTotal = 0;
            totalTax = 0;
            totalCost = 0;

            totalTendered = 0;
            changeDue = 0;

            printButton.Enabled = false;
            changeButton.Enabled = false;



        }

        private void rugbyBallCount_Click(object sender, EventArgs e)
        {

        }

        private void pricesButton_Click(object sender, EventArgs e)
        { // Displays prices
            reciptNameLabel.Text = "Rugby Shop";
            reciptLabel.Text = $"\n\n\nRugby Balls - {rugbyBallPrice.ToString("C")}";
            reciptLabel.Text += $"\nPairs of Rugby Cleats - {rugbyCleatsPrice.ToString("C")}";
            reciptLabel.Text += $"\nRugby Jerseys - {rugbyJerseyPrice.ToString("C")}";
        }
    }
}
