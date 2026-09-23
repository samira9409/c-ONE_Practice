using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {

            //creating variable
            string studentname, studentofdepartment, studentofsemester, fullDate;
            int studentid;
            //assign variable
            studentname = txtname.Text;
             studentid = int.Parse(txtstudentid.Text);
            studentofdepartment = txtdepartment.Text;
            studentofsemester = txtsemester.Text;

            //process
            fullDate = studentname + "," + studentid + "," + studentofdepartment + "," + studentofsemester;
            //display
            lbloutput.Text = fullDate;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear
            txtname.Text = " ";
            txtstudentid.Clear();
            txtdepartment.Text = string.Empty;
            txtsemester.Text = string.Empty;
            lbloutput.Text = string.Empty;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //this Close();
            this.Close();
        }
    }
}