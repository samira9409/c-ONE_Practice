namespace Hotel_booking_system
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
            this.checkbreak = new System.Windows.Forms.CheckBox();
            this.bntclear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdnhight = new System.Windows.Forms.RadioButton();
            this.rdnstandard = new System.Windows.Forms.RadioButton();
            this.rdnnormal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bntcalculate);
            this.groupBox3.Controls.Add(this.bntexit);
            this.groupBox3.Controls.Add(this.checkbreak);
            this.groupBox3.Controls.Add(this.bntclear);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(31, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 144);
            this.groupBox3.TabIndex = 5;
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
            // checkbreak
            // 
            this.checkbreak.AutoSize = true;
            this.checkbreak.Location = new System.Drawing.Point(21, 49);
            this.checkbreak.Name = "checkbreak";
            this.checkbreak.Size = new System.Drawing.Size(352, 30);
            this.checkbreak.TabIndex = 3;
            this.checkbreak.Text = "BreakFast(10 per guest nigts)";
            this.checkbreak.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.rdnhight);
            this.groupBox2.Controls.Add(this.rdnstandard);
            this.groupBox2.Controls.Add(this.rdnnormal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // rdnhight
            // 
            this.rdnhight.AutoSize = true;
            this.rdnhight.Location = new System.Drawing.Point(308, 47);
            this.rdnhight.Name = "rdnhight";
            this.rdnhight.Size = new System.Drawing.Size(93, 30);
            this.rdnhight.TabIndex = 3;
            this.rdnhight.TabStop = true;
            this.rdnhight.Text = "Hight";
            this.rdnhight.UseVisualStyleBackColor = true;
            // 
            // rdnstandard
            // 
            this.rdnstandard.AutoSize = true;
            this.rdnstandard.Location = new System.Drawing.Point(0, 47);
            this.rdnstandard.Name = "rdnstandard";
            this.rdnstandard.Size = new System.Drawing.Size(129, 30);
            this.rdnstandard.TabIndex = 4;
            this.rdnstandard.TabStop = true;
            this.rdnstandard.Text = "standard";
            this.rdnstandard.UseVisualStyleBackColor = true;
            // 
            // rdnnormal
            // 
            this.rdnnormal.AutoSize = true;
            this.rdnnormal.Location = new System.Drawing.Point(157, 47);
            this.rdnnormal.Name = "rdnnormal";
            this.rdnnormal.Size = new System.Drawing.Size(114, 30);
            this.rdnnormal.TabIndex = 2;
            this.rdnnormal.TabStop = true;
            this.rdnnormal.Text = "Normal";
            this.rdnnormal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumber);
            this.groupBox1.Controls.Add(this.txtnights);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 224);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personal Information";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(222, 161);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(148, 32);
            this.txtnumber.TabIndex = 7;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(222, 124);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(148, 32);
            this.txtnights.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(222, 86);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(148, 32);
            this.txtage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Guest";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(222, 48);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 32);
            this.txtname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Guest Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guest of Nights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guest Name";
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.ItemHeight = 20;
            this.lstBookingDetails.Location = new System.Drawing.Point(626, 60);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(321, 484);
            this.lstBookingDetails.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 592);
            this.Controls.Add(this.lstBookingDetails);
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
        private System.Windows.Forms.CheckBox checkbreak;
        private System.Windows.Forms.Button bntclear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdnhight;
        private System.Windows.Forms.RadioButton rdnstandard;
        private System.Windows.Forms.RadioButton rdnnormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBookingDetails;
    }
}

