using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tap.az.DB;

namespace Tap.az
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(DBWorker.conString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void getall()
        {
            try
            {
                connection.Open();
                string script = "SELECT * FROM Announcement";
                SqlCommand cmd = new SqlCommand(script, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            getall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string script = "SELECT * FROM Announcement WHERE Name=@name";
                SqlCommand command = new SqlCommand(script, connection);
                command.Parameters.AddWithValue("@name", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }
        }
        public void delete(int id)
        {

            try
            {
                connection.Open();
                string script = "DELETE  FROM Announcement WHERE ID=@id";
                SqlCommand command = new SqlCommand(script, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Ugurla silindi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);
                delete(id);
                getall();
            }
        }
        int i = 0;
        public void update(int id)
        {
            try
            {
                connection.Open();
                string script = @"UPDATE  Announcement SET Name=@name WHERE ID=@id ";
                //Categoty=@category,City=@city,Price=@price,Subject=@subject,Name=@name,
                //        Email=@email,Contact=@contact,Phone=@phone)";
                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@id", id);

                //cmd.Parameters.AddWithValue("@category", comboBox1.Text);
                //cmd.Parameters.AddWithValue("@city", comboBox2.Text);
                //cmd.Parameters.AddWithValue("@price", textBox1.Text);
                //cmd.Parameters.AddWithValue("@subject", richTextBox1.Text);
                //cmd.Parameters.AddWithValue("@name", textBox2.Text);
                //cmd.Parameters.AddWithValue("@email", textBox3.Text);
                //cmd.Parameters.AddWithValue("@contact", comboBox3.Text);
                //cmd.Parameters.AddWithValue("@phone", maskedTextBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Elan Derc edildi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);
                update(id);
                getall();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            textBox2.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
    }
}
