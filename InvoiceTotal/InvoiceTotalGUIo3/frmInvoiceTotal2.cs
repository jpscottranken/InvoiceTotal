using System;
using System.Threading;
using System.Windows.Forms;

namespace InvoiceTotalGUIo3
{
    public partial class frmInvoiceTotal2 : Form
    {
        const decimal DISCOUNTPERCENT = 0.25M;
        public frmInvoiceTotal2()
        {
            InitializeComponent();
        }

        //  Declare and initialize class variables
        int numberOfInvoices    = 0;
        decimal totalOfInvoices = 0m;
        decimal avgOfInvoices   = 0m;

        private void frmInvoiceTotal2_Load(object sender, EventArgs e)
        {
            //txtDiscountPct.Text = DISCOUNTPERCENT.ToString("p");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  result holds the value of the Decimal.TryParse
            bool result;

            // Declare and initialize remaining program variables
            decimal subtotal;
            decimal discountPct = .25m;
            decimal discountAmt;
            decimal invoiceTotal;

            //  Attempt to convert value in txtEnterSubtotal
            //  to a Decimal. If successful, put value into subtotal
            result = Decimal.TryParse(txtEnterSubtotal.Text, out subtotal);

            //  if not successful, print out a MessageBox,
            //  clear out textbox, set focus to textbox.
            if (!result)        //  if (result == false)
            {
                MessageBox.Show("Input was blank or non-numeric",
                                "INVALID INPUT",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEnterSubtotal.Text = "";
                txtEnterSubtotal.Focus();
                return;
            }
            //  if 0 or negative subtototal, print out a MessageBox,
            //  clear out textbox, set focus to textbox.
            else if (subtotal <= 0)
            {
                MessageBox.Show("Input was 0 or negative",
                                "ZERO OR NEGATIVE INPUT",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEnterSubtotal.Text = "";
                txtEnterSubtotal.Focus();
                return;
            }

            //  With a positive subtotal, calculate all
            //  remaining values and put into associated textboxes
            discountAmt = Math.Round(subtotal * discountPct, 2);
            invoiceTotal = Math.Round(subtotal - discountAmt, 2);

            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            //  Add 1 to total number invoices
            numberOfInvoices++;

            //  Add current invoice total to running invoice total
            totalOfInvoices += invoiceTotal;

            //  Update average invoice total
            avgOfInvoices = totalOfInvoices / numberOfInvoices;


            //  put values into associated textboxes
            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtAvgOfInvoices.Text = avgOfInvoices.ToString("c");

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnterSubtotal.Text = "";
            txtSubtotal.Text = "";
            txtDiscountAmt.Text = "";
            txtTotal.Text = "";
            txtEnterSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
