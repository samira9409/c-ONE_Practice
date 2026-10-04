using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating variable

            double hours_worked, payrate, grosspay , Validation;
            //PreviewKeyDownEventArgs exception data
            if(double.TryParse(txthoursework.Text,out Validation)& double.TryParse(txthourlypay.Text,out Validation))
           {
                //assigning variable
                hours_worked=double.Parse(txthoursework.Text);
                payrate=double.Parse(txthourlypay.Text);

                //check validation
                if (hours_worked > 0 & payrate > 0)
                {
                    //calculate the gross pay

                    grosspay = hours_worked * payrate;
                    lblgrossbay.Text = grosspay.ToString();

                }
                else {
                    MessageBox.Show("hours worked or payrate must be greater than 0");
                }
                
            }
            else
            {
                MessageBox.Show("txthours,txtpayrate onlyaccept double or int");
            }
        }
    }
}
