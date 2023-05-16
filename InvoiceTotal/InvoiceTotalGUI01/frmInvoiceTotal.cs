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
    }
}
