using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket
{
    public partial class Form1 : Form
    {
        const decimal TicketPrice = 100m;
        const decimal InsurancePrice = 25m;

        bool bookingApproved = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bntcalculate_Click(object sender, EventArgs e)
        {
            bookingApproved = false;
            lstAirlinebookigdetails.Items.Clear();

            string passengerName = txtname.Text.Trim();

            if (passengerName == "")
            {
                MessageBox.Show("Please enter passenger name.");
                txtname.Focus();
                return;
            }

            int age;
            int numberOfTickets;
            decimal baggageWeight;

            if (!int.TryParse(txtage.Text, out age))
            {
                MessageBox.Show("Please enter a valid passenger age.");
                txtage.Focus();
                return;
            }

            if (!int.TryParse(txttickers.Text,
                              out numberOfTickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                txttickers.Focus();
                return;
            }

            if (!decimal.TryParse(txtweight.Text,
                                  out baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                txtweight.Focus();
                return;
            }

            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100 years.");
                return;
            }

            if (numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.");
                return;
            }

            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show(
                    "Baggage weight must be between 0 and 50 kg per passenger.");
                return;
            }

            string travelClass;

            if (rdnfirst.Checked)
            {
                travelClass = "First Class";

                if (age < 12)
                {
                    MessageBox.Show(
                        "Passengers below 12 years cannot book First Class.");
                    return;
                }
            }
            else if (rdnnormal.Checked)
            {
                travelClass = "Normal Class";
            }
            else if (rdnbusiness.Checked)
            {
                travelClass = "Business Class";
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Calculate the basic ticket cost
            decimal basicCost = TicketPrice * numberOfTickets;

            // Calculate the ticket quantity discount
            decimal discountRate = 0m;

            if (numberOfTickets >= 3 && numberOfTickets <= 4)
            {
                discountRate = 0.05m;
            }
            else if (numberOfTickets == 5)
            {
                discountRate = 0.10m;
            }

            // Apply the age discount
            if (age < 12)
            {
                discountRate += 0.20m;
            }
            else if (age >= 60)
            {
                discountRate += 0.10m;
            }

            decimal discountAmount = basicCost * discountRate;
            decimal totalAfterDiscount = basicCost - discountAmount;

            // Add travel insurance if selected
            decimal insuranceCost = 0m;

            if (checktravel.Checked)
            {
                insuranceCost = InsurancePrice * numberOfTickets;
            }

            decimal finalTotal = totalAfterDiscount + insuranceCost;

            // Approve the booking after all validations pass
            bookingApproved = true;

            // Display booking details
            lstAirlinebookigdetails.Items.Add("AIRLINE BOOKING DETAILS");
            lstAirlinebookigdetails.Items.Add("------------------------------");
            lstAirlinebookigdetails.Items.Add("Passenger Name: " + passengerName);
            lstAirlinebookigdetails.Items.Add("Passenger Age: " + age);
            lstAirlinebookigdetails.Items.Add("Number of Tickets: " + numberOfTickets);
            lstAirlinebookigdetails.Items.Add("Travel Class: " + travelClass);
            lstAirlinebookigdetails.Items.Add("Baggage Weight: " +
                                        baggageWeight + " kg per passenger");
            lstAirlinebookigdetails.Items.Add("Ticket Price: $" + TicketPrice.ToString("F2"));
            lstAirlinebookigdetails.Items.Add("Basic Ticket Cost: $" + basicCost.ToString("F2"));
            lstAirlinebookigdetails.Items.Add("Discount: $" + discountAmount.ToString("F2"));
            lstAirlinebookigdetails.Items.Add("Insurance: $" + insuranceCost.ToString("F2"));

            if (baggageWeight <= 20)
            {
                lstAirlinebookigdetails.Items.Add("Baggage Charge: Free");
            }
            else
            {
                lstAirlinebookigdetails.Items.Add(
                    "Baggage: Above 20 kg free allowance");
            }

            lstAirlinebookigdetails.Items.Add("------------------------------");
            lstAirlinebookigdetails.Items.Add("Final Total: $" + finalTotal.ToString("F2"));
            lstAirlinebookigdetails.Items.Add("Booking Approved: " + bookingApproved);

            MessageBox.Show("Booking calculated successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txttickers.Clear();
            txtweight.Clear();

            rdnfirst.Checked = false;
            rdnnormal.Checked = false;
            rdnbusiness.Checked = false;

            checktravel.Checked = false;

            lstAirlinebookigdetails.Items.Clear();

            bookingApproved = false;

            txtname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txttickers.Clear();
            txtweight.Clear();

            rdnfirst.Checked = false;
            rdnnormal.Checked = false;
            rdnbusiness.Checked = false;

            checktravel.Checked = false;

            lstAirlinebookigdetails.Items.Clear();

            bookingApproved = false;

            txtname.Focus();
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
