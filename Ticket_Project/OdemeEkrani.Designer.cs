﻿
namespace Ticket_Project
{
    partial class OdemeEkrani
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
            this.grpKartBilgileri = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbMasterCard = new System.Windows.Forms.RadioButton();
            this.rdbVisa = new System.Windows.Forms.RadioButton();
            this.dtpSKT = new System.Windows.Forms.DateTimePicker();
            this.txtCvvKodu = new System.Windows.Forms.TextBox();
            this.txtKartNumarasi = new System.Windows.Forms.TextBox();
            this.txtKartUzerindekiIsim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.grpKartBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKartBilgileri
            // 
            this.grpKartBilgileri.Controls.Add(this.pictureBox1);
            this.grpKartBilgileri.Controls.Add(this.rdbMasterCard);
            this.grpKartBilgileri.Controls.Add(this.rdbVisa);
            this.grpKartBilgileri.Controls.Add(this.dtpSKT);
            this.grpKartBilgileri.Controls.Add(this.txtCvvKodu);
            this.grpKartBilgileri.Controls.Add(this.txtKartNumarasi);
            this.grpKartBilgileri.Controls.Add(this.txtKartUzerindekiIsim);
            this.grpKartBilgileri.Controls.Add(this.label4);
            this.grpKartBilgileri.Controls.Add(this.label3);
            this.grpKartBilgileri.Controls.Add(this.label2);
            this.grpKartBilgileri.Controls.Add(this.label1);
            this.grpKartBilgileri.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKartBilgileri.Location = new System.Drawing.Point(340, 98);
            this.grpKartBilgileri.Name = "grpKartBilgileri";
            this.grpKartBilgileri.Size = new System.Drawing.Size(351, 372);
            this.grpKartBilgileri.TabIndex = 6;
            this.grpKartBilgileri.TabStop = false;
            this.grpKartBilgileri.Text = "Kart Bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // rdbMasterCard
            // 
            this.rdbMasterCard.AutoSize = true;
            this.rdbMasterCard.Checked = true;
            this.rdbMasterCard.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbMasterCard.Location = new System.Drawing.Point(26, 314);
            this.rdbMasterCard.Name = "rdbMasterCard";
            this.rdbMasterCard.Size = new System.Drawing.Size(97, 20);
            this.rdbMasterCard.TabIndex = 3;
            this.rdbMasterCard.TabStop = true;
            this.rdbMasterCard.Text = "Master Card";
            this.rdbMasterCard.UseVisualStyleBackColor = true;
            // 
            // rdbVisa
            // 
            this.rdbVisa.AutoSize = true;
            this.rdbVisa.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbVisa.Location = new System.Drawing.Point(137, 315);
            this.rdbVisa.Name = "rdbVisa";
            this.rdbVisa.Size = new System.Drawing.Size(50, 20);
            this.rdbVisa.TabIndex = 3;
            this.rdbVisa.TabStop = true;
            this.rdbVisa.Text = "Visa";
            this.rdbVisa.UseVisualStyleBackColor = true;
            // 
            // dtpSKT
            // 
            this.dtpSKT.Location = new System.Drawing.Point(26, 189);
            this.dtpSKT.Name = "dtpSKT";
            this.dtpSKT.Size = new System.Drawing.Size(200, 26);
            this.dtpSKT.TabIndex = 2;
            // 
            // txtCvvKodu
            // 
            this.txtCvvKodu.Location = new System.Drawing.Point(27, 259);
            this.txtCvvKodu.MaxLength = 3;
            this.txtCvvKodu.Name = "txtCvvKodu";
            this.txtCvvKodu.Size = new System.Drawing.Size(58, 26);
            this.txtCvvKodu.TabIndex = 1;
            // 
            // txtKartNumarasi
            // 
            this.txtKartNumarasi.Location = new System.Drawing.Point(27, 115);
            this.txtKartNumarasi.MaxLength = 16;
            this.txtKartNumarasi.Name = "txtKartNumarasi";
            this.txtKartNumarasi.Size = new System.Drawing.Size(258, 26);
            this.txtKartNumarasi.TabIndex = 1;
            // 
            // txtKartUzerindekiIsim
            // 
            this.txtKartUzerindekiIsim.Location = new System.Drawing.Point(26, 48);
            this.txtKartUzerindekiIsim.Name = "txtKartUzerindekiIsim";
            this.txtKartUzerindekiIsim.Size = new System.Drawing.Size(258, 26);
            this.txtKartUzerindekiIsim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cvv Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Son Kullanma Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kart Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kartın Üzerindeki İsim";
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUcret.Location = new System.Drawing.Point(449, 489);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(59, 18);
            this.lblToplamUcret.TabIndex = 8;
            this.lblToplamUcret.Text = "### TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(337, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam Ücret: ";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdemeYap.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYap.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYap.Location = new System.Drawing.Point(557, 476);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(134, 47);
            this.btnOdemeYap.TabIndex = 7;
            this.btnOdemeYap.Text = "ÖDEME YAP VE BİTİR";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // OdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 621);
            this.Controls.Add(this.grpKartBilgileri);
            this.Controls.Add(this.lblToplamUcret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOdemeYap);
            this.Name = "OdemeEkrani";
            this.Text = "OdemeEkrani";
            this.Load += new System.EventHandler(this.OdemeEkrani_Load);
            this.grpKartBilgileri.ResumeLayout(false);
            this.grpKartBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox grpKartBilgileri;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RadioButton rdbMasterCard;
        public System.Windows.Forms.RadioButton rdbVisa;
        public System.Windows.Forms.DateTimePicker dtpSKT;
        public System.Windows.Forms.TextBox txtCvvKodu;
        public System.Windows.Forms.TextBox txtKartNumarasi;
        public System.Windows.Forms.TextBox txtKartUzerindekiIsim;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnOdemeYap;
    }
}