namespace LoanApp
{
    partial class WelcomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.usernamePassTextBox = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLoanFee = new System.Windows.Forms.TextBox();
            this.txtTotalLoan = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.cbLoanType = new System.Windows.Forms.ComboBox();
            this.btnSaveLoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(346, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loan Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Loan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Months";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Interest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loan Type";
            // 
            // usernamePassTextBox
            // 
            this.usernamePassTextBox.Location = new System.Drawing.Point(305, 75);
            this.usernamePassTextBox.Name = "usernamePassTextBox";
            this.usernamePassTextBox.Size = new System.Drawing.Size(100, 23);
            this.usernamePassTextBox.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(305, 104);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 9;
            // 
            // txtLoanFee
            // 
            this.txtLoanFee.Location = new System.Drawing.Point(305, 133);
            this.txtLoanFee.Name = "txtLoanFee";
            this.txtLoanFee.Size = new System.Drawing.Size(100, 23);
            this.txtLoanFee.TabIndex = 10;
            // 
            // txtTotalLoan
            // 
            this.txtTotalLoan.Enabled = false;
            this.txtTotalLoan.Location = new System.Drawing.Point(305, 162);
            this.txtTotalLoan.Name = "txtTotalLoan";
            this.txtTotalLoan.Size = new System.Drawing.Size(100, 23);
            this.txtTotalLoan.TabIndex = 11;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(305, 196);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(100, 23);
            this.txtMonths.TabIndex = 12;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Enabled = false;
            this.txtInterestRate.Location = new System.Drawing.Point(305, 231);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 23);
            this.txtInterestRate.TabIndex = 13;
            // 
            // cbLoanType
            // 
            this.cbLoanType.FormattingEnabled = true;
            this.cbLoanType.Location = new System.Drawing.Point(305, 271);
            this.cbLoanType.Name = "cbLoanType";
            this.cbLoanType.Size = new System.Drawing.Size(121, 23);
            this.cbLoanType.TabIndex = 14;
            // 
            // btnSaveLoan
            // 
            this.btnSaveLoan.Location = new System.Drawing.Point(284, 343);
            this.btnSaveLoan.Name = "btnSaveLoan";
            this.btnSaveLoan.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLoan.TabIndex = 15;
            this.btnSaveLoan.Text = "Save Loan";
            this.btnSaveLoan.UseVisualStyleBackColor = true;
            this.btnSaveLoan.Click += new System.EventHandler(this.btnSaveLoan_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveLoan);
            this.Controls.Add(this.cbLoanType);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtTotalLoan);
            this.Controls.Add(this.txtLoanFee);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.usernamePassTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox usernamePassTextBox;
        private TextBox txtID;
        private TextBox txtLoanFee;
        private TextBox txtTotalLoan;
        private TextBox txtMonths;
        private TextBox txtInterestRate;
        private ComboBox cbLoanType;
        private Button btnSaveLoan;
    }
}