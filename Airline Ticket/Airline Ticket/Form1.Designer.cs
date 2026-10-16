namespace Airline_Ticket
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntcalculate = new System.Windows.Forms.Button();
            this.bntexit = new System.Windows.Forms.Button();
            this.checktravel = new System.Windows.Forms.CheckBox();
            this.bntclear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdnbusiness = new System.Windows.Forms.RadioButton();
            this.rdnfirst = new System.Windows.Forms.RadioButton();
            this.rdnnormal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txttickers = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAirlinebookigdetails = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bntcalculate);
            this.groupBox3.Controls.Add(this.bntexit);
            this.groupBox3.Controls.Add(this.checktravel);
            this.groupBox3.Controls.Add(this.bntclear);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 144);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional Option";
            // 
            // bntcalculate
            // 
            this.bntcalculate.Location = new System.Drawing.Point(21, 108);
            this.bntcalculate.Name = "bntcalculate";
            this.bntcalculate.Size = new System.Drawing.Size(126, 36);
            this.bntcalculate.TabIndex = 4;
            this.bntcalculate.Text = "calculate";
            this.bntcalculate.UseVisualStyleBackColor = true;
            this.bntcalculate.Click += new System.EventHandler(this.bntcalculate_Click);
            // 
            // bntexit
            // 
            this.bntexit.Location = new System.Drawing.Point(316, 96);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(102, 42);
            this.bntexit.TabIndex = 5;
            this.bntexit.Text = "Exit";
            this.bntexit.UseVisualStyleBackColor = true;
            this.bntexit.Click += new System.EventHandler(this.bntexit_Click);
            // 
            // checktravel
            // 
            this.checktravel.AutoSize = true;
            this.checktravel.Location = new System.Drawing.Point(21, 49);
            this.checktravel.Name = "checktravel";
            this.checktravel.Size = new System.Drawing.Size(422, 30);
            this.checktravel.TabIndex = 3;
            this.checktravel.Text = "Add Travel insurance($25 per ticket)";
            this.checktravel.UseVisualStyleBackColor = true;
            // 
            // bntclear
            // 
            this.bntclear.Location = new System.Drawing.Point(175, 102);
            this.bntclear.Name = "bntclear";
            this.bntclear.Size = new System.Drawing.Size(89, 42);
            this.bntclear.TabIndex = 4;
            this.bntclear.Text = "Clear";
            this.bntclear.UseVisualStyleBackColor = true;
            this.bntclear.Click += new System.EventHandler(this.bntclear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdnbusiness);
            this.groupBox2.Controls.Add(this.rdnfirst);
            this.groupBox2.Controls.Add(this.rdnnormal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Class";
            // 
            // rdnbusiness
            // 
            this.rdnbusiness.AutoSize = true;
            this.rdnbusiness.Location = new System.Drawing.Point(339, 47);
            this.rdnbusiness.Name = "rdnbusiness";
            this.rdnbusiness.Size = new System.Drawing.Size(181, 30);
            this.rdnbusiness.TabIndex = 3;
            this.rdnbusiness.TabStop = true;
            this.rdnbusiness.Text = "business clas";
            this.rdnbusiness.UseVisualStyleBackColor = true;
            // 
            // rdnfirst
            // 
            this.rdnfirst.AutoSize = true;
            this.rdnfirst.Location = new System.Drawing.Point(0, 47);
            this.rdnfirst.Name = "rdnfirst";
            this.rdnfirst.Size = new System.Drawing.Size(139, 30);
            this.rdnfirst.TabIndex = 4;
            this.rdnfirst.TabStop = true;
            this.rdnfirst.Text = "first class";
            this.rdnfirst.UseVisualStyleBackColor = true;
            // 
            // rdnnormal
            // 
            this.rdnnormal.AutoSize = true;
            this.rdnnormal.Location = new System.Drawing.Point(157, 47);
            this.rdnnormal.Name = "rdnnormal";
            this.rdnnormal.Size = new System.Drawing.Size(176, 30);
            this.rdnnormal.TabIndex = 2;
            this.rdnnormal.TabStop = true;
            this.rdnnormal.Text = "Normal class";
            this.rdnnormal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.txttickers);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personal Information";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(250, 167);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(148, 32);
            this.txtweight.TabIndex = 7;
            // 
            // txttickers
            // 
            this.txttickers.Location = new System.Drawing.Point(250, 128);
            this.txttickers.Name = "txttickers";
            this.txttickers.Size = new System.Drawing.Size(148, 32);
            this.txttickers.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(250, 93);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(148, 32);
            this.txtage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baggage Weight(kg):";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(250, 52);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 32);
            this.txtname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Passenger Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "number of tickers :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Passenger Name :";
            // 
            // lstAirlinebookigdetails
            // 
            this.lstAirlinebookigdetails.FormattingEnabled = true;
            this.lstAirlinebookigdetails.ItemHeight = 20;
            this.lstAirlinebookigdetails.Location = new System.Drawing.Point(635, 65);
            this.lstAirlinebookigdetails.Name = "lstAirlinebookigdetails";
            this.lstAirlinebookigdetails.Size = new System.Drawing.Size(289, 464);
            this.lstAirlinebookigdetails.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 589);
            this.Controls.Add(this.lstAirlinebookigdetails);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntcalculate;
        private System.Windows.Forms.Button bntexit;
        private System.Windows.Forms.CheckBox checktravel;
        private System.Windows.Forms.Button bntclear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdnbusiness;
        private System.Windows.Forms.RadioButton rdnfirst;
        private System.Windows.Forms.RadioButton rdnnormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txttickers;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAirlinebookigdetails;
    }
}

