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
    public partial class membershipdetails : Form
    {
        public membershipdetails()
        {
            InitializeComponent();
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
            Member_registration obj = new Member_registration();
            this.Hide();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           Home obj = new Home();
            this.Hide();
            obj.Show();
        }
    }
}
