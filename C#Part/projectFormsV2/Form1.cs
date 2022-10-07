using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data; 
using Microsoft.Data.SqlClient;
using databaseproject;  


namespace projectFormsV2
{
    public partial class Form1 : Form
    {

        // Data Source=DESKTOP-JOQ17FA\MSSQLSERVER2;Initial Catalog=LibraryDataBase;Integrated Security=True
        //  String sql = "Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; User ID = ''; password= ''; " ;

        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);
        

        public Form1()
        {
            InitializeComponent();
        }

       
        /*
        // search by category button 
        private void shareV3Btn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Libarary_user (fName , lName , Country , email , Address)  VALUES (@fName , @lName , @Country , @email , @Address) ; INSERT INTO Libaray_login ( loginEmail , loginPassword) VALUES (@email , @password)";
            SqlCommand cmd = new SqlCommand(query, con);
          
          

        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // search btn 
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            // search by category 

            // string query = "select bookTitle, bookDesc, bookLanguage, bookPrice, yearPublication, NumberOfCopies, actualNumberOfCopies, categName, authorName, publisherName from Libarary_book, Category, Author, Publisher where categID = categoryID and authorID = authID and publisherID = pubID and categName = ' category name you type in the search bar'; ";

            

            string query = "select bookTitle, bookDesc, bookLanguage, bookPrice, yearPublication, NumberOfCopies, actualNumberOfCopies, categName, authorName, publisherName from Libarary_book, Category, Author, Publisher where categID = categoryID and authorID = authID and publisherID = pubID and categName = @cateNameSearch ; ";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@cateNameSearch", textBox2.Text);


            
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        // show available books btn 
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            // show available books 
            
            string query = "select bookTitle, bookDesc, bookLanguage, bookPrice, yearPublication, NumberOfCopies, actualNumberOfCopies, categName, authorName, publisherName from Libarary_book, Category, Author, Publisher where categID = categoryID and authorID = authID and publisherID = pubID ; ";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();

        }

        // update profile btn 
        private void button1_Click(object sender, EventArgs e)
        {
            // go to update profile form 
            UpdateProfileForm updateObj = new UpdateProfileForm();
            updateObj.Show(); 

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            //   go to logIn form 
            this.Hide();
            logInForm logInObj = new logInForm() ;
            logInObj.Show(); 
        }

        private void buyBookBbt_Click(object sender, EventArgs e)
        {
            browse browseObj = new browse();
            browseObj.Show();
        }

        //public DataTable 
    }
}
/*con.Open();
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
*/


/* solve for connection error 
 Data Source=localhost; 
Initial Catalog=<YOUR DATABASE HERE>; 
Integrated Security=True; 
Encrypt=True; 
TrustServerCertificate=True; 
User Instance=False
 */