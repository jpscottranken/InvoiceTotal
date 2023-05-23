using System;
using System.Windows.Forms;

namespace InvoiceTotalGUI02b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPct = 0m;
            if (subtotal >= 500)
            {
                discountPct = 0.2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPct = 0.15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPct = 0.1m;
            }

            decimal discountAmt  = subtotal * discountPct;
            decimal invoiceTotal = subtotal - discountAmt;

            txtDiscountPct.Text  = discountPct.ToString("p1");
            txtDiscountAmt.Text  = discountAmt.ToString("c");
            txtTotal.Text        = invoiceTotal.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text    = "";
            txtDiscountPct.Text = "";
            txtDiscountAmt.Text = "";
            txtTotal.Text       = "";
            txtSubtotal.Focus();
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

        private void lblDiscountAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblDiscountPercent_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountPct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscountAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
