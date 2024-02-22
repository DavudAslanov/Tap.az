using Azure.Core.Pipeline;
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
using Tap.az.DB;

namespace Tap.az
{
    public partial class Base : Form
    {
        SqlConnection connection = new SqlConnection(DBWorker.conString);
        public Base()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login next = new Login();
            next.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                string script = @"INSERT INTO Announcement(Category,City,Price,Subject,Name,Email,Contact,Phone)
                            VALUES(@category,@city,@price,@subject,@name,@email,@contact,@phone)";
                SqlCommand cmd = new SqlCommand(script,connection);
                cmd.Parameters.AddWithValue("@category", comboBox1.Text);
                cmd.Parameters.AddWithValue("@city", comboBox2.Text);
                cmd.Parameters.AddWithValue("@price", textBox1.Text);
                cmd.Parameters.AddWithValue("@subject", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@contact", comboBox3.Text);
                cmd.Parameters.AddWithValue("@phone", maskedTextBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Elan Elave edildi");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
            
          

        }
    }
}
