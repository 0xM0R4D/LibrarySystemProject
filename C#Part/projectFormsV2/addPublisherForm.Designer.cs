namespace projectFormsV2
{
    partial class addPublisherForm
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
            this.publisherMailTextBox = new System.Windows.Forms.TextBox();
            this.publisherAddressTextBox = new System.Windows.Forms.TextBox();
            this.publisherIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.publisherNameTextBox1 = new System.Windows.Forms.TextBox();
            this.submitAddPublisherBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PublisherPhoneTextBox = new System.Windows.Forms.TextBox();
            this.pubBackToAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mail : ";
            // 
            // publisherMailTextBox
            // 
            this.publisherMailTextBox.Location = new System.Drawing.Point(169, 185);
            this.publisherMailTextBox.Name = "publisherMailTextBox";
            this.publisherMailTextBox.Size = new System.Drawing.Size(141, 23);
            this.publisherMailTextBox.TabIndex = 25;
            // 
            // publisherAddressTextBox
            // 
            this.publisherAddressTextBox.Location = new System.Drawing.Point(169, 140);
            this.publisherAddressTextBox.Name = "publisherAddressTextBox";
            this.publisherAddressTextBox.Size = new System.Drawing.Size(141, 23);
            this.publisherAddressTextBox.TabIndex = 26;
            // 
            // publisherIDTextBox
            // 
            this.publisherIDTextBox.Location = new System.Drawing.Point(169, 96);
            this.publisherIDTextBox.Name = "publisherIDTextBox";
            this.publisherIDTextBox.Size = new System.Drawing.Size(141, 23);
            this.publisherIDTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name : ";
            // 
            // publisherNameTextBox1
            // 
            this.publisherNameTextBox1.Location = new System.Drawing.Point(169, 51);
            this.publisherNameTextBox1.Name = "publisherNameTextBox1";
            this.publisherNameTextBox1.Size = new System.Drawing.Size(141, 23);
            this.publisherNameTextBox1.TabIndex = 21;
            // 
            // submitAddPublisherBtn
            // 
            this.submitAddPublisherBtn.Location = new System.Drawing.Point(169, 290);
            this.submitAddPublisherBtn.Name = "submitAddPublisherBtn";
            this.submitAddPublisherBtn.Size = new System.Drawing.Size(109, 52);
            this.submitAddPublisherBtn.TabIndex = 20;
            this.submitAddPublisherBtn.Text = "Submit";
            this.submitAddPublisherBtn.UseVisualStyleBackColor = true;
            this.submitAddPublisherBtn.Click += new System.EventHandler(this.submitAddPublisherBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PublisherPhoneTextBox
            // 
            this.PublisherPhoneTextBox.Location = new System.Drawing.Point(169, 230);
            this.PublisherPhoneTextBox.Name = "PublisherPhoneTextBox";
            this.PublisherPhoneTextBox.Size = new System.Drawing.Size(141, 23);
            this.PublisherPhoneTextBox.TabIndex = 29;
            this.PublisherPhoneTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pubBackToAdmin
            // 
            this.pubBackToAdmin.Location = new System.Drawing.Point(721, 1);
            this.pubBackToAdmin.Name = "pubBackToAdmin";
            this.pubBackToAdmin.Size = new System.Drawing.Size(77, 28);
            this.pubBackToAdmin.TabIndex = 31;
            this.pubBackToAdmin.Text = "Back";
            this.pubBackToAdmin.UseVisualStyleBackColor = true;
            this.pubBackToAdmin.Click += new System.EventHandler(this.pubBackToAdmin_Click);
            // 
            // addPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pubBackToAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PublisherPhoneTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.publisherMailTextBox);
            this.Controls.Add(this.publisherAddressTextBox);
            this.Controls.Add(this.publisherIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publisherNameTextBox1);
            this.Controls.Add(this.submitAddPublisherBtn);
            this.Name = "addPublisherForm";
            this.Text = "Add Publisher";
            this.Load += new System.EventHandler(this.addPublisherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox publisherMailTextBox;
        private TextBox publisherAddressTextBox;
        private TextBox publisherIDTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox publisherNameTextBox1;
        private Button submitAddPublisherBtn;
        private Label label5;
        private TextBox PublisherPhoneTextBox;
        private Button pubBackToAdmin;
    }
}