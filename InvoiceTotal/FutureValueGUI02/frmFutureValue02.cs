using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValueGUI02
{
    public partial class frmFutureValue02 : Form
    {
        public frmFutureValue02()
        {
            InitializeComponent();
        }

        //  Declare and initialize constants
        const decimal MININVESTMENT = 10m;
        const decimal MAXINVESTMENT = 100m;
        const decimal MININTRATE = 2m;
        const decimal MAXINTRATE = 10m;
        const int MINYEARS = 1;
        const int MAXYEARS = 25;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            decimal monthlyInvestment;
            decimal yearlyInterestRate;
            int years;

            keepGoing = ValidateMonthlyInvestment(out monthlyInvestment);

            if (keepGoing)
            {
                keepGoing = ValidateYearlyInterestRate(out yearlyInterestRate);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateNumberOfYears(out years);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateAndDisplayFutureValue(monthlyInvestment,
                                                yearlyInterestRate,
                                                years);
            }
            else
            {
                return;
            }
        }

        private bool ValidateMonthlyInvestment(out decimal monthlyInvestment)
        {
            bool result;
            bool retVal = true;
            result = Decimal.TryParse(txtMonthlyInvestment.Text,
                                      out monthlyInvestment);
            if (!result)
            {
                MessageBox.Show("Invalid Monthly Investment",
                                "INVALID INPUT",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtMonthlyInvestment.Text = "";
                txtMonthlyInvestment.Focus();

                retVal = false; ;
            }
            else if ((monthlyInvestment < MININVESTMENT) ||
                     (monthlyInvestment > MAXINVESTMENT))
            {
                MessageBox.Show("Monthly Investment Must Be Between $10 and $100",
                                "INVALID MONTHLY INVESTMENT AMOUNT",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtMonthlyInvestment.Text = "";
                txtMonthlyInvestment.Focus();

                retVal = false;
            }

            return retVal;
        }

        private bool ValidateYearlyInterestRate(out decimal yearlyInterestRate)
        {
            bool result;
            bool retVal = true;

            result = Decimal.TryParse(txtYearlyInterestRate.Text,
                                                  out yearlyInterestRate);
            if (!result)
            {
                MessageBox.Show("Invalid Yearly Interest Rate",
                                "INVALID YEARLY INTEREST RATE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtYearlyInterestRate.Text = "";
                txtYearlyInterestRate.Focus();

                retVal = false;
            }
            else if ((yearlyInterestRate < MININTRATE) ||
                     (yearlyInterestRate > MAXINTRATE))
            {
                MessageBox.Show("Yearly Interest Rate Must Be Between 2% and 10%",
                                "INVALID YEARLY INTEREST RATE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtYearlyInterestRate.Text = "";
                txtYearlyInterestRate.Focus();

                retVal = false;
            }

            return retVal;
        }

        private bool ValidateNumberOfYears(out int years)
        {
            bool result;
            bool retVal = true;

            result = Int32.TryParse(txtNumberOfYears.Text, out years);
            if (!result)
            {
                MessageBox.Show("Invalid Number Of Years",
                                "INVALID NUMBER OF YEARS",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtNumberOfYears.Text = "";
                txtNumberOfYears.Focus();

                retVal =  false;
            }
            else if ((years < MINYEARS) ||
                     (years > MAXYEARS))
            {
                MessageBox.Show("Number Of Years Must Be Between 1 and 25",
                                "INVALID NUMBER OF YEARS",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtNumberOfYears.Text = "";
                txtNumberOfYears.Focus();

                retVal = false;
            }

            return retVal;
        }

        private void CalculateAndDisplayFutureValue(decimal monthlyInvestment,
                                                    decimal yearlyInterestRate,
                                                    int years)
        {
            //  All input fields were valid
            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = 0m;

            for (int lcv = 0; lcv < months; ++lcv)
            {
                futureValue = (futureValue + monthlyInvestment) *
                          (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtMonthlyInvestment.Text = "";
            txtYearlyInterestRate.Text = "";
            txtNumberOfYears.Text = "";
            txtFutureValue.Text = "";
            txtMonthlyInvestment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
