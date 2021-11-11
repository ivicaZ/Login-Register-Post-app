using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivica\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Login]([Username],[Password]) VALUES ('"+user.Text+"','"+pass.Text+"')",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Success");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
