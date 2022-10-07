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
    public partial class UpdateProfileForm : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);

        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void updateuserbtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string Q = "UPDATE Libarary_user SET fName=@fName , lName=@lName , country=@country , Address=@Address WHERE email=@em" ;
            SqlCommand cmd = new SqlCommand(Q, con);
            cmd.Parameters.AddWithValue("@fName", textBox1.Text);
            cmd.Parameters.AddWithValue("@lName", textBox2.Text);
            cmd.Parameters.AddWithValue("@country", textBox3.Text);
            cmd.Parameters.AddWithValue("@Address", textBox4.Text);
            //cmd.Parameters.AddWithValue("@em", this.label1.Text.ToString()); // mark 
           
            cmd.Parameters.AddWithValue("@em", textBox5.Text); // mark 

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("update saved");
        }
    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
