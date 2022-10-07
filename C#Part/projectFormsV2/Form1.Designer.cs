using System.Data.SqlClient;

namespace projectFormsV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
           
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.updateProfileBtn = new System.Windows.Forms.Button();
            this.ShowAvailableBooksBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shareIdeasLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shareV3Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.buyBookBbt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // updateProfileBtn
            // 
            this.updateProfileBtn.Location = new System.Drawing.Point(665, 22);
            this.updateProfileBtn.Name = "updateProfileBtn";
            this.updateProfileBtn.Size = new System.Drawing.Size(104, 46);
            this.updateProfileBtn.TabIndex = 0;
            this.updateProfileBtn.Text = "Update Profile";
            this.updateProfileBtn.UseVisualStyleBackColor = true;
            // 
            // ShowAvailableBooksBtn
            // 
            this.ShowAvailableBooksBtn.Location = new System.Drawing.Point(146, 444);
            this.ShowAvailableBooksBtn.Name = "ShowAvailableBooksBtn";
            this.ShowAvailableBooksBtn.Size = new System.Drawing.Size(143, 31);
            this.ShowAvailableBooksBtn.TabIndex = 5;
            this.ShowAvailableBooksBtn.Text = "Show Available Books";
            this.ShowAvailableBooksBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(479, 327);
            this.dataGridView1.TabIndex = 7;
            // 
            // shareIdeasLbl
            // 
            this.shareIdeasLbl.AutoSize = true;
            this.shareIdeasLbl.Location = new System.Drawing.Point(10, 263);
            this.shareIdeasLbl.Name = "shareIdeasLbl";
            this.shareIdeasLbl.Size = new System.Drawing.Size(109, 15);
            this.shareIdeasLbl.TabIndex = 8;
            this.shareIdeasLbl.Text = "Search By Category";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 23);
            this.textBox1.TabIndex = 10;
            // 
            // shareV3Btn
            // 
            this.shareV3Btn.Location = new System.Drawing.Point(0, 0);
            this.shareV3Btn.Name = "shareV3Btn";
            this.shareV3Btn.Size = new System.Drawing.Size(75, 23);
            this.shareV3Btn.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update Profile ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show Available Books";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search By Category";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 263);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(660, 240);
            this.dataGridView2.TabIndex = 5;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(589, 0);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(92, 38);
            this.LogOutBtn.TabIndex = 6;
            this.LogOutBtn.Text = "Log Out ";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // buyBookBbt
            // 
            this.buyBookBbt.Location = new System.Drawing.Point(554, 206);
            this.buyBookBbt.Name = "buyBookBbt";
            this.buyBookBbt.Size = new System.Drawing.Size(118, 41);
            this.buyBookBbt.TabIndex = 7;
            this.buyBookBbt.Text = "Browse";
            this.buyBookBbt.UseVisualStyleBackColor = true;
            this.buyBookBbt.Click += new System.EventHandler(this.buyBookBbt_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(684, 506);
            this.Controls.Add(this.buyBookBbt);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "User ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updateProfileBtn;
        private Button ShowAvailableBooksBtn;
        private DataGridView dataGridView1;
        private Label shareIdeasLbl;
        private TextBox textBox1;
        private Button shareV3Btn;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Label label1;
        private DataGridView dataGridView2;
        private Button LogOutBtn;
        private Button buyBookBbt;
    }
}