using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using databaseproject;
using projectFormsV2; 

namespace databaseproject
{
    public partial class signup : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);
        public signup()
        {
            InitializeComponent();
        }

        public void signup_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Libarary_user (fName , lName , Country , email , Address)  VALUES (@fName , @lName , @Country , @email , @Address) ; INSERT INTO Libaray_login ( loginEmail , loginPassword) VALUES (@email , @password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fName", fName.Text);
            cmd.Parameters.AddWithValue("@lName", lName.Text);
            cmd.Parameters.AddWithValue("@Country", Country.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@Address", Address.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sign Up succeeded, PLz, sign in  ");

            //loginForm logInFormObj = new logInForm();
            logInForm logObj = new logInForm();
            logObj.Show(); 
        }

        private void Country_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
 
         public void btnAdd_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("User saves");
            con.Open();
            string query = "INSERT INTO userform (username , password , email)  VALUES (@username , @password , @email)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User saves");
            dataGridView1.DataSource = LoadUserTable();
        }
 
 
 
 */