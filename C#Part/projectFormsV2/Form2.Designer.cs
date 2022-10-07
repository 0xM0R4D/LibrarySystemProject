namespace projectFormsV2
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpdateProfileBtn = new System.Windows.Forms.Button();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.AddAuthorBtn = new System.Windows.Forms.Button();
            this.AddPublisherBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.showAvailableBooksBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.LogOut2Btn = new System.Windows.Forms.Button();
            this.buyBookBbt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateProfileBtn
            // 
            this.UpdateProfileBtn.Location = new System.Drawing.Point(695, 39);
            this.UpdateProfileBtn.Name = "UpdateProfileBtn";
            this.UpdateProfileBtn.Size = new System.Drawing.Size(108, 31);
            this.UpdateProfileBtn.TabIndex = 0;
            this.UpdateProfileBtn.Text = "Update Profile";
            this.UpdateProfileBtn.UseVisualStyleBackColor = true;
            this.UpdateProfileBtn.Click += new System.EventHandler(this.UpdateProfileBtn_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(716, 97);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(79, 49);
            this.AddBookBtn.TabIndex = 1;
            this.AddBookBtn.Text = "Add Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // AddAuthorBtn
            // 
            this.AddAuthorBtn.Location = new System.Drawing.Point(716, 163);
            this.AddAuthorBtn.Name = "AddAuthorBtn";
            this.AddAuthorBtn.Size = new System.Drawing.Size(79, 48);
            this.AddAuthorBtn.TabIndex = 2;
            this.AddAuthorBtn.Text = "Add Author";
            this.AddAuthorBtn.UseVisualStyleBackColor = true;
            this.AddAuthorBtn.Click += new System.EventHandler(this.AddAuthorBtn_Click);
            // 
            // AddPublisherBtn
            // 
            this.AddPublisherBtn.Location = new System.Drawing.Point(716, 228);
            this.AddPublisherBtn.Name = "AddPublisherBtn";
            this.AddPublisherBtn.Size = new System.Drawing.Size(79, 44);
            this.AddPublisherBtn.TabIndex = 3;
            this.AddPublisherBtn.Text = "Add Publisher";
            this.AddPublisherBtn.UseVisualStyleBackColor = true;
            this.AddPublisherBtn.Click += new System.EventHandler(this.AddPublisherBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(132, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(663, 218);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search By Category :";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(5, 300);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(121, 23);
            this.SearchTextBox.TabIndex = 8;
            // 
            // showAvailableBooksBtn
            // 
            this.showAvailableBooksBtn.Location = new System.Drawing.Point(12, 385);
            this.showAvailableBooksBtn.Name = "showAvailableBooksBtn";
            this.showAvailableBooksBtn.Size = new System.Drawing.Size(114, 41);
            this.showAvailableBooksBtn.TabIndex = 7;
            this.showAvailableBooksBtn.Text = "Show Available Books";
            this.showAvailableBooksBtn.UseVisualStyleBackColor = true;
            this.showAvailableBooksBtn.Click += new System.EventHandler(this.showAvailableBooksBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(34, 329);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(92, 25);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Get the most interesting book title that has the max number of buyers.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Get the book title that hadn`t any buyers last month.  ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Get the number of authors whose books hadn`t any buyers during last month.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Go";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Get the authors who didn`t upload any books yet.";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Go";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Get the category with minimum number of books.";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(435, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Go";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "For each reader, retrieve all his info. and the number of books he bought.";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(435, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Go";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LogOut2Btn
            // 
            this.LogOut2Btn.Location = new System.Drawing.Point(695, 4);
            this.LogOut2Btn.Name = "LogOut2Btn";
            this.LogOut2Btn.Size = new System.Drawing.Size(108, 31);
            this.LogOut2Btn.TabIndex = 23;
            this.LogOut2Btn.Text = "Log Out ";
            this.LogOut2Btn.UseVisualStyleBackColor = true;
            this.LogOut2Btn.Click += new System.EventHandler(this.LogOut2Btn_Click);
            // 
            // buyBookBbt
            // 
            this.buyBookBbt.Location = new System.Drawing.Point(554, 6);
            this.buyBookBbt.Name = "buyBookBbt";
            this.buyBookBbt.Size = new System.Drawing.Size(112, 29);
            this.buyBookBbt.TabIndex = 24;
            this.buyBookBbt.Text = "Browse";
            this.buyBookBbt.UseVisualStyleBackColor = true;
            this.buyBookBbt.Click += new System.EventHandler(this.buyBookBbt_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 524);
            this.Controls.Add(this.buyBookBbt);
            this.Controls.Add(this.LogOut2Btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.showAvailableBooksBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.AddPublisherBtn);
            this.Controls.Add(this.AddAuthorBtn);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.UpdateProfileBtn);
            this.Name = "adminForm";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UpdateProfileBtn;
        private Button AddBookBtn;
        private Button AddAuthorBtn;
        private Button AddPublisherBtn;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox SearchTextBox;
        private Button showAvailableBooksBtn;
        private Button searchBtn;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button3;
        private Label label5;
        private Button button4;
        private Label label6;
        private Button button5;
        private Label label7;
        private Button button6;
        private Button LogOut2Btn;
        private Button buyBookBbt;
    }
}