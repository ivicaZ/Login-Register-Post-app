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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivica\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");

        string userName;
        public Form2(string user)
        {  
           userName = user;
            InitializeComponent();

        }
        public class ClassName
        {
            public string Username { get; set; }
            public string Post { get; set; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }   
        int Count = 0;
        private void post_Click(object sender, EventArgs e)
        {
            if (postText.Text != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Table1 ]([Username],[Post]) VALUES ('" + userName + "','" + postText.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Count++;
                for (int i = 0; i < Count; i++)
                {
                    Label lblDynamic = new Label();
                    this.Controls.Add(lblDynamic);
                    lblDynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblDynamic.ForeColor = System.Drawing.SystemColors.Desktop;
                    lblDynamic.Location = new System.Drawing.Point(Left, Top);
                    lblDynamic.Name = "lblDynamic";
                    lblDynamic.Size = new System.Drawing.Size(500, 80);
                    lblDynamic.Text = postText.Text;
                    lblDynamic.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    Top += 80;
                    Count--;
                }
            }
            else { MessageBox.Show("insert post"); }
            
        }

        private void postText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

       
   
     