using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace projectFormsV2
{
    public partial class addPublisherForm : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);
        public addPublisherForm()
        {
            InitializeComponent();
        }


        // label for phone publisher 
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitAddPublisherBtn_Click(object sender, EventArgs e)
        {

            
            con.Open();
            string query = "INSERT INTO Publisher (publisherID, publisherName, publisherAddress, publisherPhone, publisherEmail)" +
                                      " VALUES (@publisherID, @publisherName, @publisherAddress, @publisherPhone, @publisherEmail);";



            SqlCommand cmd = new SqlCommand(query, con);

            
            cmd.Parameters.AddWithValue("@publisherID", publisherIDTextBox.Text);
            cmd.Parameters.AddWithValue("@publisherName", publisherNameTextBox1.Text);
            cmd.Parameters.AddWithValue("@publisherAddress", publisherAddressTextBox.Text);
            cmd.Parameters.AddWithValue("@publisherPhone", PublisherPhoneTextBox.Text);
            cmd.Parameters.AddWithValue("@publisherEmail", publisherMailTextBox.Text);
            

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Publisher saved");
            
            
        }

        private void pubBackToAdmin_Click(object sender, EventArgs e)
        {
            // back to admin form 
            this.Hide();
            adminForm af = new adminForm();

            af.Show();
        }

        private void addPublisherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
