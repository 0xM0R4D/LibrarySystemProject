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
    public partial class browse : Form
    {
        static String sql = @"Data Source = DESKTOP-JOQ17FA\MSSQLSERVER2; Initial Catalog = LibraryDataBase; Integrated Security = True; Encrypt=True; TrustServerCertificate=True; User ID = ''; password= ''; ";
        SqlConnection con = new SqlConnection(sql);
        public browse()
        {
            InitializeComponent();
            
        }
        public DataTable bestseller_books()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Libarary_book order by NumberOfCopies";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable All_books()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Libarary_book";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


        private void bestBooks_Click(object sender, EventArgs e)
        {
            board.DataSource = bestseller_books();
        }

        private void allBooks_Click(object sender, EventArgs e)
        {
            board.DataSource = All_books();
            
        }

        // go to buy Form 
        private void btnBuy_Click(object sender, EventArgs e)
        {

            BuyForm obj = new BuyForm();
            obj.Show(); 
            /*
            con.Open();
            string Q = "UPDATE Libarary_book SET NumberOfCopies=NumberOfCopies-1 WHERE bookID=" + board.CurrentRow.Cells[0].Value + "";
            SqlCommand cmd = new SqlCommand(Q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DONE");
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not yer");
  
        }

        /*
        public DataTable showuser()
        {
            con.Open();
            DataTable dt = new DataTable();
          
            string query = "SELECT * FROM Libarary_user WHERE email=@em";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           // da.SelectCommand.Parameters.AddWithValue("@em", this.label1.Text);

            da.Fill(dt);
            con.Close();
            
            return dt;
        }*/

        private void browse_Load(object sender, EventArgs e)
        {
            /*
            this.board.DataSource = showuser();
           
            this.textBox1.Text = this.board.CurrentRow.Cells[0].Value.ToString();
            this.textBox2.Text = this.board.CurrentRow.Cells[1].Value.ToString();
            this.textBox3.Text = this.board.CurrentRow.Cells[2].Value.ToString();
            this.textBox4.Text = this.board.CurrentRow.Cells[3].Value.ToString();
            this.textBox5.Text = this.board.CurrentRow.Cells[4].Value.ToString();
           */
        }

        private void updateuserbtn_Click(object sender, EventArgs e)
        {
         
         /*   con.Open();

            string Q = "UPDATE Libarary_user SET fName=@fName , lName=@lName , country=@country , Address=@Address WHERE email=@em";
            SqlCommand cmd = new SqlCommand(Q, con);
            cmd.Parameters.AddWithValue("@fName", textBox1.Text);
            cmd.Parameters.AddWithValue("@lName", textBox2.Text);
            cmd.Parameters.AddWithValue("@country", textBox3.Text);
            cmd.Parameters.AddWithValue("@Address", textBox4.Text);
            cmd.Parameters.AddWithValue("@em", this.label1.Text.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("update saved");
           */ 
        }

        // write comment btn
        private void button1_Click_1(object sender, EventArgs e)
        {
            WriteComment writeComment = new WriteComment();
            writeComment.Show();

        }
    }
}
