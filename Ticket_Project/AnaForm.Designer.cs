﻿
namespace Ticket_Project
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPnrSorgula = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.grpSeferBilgisi = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdbTekYon = new System.Windows.Forms.RadioButton();
            this.rdbGidisDonus = new System.Windows.Forms.RadioButton();
            this.rdbRezervasyon = new System.Windows.Forms.RadioButton();
            this.rdbSatinAlma = new System.Windows.Forms.RadioButton();
            this.dtpDonusTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGidisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSeferBilgisi.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPnrSorgula
            // 
            this.btnPnrSorgula.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPnrSorgula.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPnrSorgula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPnrSorgula.Location = new System.Drawing.Point(94, 384);
            this.btnPnrSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnPnrSorgula.Name = "btnPnrSorgula";
            this.btnPnrSorgula.Size = new System.Drawing.Size(184, 45);
            this.btnPnrSorgula.TabIndex = 22;
            this.btnPnrSorgula.Text = "PNR SORGULA";
            this.btnPnrSorgula.UseVisualStyleBackColor = false;
            this.btnPnrSorgula.Click += new System.EventHandler(this.btnPnrSorgula_Click_1);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnListele.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListele.Location = new System.Drawing.Point(337, 384);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(184, 45);
            this.btnListele.TabIndex = 21;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // grpSeferBilgisi
            // 
            this.grpSeferBilgisi.BackColor = System.Drawing.Color.Gray;
            this.grpSeferBilgisi.Controls.Add(this.flowLayoutPanel1);
            this.grpSeferBilgisi.Controls.Add(this.rdbRezervasyon);
            this.grpSeferBilgisi.Controls.Add(this.rdbSatinAlma);
            this.grpSeferBilgisi.Controls.Add(this.dtpDonusTarihi);
            this.grpSeferBilgisi.Controls.Add(this.dtpGidisTarihi);
            this.grpSeferBilgisi.Controls.Add(this.cmbNereye);
            this.grpSeferBilgisi.Controls.Add(this.cmbNereden);
            this.grpSeferBilgisi.Controls.Add(this.label3);
            this.grpSeferBilgisi.Controls.Add(this.label4);
            this.grpSeferBilgisi.Location = new System.Drawing.Point(93, 95);
            this.grpSeferBilgisi.Margin = new System.Windows.Forms.Padding(2);
            this.grpSeferBilgisi.Name = "grpSeferBilgisi";
            this.grpSeferBilgisi.Padding = new System.Windows.Forms.Padding(2);
            this.grpSeferBilgisi.Size = new System.Drawing.Size(428, 285);
            this.grpSeferBilgisi.TabIndex = 20;
            this.grpSeferBilgisi.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rdbTekYon);
            this.flowLayoutPanel1.Controls.Add(this.rdbGidisDonus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(119, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(179, 30);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // rdbTekYon
            // 
            this.rdbTekYon.AutoSize = true;
            this.rdbTekYon.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTekYon.Location = new System.Drawing.Point(2, 2);
            this.rdbTekYon.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTekYon.Name = "rdbTekYon";
            this.rdbTekYon.Size = new System.Drawing.Size(73, 20);
            this.rdbTekYon.TabIndex = 4;
            this.rdbTekYon.TabStop = true;
            this.rdbTekYon.Text = "Tek Yön";
            this.rdbTekYon.UseVisualStyleBackColor = true;
            // 
            // rdbGidisDonus
            // 
            this.rdbGidisDonus.AutoSize = true;
            this.rdbGidisDonus.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbGidisDonus.Location = new System.Drawing.Point(79, 2);
            this.rdbGidisDonus.Margin = new System.Windows.Forms.Padding(2);
            this.rdbGidisDonus.Name = "rdbGidisDonus";
            this.rdbGidisDonus.Size = new System.Drawing.Size(95, 20);
            this.rdbGidisDonus.TabIndex = 5;
            this.rdbGidisDonus.TabStop = true;
            this.rdbGidisDonus.Text = "Gidiş Dönüş";
            this.rdbGidisDonus.UseVisualStyleBackColor = true;
            // 
            // rdbRezervasyon
            // 
            this.rdbRezervasyon.AutoSize = true;
            this.rdbRezervasyon.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbRezervasyon.Location = new System.Drawing.Point(97, 200);
            this.rdbRezervasyon.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRezervasyon.Name = "rdbRezervasyon";
            this.rdbRezervasyon.Size = new System.Drawing.Size(99, 20);
            this.rdbRezervasyon.TabIndex = 8;
            this.rdbRezervasyon.TabStop = true;
            this.rdbRezervasyon.Text = "Rezervasyon";
            this.rdbRezervasyon.UseVisualStyleBackColor = true;
            // 
            // rdbSatinAlma
            // 
            this.rdbSatinAlma.AutoSize = true;
            this.rdbSatinAlma.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSatinAlma.Location = new System.Drawing.Point(227, 200);
            this.rdbSatinAlma.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSatinAlma.Name = "rdbSatinAlma";
            this.rdbSatinAlma.Size = new System.Drawing.Size(86, 20);
            this.rdbSatinAlma.TabIndex = 9;
            this.rdbSatinAlma.TabStop = true;
            this.rdbSatinAlma.Text = "Satın Alma";
            this.rdbSatinAlma.UseVisualStyleBackColor = true;
            // 
            // dtpDonusTarihi
            // 
            this.dtpDonusTarihi.Location = new System.Drawing.Point(250, 154);
            this.dtpDonusTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDonusTarihi.Name = "dtpDonusTarihi";
            this.dtpDonusTarihi.Size = new System.Drawing.Size(153, 20);
            this.dtpDonusTarihi.TabIndex = 7;
            // 
            // dtpGidisTarihi
            // 
            this.dtpGidisTarihi.Location = new System.Drawing.Point(32, 154);
            this.dtpGidisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGidisTarihi.Name = "dtpGidisTarihi";
            this.dtpGidisTarihi.Size = new System.Drawing.Size(153, 20);
            this.dtpGidisTarihi.TabIndex = 6;
            // 
            // cmbNereye
            // 
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(116, 65);
            this.cmbNereye.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(182, 21);
            this.cmbNereye.TabIndex = 3;
            // 
            // cmbNereden
            // 
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(116, 28);
            this.cmbNereden.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(182, 21);
            this.cmbNereden.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nereye:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nereden:";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 572);
            this.Controls.Add(this.btnPnrSorgula);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.grpSeferBilgisi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AnaForm";
            this.Text = "Bilet_Ara";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSeferBilgisi.ResumeLayout(false);
            this.grpSeferBilgisi.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnPnrSorgula;
        public System.Windows.Forms.Button btnListele;
        public System.Windows.Forms.GroupBox grpSeferBilgisi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.RadioButton rdbTekYon;
        public System.Windows.Forms.RadioButton rdbGidisDonus;
        public System.Windows.Forms.RadioButton rdbRezervasyon;
        public System.Windows.Forms.RadioButton rdbSatinAlma;
        public System.Windows.Forms.DateTimePicker dtpDonusTarihi;
        public System.Windows.Forms.DateTimePicker dtpGidisTarihi;
        public System.Windows.Forms.ComboBox cmbNereye;
        public System.Windows.Forms.ComboBox cmbNereden;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}