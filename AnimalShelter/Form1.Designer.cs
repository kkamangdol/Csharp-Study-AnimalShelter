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
            this.CusDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusDtailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(113, 35);
            this.CreateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(146, 51);
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
            this.CusDtailPanel.Location = new System.Drawing.Point(383, 12);
            this.CusDtailPanel.Name = "CusDtailPanel";
            this.CusDtailPanel.Size = new System.Drawing.Size(630, 487);
            this.CusDtailPanel.TabIndex = 1;
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(114, 216);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(39, 15);
            this.CusDescription.TabIndex = 9;
            this.CusDescription.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "설명:";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(114, 182);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(39, 15);
            this.CusAddress.TabIndex = 7;
            this.CusAddress.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "주소:";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(114, 112);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(39, 15);
            this.CusAge.TabIndex = 5;
            this.CusAge.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "나이:";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(114, 76);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(39, 15);
            this.CusFullName.TabIndex = 3;
            this.CusFullName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름:";
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(114, 146);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(39, 15);
            this.CusIsQualified.TabIndex = 11;
            this.CusIsQualified.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "입양가능?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 511);
            this.Controls.Add(this.CusDtailPanel);
            this.Controls.Add(this.CreateCustomer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDtailPanel.ResumeLayout(false);
            this.CusDtailPanel.PerformLayout();
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
    }
}