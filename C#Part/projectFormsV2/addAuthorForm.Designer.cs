namespace projectFormsV2
{
    partial class addAuthorForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.authorMailTextBox = new System.Windows.Forms.TextBox();
            this.authorAddressTextBox = new System.Windows.Forms.TextBox();
            this.authorIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.submitAddBookBtn = new System.Windows.Forms.Button();
            this.ABackToAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mail : ";
            // 
            // authorMailTextBox
            // 
            this.authorMailTextBox.Location = new System.Drawing.Point(138, 167);
            this.authorMailTextBox.Name = "authorMailTextBox";
            this.authorMailTextBox.Size = new System.Drawing.Size(141, 23);
            this.authorMailTextBox.TabIndex = 16;
            // 
            // authorAddressTextBox
            // 
            this.authorAddressTextBox.Location = new System.Drawing.Point(138, 122);
            this.authorAddressTextBox.Name = "authorAddressTextBox";
            this.authorAddressTextBox.Size = new System.Drawing.Size(141, 23);
            this.authorAddressTextBox.TabIndex = 17;
            // 
            // authorIDTextBox
            // 
            this.authorIDTextBox.Location = new System.Drawing.Point(138, 78);
            this.authorIDTextBox.Name = "authorIDTextBox";
            this.authorIDTextBox.Size = new System.Drawing.Size(141, 23);
            this.authorIDTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name : ";
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(138, 33);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(141, 23);
            this.authorNameTextBox.TabIndex = 12;
            // 
            // submitAddBookBtn
            // 
            this.submitAddBookBtn.Location = new System.Drawing.Point(138, 272);
            this.submitAddBookBtn.Name = "submitAddBookBtn";
            this.submitAddBookBtn.Size = new System.Drawing.Size(109, 52);
            this.submitAddBookBtn.TabIndex = 11;
            this.submitAddBookBtn.Text = "Submit";
            this.submitAddBookBtn.UseVisualStyleBackColor = true;
            this.submitAddBookBtn.Click += new System.EventHandler(this.submitAddBookBtn_Click);
            // 
            // ABackToAdmin
            // 
            this.ABackToAdmin.Location = new System.Drawing.Point(721, 0);
            this.ABackToAdmin.Name = "ABackToAdmin";
            this.ABackToAdmin.Size = new System.Drawing.Size(77, 28);
            this.ABackToAdmin.TabIndex = 20;
            this.ABackToAdmin.Text = "Back";
            this.ABackToAdmin.UseVisualStyleBackColor = true;
            this.ABackToAdmin.Click += new System.EventHandler(this.ABackToAdmin_Click);
            // 
            // addAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ABackToAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.authorMailTextBox);
            this.Controls.Add(this.authorAddressTextBox);
            this.Controls.Add(this.authorIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.submitAddBookBtn);
            this.Name = "addAuthorForm";
            this.Text = "Add Author";
            this.Load += new System.EventHandler(this.addAuthorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox authorMailTextBox;
        private TextBox authorAddressTextBox;
        private TextBox authorIDTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox authorNameTextBox;
        private Button submitAddBookBtn;
        private Button ABackToAdmin;
    }
}