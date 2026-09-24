namespace assigment
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
            this.month = new System.Windows.Forms.Label();
            this.yearpro = new System.Windows.Forms.Label();
            this.dayofmonth = new System.Windows.Forms.Label();
            this.dayofweek = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtdayofmonth = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdayofweek = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbldataoutput = new System.Windows.Forms.Label();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(26, 92);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(355, 32);
            this.month.TabIndex = 7;
            this.month.Text = "enterthenameofthemonth";
            // 
            // yearpro
            // 
            this.yearpro.AutoSize = true;
            this.yearpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearpro.Location = new System.Drawing.Point(26, 268);
            this.yearpro.Name = "yearpro";
            this.yearpro.Size = new System.Drawing.Size(186, 32);
            this.yearpro.TabIndex = 6;
            this.yearpro.Text = "entertheyear";
            // 
            // dayofmonth
            // 
            this.dayofmonth.AutoSize = true;
            this.dayofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofmonth.Location = new System.Drawing.Point(26, 187);
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.Size = new System.Drawing.Size(284, 32);
            this.dayofmonth.TabIndex = 5;
            this.dayofmonth.Text = "enterthenumericday";
            // 
            // dayofweek
            // 
            this.dayofweek.AutoSize = true;
            this.dayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofweek.Location = new System.Drawing.Point(26, 21);
            this.dayofweek.Name = "dayofweek";
            this.dayofweek.Size = new System.Drawing.Size(272, 32);
            this.dayofweek.TabIndex = 4;
            this.dayofweek.Text = "enterthedayofweek";
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(648, 187);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(114, 39);
            this.txtyear.TabIndex = 14;
            this.txtyear.TextChanged += new System.EventHandler(this.txtyear_TextChanged);
            // 
            // txtdayofmonth
            // 
            this.txtdayofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofmonth.Location = new System.Drawing.Point(641, 137);
            this.txtdayofmonth.Name = "txtdayofmonth";
            this.txtdayofmonth.Size = new System.Drawing.Size(121, 39);
            this.txtdayofmonth.TabIndex = 13;
            this.txtdayofmonth.TextChanged += new System.EventHandler(this.txtdayofmonth_TextChanged);
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(638, 92);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(124, 39);
            this.txtmonth.TabIndex = 12;
            this.txtmonth.TextChanged += new System.EventHandler(this.txtmonth_TextChanged);
            // 
            // txtdayofweek
            // 
            this.txtdayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofweek.Location = new System.Drawing.Point(644, 47);
            this.txtdayofweek.Name = "txtdayofweek";
            this.txtdayofweek.Size = new System.Drawing.Size(115, 39);
            this.txtdayofweek.TabIndex = 11;
            this.txtdayofweek.TextChanged += new System.EventHandler(this.txtdayofweek_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(533, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 56);
            this.button2.TabIndex = 18;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbldataoutput
            // 
            this.lbldataoutput.AutoSize = true;
            this.lbldataoutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbldataoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldataoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataoutput.Location = new System.Drawing.Point(229, 304);
            this.lbldataoutput.Name = "lbldataoutput";
            this.lbldataoutput.Size = new System.Drawing.Size(504, 34);
            this.lbldataoutput.TabIndex = 17;
            this.lbldataoutput.Text = "                                                             \r\n";
            // 
            // btnshowdate
            // 
            this.btnshowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.Location = new System.Drawing.Point(37, 366);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(236, 60);
            this.btnshowdate.TabIndex = 16;
            this.btnshowdate.Text = "showdata";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 65);
            this.button1.TabIndex = 15;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbldataoutput);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayofmonth);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayofweek);
            this.Controls.Add(this.month);
            this.Controls.Add(this.yearpro);
            this.Controls.Add(this.dayofmonth);
            this.Controls.Add(this.dayofweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label yearpro;
        private System.Windows.Forms.Label dayofmonth;
        private System.Windows.Forms.Label dayofweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtdayofmonth;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdayofweek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbldataoutput;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button button1;
    }
}

