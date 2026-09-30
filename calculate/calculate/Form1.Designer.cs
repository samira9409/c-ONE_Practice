namespace calculate
{
    partial class Form1
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
            this.amount = new System.Windows.Forms.Label();
            this.electro = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.priceperunit = new System.Windows.Forms.Label();
            this.previousreading = new System.Windows.Forms.Label();
            this.Currentreading = new System.Windows.Forms.Label();
            this.Customername = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(103, 392);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(219, 31);
            this.amount.TabIndex = 23;
            this.amount.Text = "Taxamount(7%) : ";
            // 
            // electro
            // 
            this.electro.AutoSize = true;
            this.electro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.electro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electro.Location = new System.Drawing.Point(103, 314);
            this.electro.Name = "electro";
            this.electro.Size = new System.Drawing.Size(302, 31);
            this.electro.TabIndex = 22;
            this.electro.Text = "Electricityusage(unit)      ";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(83, 461);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(414, 31);
            this.total.TabIndex = 21;
            this.total.Text = "Totalbill(including$5fixeedcharge)";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(547, 176);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(146, 35);
            this.txtUnitPrice.TabIndex = 20;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(547, 115);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(146, 35);
            this.txtCurrent.TabIndex = 19;
            // 
            // txtPrevious
            // 
            this.txtPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.Location = new System.Drawing.Point(547, 56);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(146, 35);
            this.txtPrevious.TabIndex = 18;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(547, 3);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(146, 35);
            this.txtCustomer.TabIndex = 17;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(326, 231);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(284, 46);
            this.btncalculate.TabIndex = 16;
            this.btncalculate.Text = "calculatebill";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // priceperunit
            // 
            this.priceperunit.AutoSize = true;
            this.priceperunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceperunit.Location = new System.Drawing.Point(146, 182);
            this.priceperunit.Name = "priceperunit";
            this.priceperunit.Size = new System.Drawing.Size(198, 29);
            this.priceperunit.TabIndex = 15;
            this.priceperunit.Text = "Enterpriceperunit";
            // 
            // previousreading
            // 
            this.previousreading.AutoSize = true;
            this.previousreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousreading.Location = new System.Drawing.Point(146, 56);
            this.previousreading.Name = "previousreading";
            this.previousreading.Size = new System.Drawing.Size(243, 29);
            this.previousreading.TabIndex = 14;
            this.previousreading.Text = "Enterpreviousreadinh";
            // 
            // Currentreading
            // 
            this.Currentreading.AutoSize = true;
            this.Currentreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currentreading.Location = new System.Drawing.Point(146, 115);
            this.Currentreading.Name = "Currentreading";
            this.Currentreading.Size = new System.Drawing.Size(226, 29);
            this.Currentreading.TabIndex = 13;
            this.Currentreading.Text = "Entercurrentreading";
            // 
            // Customername
            // 
            this.Customername.AutoSize = true;
            this.Customername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customername.Location = new System.Drawing.Point(146, 9);
            this.Customername.Name = "Customername";
            this.Customername.Size = new System.Drawing.Size(229, 29);
            this.Customername.TabIndex = 12;
            this.Customername.Text = "Entercustomername";
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsage.Location = new System.Drawing.Point(547, 314);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(75, 22);
            this.lblUsage.TabIndex = 24;
            this.lblUsage.Text = "                ";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(547, 378);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(79, 22);
            this.lblTax.TabIndex = 25;
            this.lblTax.Text = "                 ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(555, 468);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 22);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "               ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 556);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblUsage);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.electro);
            this.Controls.Add(this.total);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.priceperunit);
            this.Controls.Add(this.previousreading);
            this.Controls.Add(this.Currentreading);
            this.Controls.Add(this.Customername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label electro;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label priceperunit;
        private System.Windows.Forms.Label previousreading;
        private System.Windows.Forms.Label Currentreading;
        private System.Windows.Forms.Label Customername;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}

