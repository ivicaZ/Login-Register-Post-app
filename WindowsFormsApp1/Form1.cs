using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool isValid()
        {if (txtUsername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Invalid username", "Error");
                return false;
            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Invalid password", "Error");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid()) {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivica\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True")) {
                    string query = "SELECT * FROM Login WHERE Username ='" + txtUsername.Text.Trim() + "' AND Password ='" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        Form form2 = new Form2(txtUsername.Text);
                        this.Hide();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password or username", "Error");

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
