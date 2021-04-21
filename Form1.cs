using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futureValue2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
    

private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int years = Convert.ToInt32(txtNumberOfyears.Text);
            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = this.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
            txtFutureValue.Text = futureValue.ToString("c2");
            txtMonthlyInvestment.Focus();

        }
          private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int a = 0; a < months; a++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMonthlyInvestment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
