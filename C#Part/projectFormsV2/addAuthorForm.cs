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
    public partial class addAuthorForm : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);


        public addAuthorForm()
        {
            InitializeComponent();
        }

        //submitAddAuthorBtn
        // old name for submitAddAuthorBtn: submitAddBookBtn_Click


        // submit add author button
        private void submitAddBookBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Author (authorID, authorName, authorAddress, authorEmail)" +
                                      " VALUES (@authorID, @authorName, @authorAddress, @authorEmail);";



            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@authorID", authorIDTextBox.Text);
            cmd.Parameters.AddWithValue("@authorName", authorNameTextBox.Text);
            cmd.Parameters.AddWithValue("@authorAddress", authorAddressTextBox.Text);
            cmd.Parameters.AddWithValue("@authorEmail", authorMailTextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Author saved");

        }

        private void ABackToAdmin_Click(object sender, EventArgs e)
        {
            // back to admin form 
            this.Hide();
            adminForm af = new adminForm();

            af.Show();
        }

        private void addAuthorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
