namespace databaseproject
{
    partial class browse
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
            this.board = new System.Windows.Forms.DataGridView();
            this.allBooks = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.board.Location = new System.Drawing.Point(20, 291);
            this.board.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(905, 215);
            this.board.TabIndex = 0;
            // 
            // allBooks
            // 
            this.allBooks.Location = new System.Drawing.Point(4, 24);
            this.allBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allBooks.Name = "allBooks";
            this.allBooks.Size = new System.Drawing.Size(208, 44);
            this.allBooks.TabIndex = 2;
            this.allBooks.Text = "All Available Books";
            this.allBooks.UseVisualStyleBackColor = true;
            this.allBooks.Click += new System.EventHandler(this.allBooks_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(13, 116);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(84, 39);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Write Comment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.allBooks);
            this.Controls.Add(this.board);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "browse";
            this.Text = "browse";
            this.Load += new System.EventHandler(this.browse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView board;
        public System.Windows.Forms.Button allBooks;
        public System.Windows.Forms.Button btnBuy;
        public Button button1;
    }
}