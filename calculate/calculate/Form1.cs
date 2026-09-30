using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            /// Creating Variables
            string customerName;
            double previousReading, currentReading, pricePerUnit, electricityUsage,
                   electricityCharge, taxAmount, totalBill;

            // Constant Variables
            const double taxPercentage = 0.07;
            const double fixedCharge = 5;

            // Assigning Variables
            customerName = txtCustomer.Text;
            previousReading = double.Parse(txtPrevious.Text);
            currentReading = double.Parse(txtCurrent.Text);
            pricePerUnit = double.Parse(txtUnitPrice.Text);

            // Calculating Electricity Usage
            electricityUsage = currentReading - previousReading;

            // Calculating Electricity Charge
            electricityCharge = electricityUsage * pricePerUnit;

            // Calculating Tax Amount
            taxAmount = electricityCharge * taxPercentage;

            // Calculating Total Bill
            totalBill = electricityCharge + taxAmount + fixedCharge;

            // Displaying Results
            lblUsage.Text = electricityUsage.ToString("0");
            lblTax.Text = "$" + taxAmount.ToString("0.00");
            lblTotal.Text = "$" + totalBill.ToString("0.00");
        }
    }
}
