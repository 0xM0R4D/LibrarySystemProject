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
    public partial class addBookFormV2 : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);
        public addBookFormV2()
        {
            InitializeComponent();
        }

        private void addBookSubmitBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Libarary_book (bookID, bookPrice , bookTitle , bookDesc , yearPublication , bookLanguage, NumberOfCopies, actualNumberOfCopies, categID, authID, pubID)" +
                                            " VALUES (@bookID,@bookPrice ,@bookTitle , @bookDesc , @yearPublication , @bookLanguage, @NumberOfCopies, @actualNumberOfCopies, @categID, @authID, @pubID ) ;";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@bookTitle", bookTitleTextBox.Text);
            cmd.Parameters.AddWithValue("@bookID", bookIDTextBox.Text);
            cmd.Parameters.AddWithValue("@bookPrice", bookPriceTextBox.Text);

            cmd.Parameters.AddWithValue("@bookDesc", bookDescTextBox.Text);
            cmd.Parameters.AddWithValue("@yearPublication", bookYearPubTextBox.Text);
            cmd.Parameters.AddWithValue("@bookLanguage", bookLangTextBox.Text);
            cmd.Parameters.AddWithValue("@NumberOfCopies", bookCopiesTextBox.Text);
            cmd.Parameters.AddWithValue("@actualNumberOfCopies", bookActualCopiesTextBox.Text);

            // @categID, @authID, @pubID 
            cmd.Parameters.AddWithValue("@categID", categIDtextBox.Text);
            cmd.Parameters.AddWithValue("@authID", authorIDtextBox.Text); 
            cmd.Parameters.AddWithValue("@pubID ", pubIDtextBox.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book saved");
            
        }

        private void bookBackToAdmin_Click(object sender, EventArgs e)
        {
            // back to admin form 
            this.Hide();
            adminForm af = new adminForm();

            af.Show();
        }
    }
}
