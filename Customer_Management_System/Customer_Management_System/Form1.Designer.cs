namespace Customer_Management_System
{
    partial class Form1
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.chkPremium = new System.Windows.Forms.CheckBox();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.chkNewCustomer = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelName.Location = new System.Drawing.Point(147, 68);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "NAME:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(147, 107);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(92, 16);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "PASSWORD :";
            this.labelPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(147, 149);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(71, 16);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "GENDER :";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(147, 190);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(88, 16);
            this.labelCat.TabIndex = 3;
            this.labelCat.Text = "CATEGORY :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(246, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(246, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(303, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(246, 149);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(64, 20);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "MALE";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(368, 149);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(81, 20);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "FEMALE";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(509, 149);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(76, 20);
            this.rbOther.TabIndex = 8;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "OTHER";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Location = new System.Drawing.Point(246, 189);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(94, 20);
            this.chkRegular.TabIndex = 9;
            this.chkRegular.Text = "REGULAR";
            this.chkRegular.UseVisualStyleBackColor = true;
            // 
            // chkPremium
            // 
            this.chkPremium.AutoSize = true;
            this.chkPremium.Location = new System.Drawing.Point(388, 190);
            this.chkPremium.Name = "chkPremium";
            this.chkPremium.Size = new System.Drawing.Size(92, 20);
            this.chkPremium.TabIndex = 10;
            this.chkPremium.Text = "PREMIUM";
            this.chkPremium.UseVisualStyleBackColor = true;
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(246, 235);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(99, 20);
            this.chkDiscount.TabIndex = 11;
            this.chkDiscount.Text = "DISCOUNT";
            this.chkDiscount.UseVisualStyleBackColor = true;
            // 
            // chkNewCustomer
            // 
            this.chkNewCustomer.AutoSize = true;
            this.chkNewCustomer.Location = new System.Drawing.Point(388, 235);
            this.chkNewCustomer.Name = "chkNewCustomer";
            this.chkNewCustomer.Size = new System.Drawing.Size(141, 20);
            this.chkNewCustomer.TabIndex = 12;
            this.chkNewCustomer.Text = "NEW CUSTOMER";
            this.chkNewCustomer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(73, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(221, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(368, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(509, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(669, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkNewCustomer);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.chkPremium);
            this.Controls.Add(this.chkRegular);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.CheckBox chkPremium;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.CheckBox chkNewCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

