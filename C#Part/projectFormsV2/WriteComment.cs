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
    public partial class WriteComment : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);
        public WriteComment()
        {
            InitializeComponent();
        }

        // write btn
        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "INSERT INTO Comment_details (commentDesc, commentTime , userEmail , BID)" +
                                               " VALUES (@commentDesc, @commTime , @userEmail , @BID) ;";

            DateTime now = DateTime.Now; // capture the current time 

            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@commentDesc", comTextBox.Text);
            cmd.Parameters.AddWithValue("@userEmail", mailTextBox.Text);
            cmd.Parameters.AddWithValue("@BID", bIDTextBox.Text);
            cmd.Parameters.AddWithValue("@commTime", now);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Comment Saved");
        }

        private void WriteComment_Load(object sender, EventArgs e)
        {

        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
