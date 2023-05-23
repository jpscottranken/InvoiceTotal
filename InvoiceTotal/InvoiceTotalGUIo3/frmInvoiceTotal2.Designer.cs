namespace InvoiceTotalGUIo3
{
    partial class frmInvoiceTotal2
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtDiscountPct = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscountAmt = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAvgOfInvoices = new System.Windows.Forms.Label();
            this.lblTotalOfInvoices = new System.Windows.Forms.Label();
            this.lblNumberOfInvoices = new System.Windows.Forms.Label();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.txtAvgOfInvoices = new System.Windows.Forms.TextBox();
            this.txtNumberOfInvoices = new System.Windows.Forms.TextBox();
            this.lblEnterubtotal = new System.Windows.Forms.Label();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(51, 356);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(280, 41);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDiscountAmount.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.Location = new System.Drawing.Point(51, 280);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(280, 44);
            this.lblDiscountAmount.TabIndex = 14;
            this.lblDiscountAmount.Text = "Discount Amount:";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDiscountPercent.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercent.Location = new System.Drawing.Point(51, 202);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(280, 41);
            this.lblDiscountPercent.TabIndex = 13;
            this.lblDiscountPercent.Text = "Discount Percent:";
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSubtotal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(51, 119);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(280, 44);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscountPct
            // 
            this.txtDiscountPct.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPct.Location = new System.Drawing.Point(337, 199);
            this.txtDiscountPct.Name = "txtDiscountPct";
            this.txtDiscountPct.ReadOnly = true;
            this.txtDiscountPct.Size = new System.Drawing.Size(316, 44);
            this.txtDiscountPct.TabIndex = 5;
            this.txtDiscountPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(337, 353);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(316, 44);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiscountAmt
            // 
            this.txtDiscountAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountAmt.Location = new System.Drawing.Point(337, 280);
            this.txtDiscountAmt.Name = "txtDiscountAmt";
            this.txtDiscountAmt.ReadOnly = true;
            this.txtDiscountAmt.Size = new System.Drawing.Size(316, 44);
            this.txtDiscountAmt.TabIndex = 6;
            this.txtDiscountAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(337, 119);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(316, 44);
            this.txtSubtotal.TabIndex = 4;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1146, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 54);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(916, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 54);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(685, 347);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 54);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAvgOfInvoices
            // 
            this.lblAvgOfInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvgOfInvoices.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgOfInvoices.Location = new System.Drawing.Point(683, 275);
            this.lblAvgOfInvoices.Name = "lblAvgOfInvoices";
            this.lblAvgOfInvoices.Size = new System.Drawing.Size(280, 44);
            this.lblAvgOfInvoices.TabIndex = 18;
            this.lblAvgOfInvoices.Text = "Average Of Invoices:";
            this.lblAvgOfInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOfInvoices
            // 
            this.lblTotalOfInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalOfInvoices.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOfInvoices.Location = new System.Drawing.Point(683, 195);
            this.lblTotalOfInvoices.Name = "lblTotalOfInvoices";
            this.lblTotalOfInvoices.Size = new System.Drawing.Size(280, 41);
            this.lblTotalOfInvoices.TabIndex = 17;
            this.lblTotalOfInvoices.Text = "Total Of Invoices:";
            this.lblTotalOfInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberOfInvoices
            // 
            this.lblNumberOfInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNumberOfInvoices.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfInvoices.Location = new System.Drawing.Point(683, 113);
            this.lblNumberOfInvoices.Name = "lblNumberOfInvoices";
            this.lblNumberOfInvoices.Size = new System.Drawing.Size(280, 44);
            this.lblNumberOfInvoices.TabIndex = 16;
            this.lblNumberOfInvoices.Text = "Number Of Invoices:";
            this.lblNumberOfInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(969, 194);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(316, 44);
            this.txtTotalOfInvoices.TabIndex = 9;
            this.txtTotalOfInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvgOfInvoices
            // 
            this.txtAvgOfInvoices.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgOfInvoices.Location = new System.Drawing.Point(969, 275);
            this.txtAvgOfInvoices.Name = "txtAvgOfInvoices";
            this.txtAvgOfInvoices.ReadOnly = true;
            this.txtAvgOfInvoices.Size = new System.Drawing.Size(316, 44);
            this.txtAvgOfInvoices.TabIndex = 10;
            this.txtAvgOfInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(969, 114);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.ReadOnly = true;
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(316, 44);
            this.txtNumberOfInvoices.TabIndex = 8;
            this.txtNumberOfInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterubtotal
            // 
            this.lblEnterubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEnterubtotal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterubtotal.Location = new System.Drawing.Point(51, 32);
            this.lblEnterubtotal.Name = "lblEnterubtotal";
            this.lblEnterubtotal.Size = new System.Drawing.Size(280, 44);
            this.lblEnterubtotal.TabIndex = 11;
            this.lblEnterubtotal.Text = "Enter Subtotal:";
            this.lblEnterubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterSubtotal.Location = new System.Drawing.Point(337, 33);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(316, 44);
            this.txtEnterSubtotal.TabIndex = 0;
            this.txtEnterSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmInvoiceTotal2
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1346, 457);
            this.Controls.Add(this.lblEnterubtotal);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.lblAvgOfInvoices);
            this.Controls.Add(this.lblTotalOfInvoices);
            this.Controls.Add(this.lblNumberOfInvoices);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtAvgOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtDiscountPct);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmt);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmInvoiceTotal2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInvoiceTotal2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPct;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscountAmt;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAvgOfInvoices;
        private System.Windows.Forms.Label lblTotalOfInvoices;
        private System.Windows.Forms.Label lblNumberOfInvoices;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        private System.Windows.Forms.TextBox txtAvgOfInvoices;
        private System.Windows.Forms.TextBox txtNumberOfInvoices;
        private System.Windows.Forms.Label lblEnterubtotal;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
    }
}

