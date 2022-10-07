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
    public partial class adminForm : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);
        public adminForm()
        {
            InitializeComponent();
        }

        private void AddPublisherBtn_Click(object sender, EventArgs e)
        {
            // go to add publisher form 

            this.Hide();
            addPublisherForm p = new addPublisherForm();
            //MessageBox.Show("add publisher");
            p.Show();
             
        }

        private void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            // go to add author form 
            this.Hide();
            addAuthorForm a = new addAuthorForm();
           
            a.Show();

        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            // go to add Book form 
            this.Hide();
            addBookFormV2 addBookF = new addBookFormV2();

            addBookF.Show();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();

            // -- book title that has max number of buyers
            string query = "select Libarary_book.bookTitle ,NumberOfCopies-actualNumberOfCopies as totalSales from libarary_book where Libarary_book.NumberOfCopies - Libarary_book.actualNumberOfCopies = (select max(y.totalBookSold) as MaxTotalBookSold from(select bookTitle, (NumberOfCopies - actualNumberOfCopies) as totalBookSold from Libarary_book ) y );  ";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            dataGridView2.DataSource = dt ; 
            
            con.Close(); 


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            // -- book title that had not any buyers last month
            string query = "select bookTitle from Libarary_book where bookID not in (select distinct BID from Buying_details where  LEFT({fn monthname(transactionDate)},3) = 'May' and year(transactionDate)='2022');";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();





            // Get the number of authors whose books hadn`t any buyers during last month.
            // select authorName , authorID from Author where authorID in (select authID from Libarary_book where bookID not in (select distinct BID from Buying_details where  LEFT({fn monthname(transactionDate)},3) = 'May' and year(transactionDate)='2022'));  
            string query = "select authorName , authorID from Author where authorID in (select authID from Libarary_book where bookID not in (select distinct BID from Buying_details where  LEFT({fn monthname(transactionDate)},3) = 'May' and year(transactionDate)='2022')); ";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();

            // -- the name and id of author who didnt upload any books

            string query = "select authorName, authorID from Author where authorID not in (select distinct authID from Libarary_book );";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {


            //            --name and number of books in the category with the min number of books

            string query = "select categName, y.booksCategory from(select categName, count(bookID) as booksCategory from Libarary_book right join Category on categID = categoryID  group by categName )y where y.booksCategory = (select min(z.booksInCategory) as minBooks from(select categName, count(bookID) as booksInCategory from Libarary_book right join Category on categID = categoryID group by categName)z) ;";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            // -- information of each user and the number of books he/she bought
            
            string query = "select Libarary_user.* , y.numberOFBooks from Libarary_user ,  (select email, count(userEmail) as numberOFBooks from Libarary_user left join Buying_details on userEmail = email group by email)y where Libarary_user.email = y.email order by numberOFBooks desc;";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();

        }

        private void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            // go to update profile form 

            UpdateProfileForm updateObj = new UpdateProfileForm();
            updateObj.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            // search by category 

            // string query = "select bookTitle, bookDesc, bookLanguage, bookPrice, yearPublication, NumberOfCopies, actualNumberOfCopies, categName, authorName, publisherName from Libarary_book, Category, Author, Publisher where categID = categoryID and authorID = authID and publisherID = pubID and categName = ' category name you type in the search bar'; ";

            string query = "select bookTitle, bookDesc, bookLanguage, bookPrice, yearPublication, NumberOfCopies, actualNumberOfCopies, categName, authorName, publisherName from Libarary_book, Category, Author, Publisher where categID = categoryID and authorID = authID and publisherID = pubID and categName = @cateNameSearch ; " ;

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@cateNameSearch", SearchTextBox.Text); 

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            
            sda.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void showAvailableBooksBtn_Click(object sender, EventArgs e)
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

        private void LogOut2Btn_Click(object sender, EventArgs e)
        {
            // go to log in form 
            this.Hide();
            logInForm logInObj = new logInForm();
            logInObj.Show();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
           // logInForm logInObj = new logInForm();
            //logInObj.Show();
        }

        private void buyBookBbt_Click(object sender, EventArgs e)
        {
            browse browseObj = new browse();
            browseObj.Show();
        }
    }
}
