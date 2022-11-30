using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoanApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(string username, string passwordD)
        {
            InitializeComponent();

            usernamePassTextBox.Text = username + " " + passwordD; //pass to the screen welcome form

            var datasource = new List<Loantype>();
            datasource.Add(new Loantype() { Name = "Personal Loan", Value = "personal" });
            datasource.Add(new Loantype() { Name = "Home Loan", Value = "home" });
            datasource.Add(new Loantype() { Name = "Vehicle", Value = "vehicle" });

            this.cbLoanType.DataSource = datasource;
            this.cbLoanType.DisplayMember = "Name";
            this.cbLoanType.ValueMember = "Value";

            this.cbLoanType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSaveLoan_Click(object sender, EventArgs e)
        {
            double loanfee = Convert.ToDouble(txtLoanFee.Text);
            double interest = 0;
            int month = Convert.ToInt32(txtMonths.Text);
            if (cbLoanType.SelectedIndex == 0)
            {
                interest = loanfee * 0.05 * month;
            }
            else if (cbLoanType.SelectedIndex == 1)
            {
                interest = loanfee * 0.1 * month;
            }
            else if (cbLoanType.SelectedIndex == 2)
            {
                interest = loanfee * 0.15 * month;
            }

            txtTotalLoan.Text = Convert.ToString(loanfee + interest);
            txtInterestRate.Text = Convert.ToString(interest);
            MessageBox.Show("Your Total Loan Amount is R " + txtTotalLoan.Text);
        }
    }

    public class Loantype
    {
        public string Name { get; set; } = default!;
        public string Value { get; set; } = default!;
    }
}
