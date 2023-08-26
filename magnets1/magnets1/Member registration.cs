using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magnets1
{
    public partial class Member_registration : Form
    {
        public Member_registration()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Member_registration_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            this.Hide();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Home obj = new Home();
            this.Hide();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           membershipdetails obj = new membershipdetails();
            this.Hide();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
          Member_registration obj = new Member_registration();
            this.Hide();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            membershipdetails obj = new membershipdetails();
            this.Hide();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            membershipdetails obj = new membershipdetails();
            this.Hide();
            obj.Show();
        }
    }
}
