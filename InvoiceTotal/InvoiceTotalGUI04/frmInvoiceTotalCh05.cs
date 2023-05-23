using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotalGUI04
{
    public partial class frmInvoiceTotalCh05 : Form
    {
        public frmInvoiceTotalCh05()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string  customerType = txtCustomerType.Text;
            decimal subtotal = 0m;
            decimal discountPct = 0m;

            subtotal = Convert.ToDecimal(txtSubtotal.Text);
            discountPct = .0m;

            switch (customerType)
            {
                case "R":
                    if (subtotal < 100)
                    {
                        discountPct = .0m;
                    }
                    else if ((subtotal >= 100) && (subtotal < 250))
                    {
                        discountPct = .1m;
                    }

                    else if (subtotal >= 250)
                    {
                        discountPct = .25m;
                    }

                    break;

                case "C":
                    if (subtotal < 250)
                    {
                        discountPct = .2m;
                    }
                    else
                    {
                        discountPct = .3m;
                    }

                    break;

                default:
                    discountPct = .4m;
                    break;
            }

            //  Calculate totals
            decimal discountAmt = Math.Round(subtotal * discountPct, 2);
            decimal invoiceTotal = Math.Round(subtotal - discountAmt, 2);

            //  Display all outputs
            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerType.Text = "";
            txtSubtotal.Text     = "";
            txtDiscountPct.Text  = "";
            txtDiscountAmt.Text  = "";
            txtTotal.Text        = "";
            txtCustomerType.Focus();
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
