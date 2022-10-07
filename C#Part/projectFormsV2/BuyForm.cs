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
using databaseproject;
using projectFormsV2;

namespace projectFormsV2
{
    public partial class BuyForm : Form
    {


        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);


        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {

        }

        // confirm buying 
        private void button2_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string Q = "UPDATE Libarary_book SET actualNumberOfCopies=actualNumberOfCopies-1 WHERE bookID = @BID  ; insert into Buying_details (userEmail, BID)" +
                                               " VALUES (@userEmail, @BID) ; ";
            SqlCommand cmd = new SqlCommand(Q, con);

            cmd.Parameters.AddWithValue("@BID", bIDTextBox.Text);
            cmd.Parameters.AddWithValue("@userEmail", mailTextBox.Text);

            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("DONE");
            

        }

        private void bIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
