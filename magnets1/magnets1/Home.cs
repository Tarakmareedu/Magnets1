using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace magnets1
{
    public partial class Home : Form
    {
        private SqlCommand cmd;
        private DataSet dataTable;

        public Home()
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

        private void label1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            this.Hide();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var connectionString = "Data Source=SYSTEMS13-PC\\SQLSERVER;Initial Catalog=MAGNETSDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Table_1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch
            { MessageBox.Show("not successful"); }
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAGNETSDBDataSet1.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.mAGNETSDBDataSet1.Table_1);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var connectionString = "Data Source=SYSTEMS13-PC\\SQLSERVER;Initial Catalog=MAGNETSDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(id) as Members from Table_1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;

                con.Close();
            }
            catch
            { MessageBox.Show("not successful"); }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table_1TableAdapter.FillBy(this.mAGNETSDBDataSet1.Table_1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
