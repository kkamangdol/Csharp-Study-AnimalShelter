namespace AnimalShelter
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
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CusDtailPanel = new System.Windows.Forms.Panel();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusNewPanel = new System.Windows.Forms.Panel();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CusDtailPanel.SuspendLayout();
            this.CusNewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(480, 638);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(297, 65);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusDtailPanel
            // 
            this.CusDtailPanel.Controls.Add(this.CusIsQualified);
            this.CusDtailPanel.Controls.Add(this.label2);
            this.CusDtailPanel.Controls.Add(this.CusDescription);
            this.CusDtailPanel.Controls.Add(this.label6);
            this.CusDtailPanel.Controls.Add(this.CusAddress);
            this.CusDtailPanel.Controls.Add(this.label5);
            this.CusDtailPanel.Controls.Add(this.CusAge);
            this.CusDtailPanel.Controls.Add(this.label4);
            this.CusDtailPanel.Controls.Add(this.CusFullName);
            this.CusDtailPanel.Controls.Add(this.label3);
            this.CusDtailPanel.Location = new System.Drawing.Point(1136, 131);
            this.CusDtailPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CusDtailPanel.Name = "CusDtailPanel";
            this.CusDtailPanel.Size = new System.Drawing.Size(264, 664);
            this.CusDtailPanel.TabIndex = 1;
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(163, 242);
            this.CusIsQualified.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(60, 25);
            this.CusIsQualified.TabIndex = 11;
            this.CusIsQualified.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "입양가능? :";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(163, 353);
            this.CusDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(60, 25);
            this.CusDescription.TabIndex = 9;
            this.CusDescription.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "설명 :";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(163, 297);
            this.CusAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(60, 25);
            this.CusAddress.TabIndex = 7;
            this.CusAddress.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "주소 :";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(163, 187);
            this.CusAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(60, 25);
            this.CusAge.TabIndex = 5;
            this.CusAge.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "나이 :";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(163, 127);
            this.CusFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(60, 25);
            this.CusFullName.TabIndex = 3;
            this.CusFullName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름 :";
            // 
            // CusNewPanel
            // 
            this.CusNewPanel.Controls.Add(this.CusNewFirstName);
            this.CusNewPanel.Controls.Add(this.CusNewBirthday);
            this.CusNewPanel.Controls.Add(this.CreateCustomer);
            this.CusNewPanel.Controls.Add(this.CusNewAddress);
            this.CusNewPanel.Controls.Add(this.CusNewDescription);
            this.CusNewPanel.Controls.Add(this.CusNewLastName);
            this.CusNewPanel.Controls.Add(this.label1);
            this.CusNewPanel.Controls.Add(this.label7);
            this.CusNewPanel.Controls.Add(this.label8);
            this.CusNewPanel.Controls.Add(this.label9);
            this.CusNewPanel.Controls.Add(this.label10);
            this.CusNewPanel.Location = new System.Drawing.Point(255, 52);
            this.CusNewPanel.Name = "CusNewPanel";
            this.CusNewPanel.Size = new System.Drawing.Size(837, 743);
            this.CusNewPanel.TabIndex = 2;
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(113, 102);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(150, 31);
            this.CusNewFirstName.TabIndex = 20;
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(113, 160);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(150, 31);
            this.CusNewBirthday.TabIndex = 19;
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(113, 212);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(621, 31);
            this.CusNewAddress.TabIndex = 18;
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(113, 268);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(621, 324);
            this.CusNewDescription.TabIndex = 17;
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(113, 45);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(150, 31);
            this.CusNewLastName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "생일 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "설명 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "주소 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "이름 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "성 :";
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 25;
            this.CustomerList.Location = new System.Drawing.Point(13, 52);
            this.CustomerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(224, 354);
            this.CustomerList.TabIndex = 3;
            this.CustomerList.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 852);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.CusNewPanel);
            this.Controls.Add(this.CusDtailPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDtailPanel.ResumeLayout(false);
            this.CusDtailPanel.PerformLayout();
            this.CusNewPanel.ResumeLayout(false);
            this.CusNewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CreateCustomer;
        private Panel CusDtailPanel;
        private Label CusFullName;
        private Label label3;
        private Label CusDescription;
        private Label label6;
        private Label CusAddress;
        private Label label5;
        private Label CusAge;
        private Label label4;
        private Label CusIsQualified;
        private Label label2;
        private Panel CusNewPanel;
        private TextBox CusNewFirstName;
        private TextBox CusNewBirthday;
        private TextBox CusNewAddress;
        private TextBox CusNewDescription;
        private TextBox CusNewLastName;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox CustomerList;
        private Button button1;
    }
}