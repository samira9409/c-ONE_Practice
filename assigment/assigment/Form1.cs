using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtdayofmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdayofweek_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            string dayoftheweek, dayofmonth, month, year, showdata;
            dayoftheweek = txtdayofweek.Text;
            month = txtmonth.Text;
            dayofmonth = txtdayofmonth.Text;
            year = txtyear.Text;
            showdata = dayoftheweek + " " + month + " " + dayofmonth + " " + year;
            lbldataoutput.Text = showdata;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdayofweek.Clear();
            txtmonth.Clear();
            txtdayofmonth.Clear();
            txtyear.Clear();
            lbldataoutput.Text = " ";
        }
    }
}
