namespace Cafe_Order_Management_System
{
    partial class frmCustomer
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
            this.labCustomerDetails = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.cbRegular = new System.Windows.Forms.CheckBox();
            this.cbPremium = new System.Windows.Forms.CheckBox();
            this.cbNew = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCustomerDetails
            // 
            this.labCustomerDetails.AutoSize = true;
            this.labCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCustomerDetails.Location = new System.Drawing.Point(314, 69);
            this.labCustomerDetails.Name = "labCustomerDetails";
            this.labCustomerDetails.Size = new System.Drawing.Size(177, 25);
            this.labCustomerDetails.TabIndex = 0;
            this.labCustomerDetails.Text = "Customer Details";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(144, 162);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(69, 20);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name :";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumber.Location = new System.Drawing.Point(144, 228);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(138, 20);
            this.labNumber.TabIndex = 2;
            this.labNumber.Text = "Phone Number:";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGender.Location = new System.Drawing.Point(144, 290);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(82, 20);
            this.labGender.TabIndex = 3;
            this.labGender.Text = "Gender :";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labType.Location = new System.Drawing.Point(144, 359);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(175, 20);
            this.labType.TabIndex = 4;
            this.labType.Text = "Membership Type : ";
            this.labType.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 22);
            this.textBox2.TabIndex = 6;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(346, 291);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(474, 291);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(632, 291);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(60, 20);
            this.rbOther.TabIndex = 9;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // cbRegular
            // 
            this.cbRegular.AutoSize = true;
            this.cbRegular.Location = new System.Drawing.Point(346, 359);
            this.cbRegular.Name = "cbRegular";
            this.cbRegular.Size = new System.Drawing.Size(77, 20);
            this.cbRegular.TabIndex = 10;
            this.cbRegular.Text = "Regular";
            this.cbRegular.UseVisualStyleBackColor = true;
            // 
            // cbPremium
            // 
            this.cbPremium.AutoSize = true;
            this.cbPremium.Location = new System.Drawing.Point(474, 361);
            this.cbPremium.Name = "cbPremium";
            this.cbPremium.Size = new System.Drawing.Size(82, 20);
            this.cbPremium.TabIndex = 11;
            this.cbPremium.Text = "Premium";
            this.cbPremium.UseVisualStyleBackColor = true;
            // 
            // cbNew
            // 
            this.cbNew.AutoSize = true;
            this.cbNew.Location = new System.Drawing.Point(632, 361);
            this.cbNew.Name = "cbNew";
            this.cbNew.Size = new System.Drawing.Size(56, 20);
            this.cbNew.TabIndex = 12;
            this.cbNew.Text = "New";
            this.cbNew.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(243, 452);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(161, 42);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order Now";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Red;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(527, 452);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(161, 42);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(906, 535);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbNew);
            this.Controls.Add(this.cbPremium);
            this.Controls.Add(this.cbRegular);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labCustomerDetails);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCustomerDetails;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.CheckBox cbRegular;
        private System.Windows.Forms.CheckBox cbPremium;
        private System.Windows.Forms.CheckBox cbNew;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancle;
    }
}