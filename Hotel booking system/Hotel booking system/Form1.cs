using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntcalculate_Click(object sender, EventArgs e)
        {
            // Creating variables
            string guestName = txtname.Text.Trim();
            int age, nights, guests;
            double roomRate = 0;
            double roomCost, breakfastCost = 0;
            double subtotal, discount = 0;
            double seniorDiscount = 0;
            double serviceCharge = 0;
            double total;

            string roomType = "";
            int maxGuests = 0;

            // Validate guest name
            if (guestName == "")
            {
                MessageBox.Show("Guest name cannot be empty.");
                txtname.Focus();
                return;
            }

            // Validate numeric inputs using TryParse
            if (!int.TryParse(txtage.Text, out age))
            {
                MessageBox.Show("Please enter a valid guest age.");
                txtage.Focus();
                return;
            }

            if (!int.TryParse(txtnights.Text, out nights))
            {
                MessageBox.Show("Please enter a valid number of nights.");
                txtnights.Focus();
                return;
            }

            if (!int.TryParse(txtnumber.Text, out guests))
            {
                MessageBox.Show("Please enter a valid number of guests.");
                txtnumber.Focus();
                return;
            }

            // Validate age
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.");
                return;
            }

            // Validate nights
            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.");
                return;
            }

            // Validate number of guests
            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.");
                return;
            }

            // Determine room type, rate and capacity
            switch (true)
            {
                case true when rdnstandard.Checked:
                    roomType = "Standard";
                    roomRate = 50;
                    maxGuests = 2;
                    break;

                case true when rdnnormal.Checked:
                    roomType = "Normal";
                    roomRate = 80;
                    maxGuests = 4;
                    break;

                case true when rdnhight.Checked:
                    roomType = "Hight";
                    roomRate = 130;
                    maxGuests = 6;
                    break;

                default:
                    MessageBox.Show("Please select a room type.");
                    return;
            }

            // Boolean flag for booking approval
            bool bookingApproved = true;

            if (guests > maxGuests)
            {
                bookingApproved = false;
            }

            if (!bookingApproved)
            {
                MessageBox.Show(
                    "Booking rejected! " + roomType +
                    " room can accommodate a maximum of " +
                    maxGuests + " guests."
                );
                return;
            }

            // Calculate room cost
            roomCost = roomRate * nights;

            // Breakfast cost: $10 per guest per night
            if (checkbreak.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            // Calculate subtotal
            subtotal = roomCost + breakfastCost;

            // Length-of-stay discount
            if (nights >= 10)
            {
                discount = subtotal * 0.12;
            }
            else if (nights >= 5)
            {
                discount = subtotal * 0.05;
            }

            double amountAfterDiscount = subtotal - discount;

            // Additional senior discount for age 60 or above
            if (age >= 60)
            {
                seniorDiscount = amountAfterDiscount * 0.05;
            }

            double amountAfterSeniorDiscount =
                amountAfterDiscount - seniorDiscount;

            // 5% service surcharge for more than 4 guests
            if (guests > 4)
            {
                serviceCharge = amountAfterSeniorDiscount * 0.05;
            }

            // Final total
            total = amountAfterSeniorDiscount + serviceCharge;

            // Display booking details
            lstBookingDetails.Items.Clear();

            lstBookingDetails.Items.Add("HOTEL ROOM BOOKING DETAILS");
            lstBookingDetails.Items.Add("----------------------------");
            lstBookingDetails.Items.Add("Guest Name: " + guestName);
            lstBookingDetails.Items.Add("Guest Age: " + age);
            lstBookingDetails.Items.Add("Number of Nights: " + nights);
            lstBookingDetails.Items.Add("Number of Guests: " + guests);
            lstBookingDetails.Items.Add("Room Type: " + roomType);
            lstBookingDetails.Items.Add("Room Cost: $" + roomCost.ToString("0.00"));
            lstBookingDetails.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("0.00"));
            lstBookingDetails.Items.Add("Discount: $" + discount.ToString("0.00"));
            lstBookingDetails.Items.Add("Senior Discount: $" + seniorDiscount.ToString("0.00"));
            lstBookingDetails.Items.Add("Service Charge: $" + serviceCharge.ToString("0.00"));
            lstBookingDetails.Items.Add("FINAL TOTAL: $" + total.ToString("0.00"));
            lstBookingDetails.Items.Add("Booking Status: APPROVED");
            //lstBookingDetails.Text =
            //    "HOTEL ROOM BOOKING DETAILS\r\n" +
            //    "================================\r\n" +
            //    "Guest Name: " + txtname + "\r\n" +
            //    "Guest Age: " + txtage + "\r\n" +
            //    "Number of Nights: " + nights + "\r\n" +
            //    "Number of Guests: " + guests + "\r\n" +
            //    "Room Type: " + roomType + "\r\n" +
            //    "Room Rate Per Night: $" +
            //    roomRate.ToString("0.00") + "\r\n" +
            //    "Room Cost: $" + roomCost.ToString("0.00") + "\r\n" +
            //    "Breakfast Cost: $" +
            //    breakfastCost.ToString("0.00") + "\r\n" +
            //    "Subtotal: $" + subtotal.ToString("0.00") + "\r\n" +
            //    "Stay Discount: $" + discount.ToString("0.00") + "\r\n" +
            //    "Senior Discount: $" +
            //    seniorDiscount.ToString("0.00") + "\r\n" +
            //    "Service Charge: $" +
            //    serviceCharge.ToString("0.00") + "\r\n" +
            //    "================================\r\n" +
            //    "FINAL TOTAL: $" + total.ToString("0.00") +
            //    "\r\nBooking Status: APPROVED";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtnights.Clear();
            txtnumber.Clear();
            lstBookingDetails.Text = "";

            rdnstandard.Checked = false;
            rdnnormal.Checked = false;
            rdnhight.Checked = false;
            checkbreak.Checked = false;

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
            txtnights.Clear();
            txtnumber.Clear();
            lstBookingDetails.Text = "";

            rdnstandard.Checked = false;
            rdnnormal.Checked = false;
            rdnhight.Checked = false;
            checkbreak.Checked = false;

            txtname.Focus();
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
