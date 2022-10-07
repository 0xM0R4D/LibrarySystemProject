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

namespace projectFormsV2
{
    public partial class logInForm : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);


        public logInForm()
        {
            InitializeComponent();
        }

        private void logInForm_Load(object sender, EventArgs e)
        {

        }

        // sign in Btn
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select role from Libarary_user Where email='" + email.Text + "'", con);
            DataTable dt = new System.Data.DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select loginPassword from Libaray_login Where loginEmail='" + email.Text + "' and loginPassword='" + password.Text + "'   ", con);
            DataTable dtpassword = new System.Data.DataTable();


            sda.Fill(dt);
            sda2.Fill(dtpassword);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["role"] as string)
                {
                    case "admin":
                        {
                           //  this.Hide();

                            // MessageBox.Show("admin");
                            if (dtpassword.Rows.Count == 1) // valid password
                            {
                                MessageBox.Show("Dear admin, you loged in successfully");
                                adminForm adminObj = new adminForm();
                               
                                this.Visible = false;
                                this.Hide();
                                adminObj.Show();

                                // AdminMenu ss = new AdminMenu();
                                //ss.Show();
                                //     AdminForm a = new AdminForm();
                                //this.Visible = false;
                                //   a.Show();
                            }
                            else if (dtpassword.Rows.Count == 0)    // invalid password
                            {
                                MessageBox.Show("wrong password, PLz, enter the correct password .");

                            }
                            break;
                        }

                    case "user":
                        {
                            //this.Hide();

                            //  MessageBox.Show("user");

                            if (dtpassword.Rows.Count == 1)
                            {
                                MessageBox.Show("Dear user, you logged in successfully");
                                

                                this.Hide();
                                Form1 userForm = new Form1();
                                userForm.Show();

                                //  b.label1.Text = this.email.Text.ToString();
                                //    b.label2.Text = this.password.Text.ToString();
                                //   userForm.label1.Text = this.email.Text.ToString();
                                // userForm.label2.Text = this.password.Text.ToString();

                            }
                            else if (dtpassword.Rows.Count == 0)
                            {
                                MessageBox.Show("wrong, PLz, sign up firstly.");
                            }
                            break;
                        }

                }
            }
            else if (dt.Rows.Count == 0)
            {
                // this.Hide();
                //signup s = new signup();
                MessageBox.Show("Email is wrong...you can sign up, firstly.");
                //s.Show();
            }
        }


        // sign up Btn
        private void button2_Click(object sender, EventArgs e)
        {
            signup signUpObj = new signup();
            signUpObj.Show();

            //databaseproject.signup s = new databaseproject.signup();

        }
    }
}
