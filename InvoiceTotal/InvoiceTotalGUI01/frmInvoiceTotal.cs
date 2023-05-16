using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotalGUI01
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal;
            decimal discountPercent = 0.1M;
            decimal discountAmount;
            decimal total;

            subtotal       = decimal.Parse(txtSubtotal.Text);
            discountAmount = subtotal * discountPercent;
            total          = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p");
            txtDiscountAmount.Text  = discountAmount.ToString("c");
            txtTotal.Text           = total.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text        = "";
            txtDiscountPercent.Text = "";
            txtDiscountAmount.Text  = "";
            txtTotal.Text           = "";
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

        private void btnCalculate_MouseEnter(object sender, EventArgs e)
        {
            //btnCalculate.BackColor = Color.Green;
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            //btnCalculate.BackColor = Color.LightGray;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            //btnClear.BackColor = Color.LightYellow;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            //btnClear.BackColor = Color.LightGray;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            //btnExit.BackColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            //btnExit.BackColor = Color.LightGray;
        }

        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To My Invoice Total GUI App!",
                            "WELCOME!!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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

        private void txtDiscountPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
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
