﻿namespace EntityOrnek
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOgrenciListele = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDersId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnNotGuncelle = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDersListele = new System.Windows.Forms.Button();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.BtnProsedur = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnOgrenciListele
            // 
            this.BtnOgrenciListele.Location = new System.Drawing.Point(24, 179);
            this.BtnOgrenciListele.Name = "BtnOgrenciListele";
            this.BtnOgrenciListele.Size = new System.Drawing.Size(188, 44);
            this.BtnOgrenciListele.TabIndex = 1;
            this.BtnOgrenciListele.Text = "Öğrenci Listele";
            this.BtnOgrenciListele.UseVisualStyleBackColor = true;
            this.BtnOgrenciListele.Click += new System.EventHandler(this.BtnOgrenciListele_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(24, 305);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(188, 44);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(24, 239);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(188, 44);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(24, 433);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(188, 44);
            this.BtnBul.TabIndex = 4;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(24, 370);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(188, 44);
            this.BtnGuncelle.TabIndex = 5;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFoto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtOgrenciID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(281, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // TxtFoto
            // 
            this.TxtFoto.Location = new System.Drawing.Point(171, 212);
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(100, 30);
            this.TxtFoto.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "FOTOĞRAF :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(171, 155);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 30);
            this.TxtSoyad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "SOYAD :";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(171, 111);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 30);
            this.TxtAd.TabIndex = 17;
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "AD :";
            // 
            // TxtOgrenciID
            // 
            this.TxtOgrenciID.Location = new System.Drawing.Point(171, 66);
            this.TxtOgrenciID.Name = "TxtOgrenciID";
            this.TxtOgrenciID.Size = new System.Drawing.Size(100, 30);
            this.TxtOgrenciID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDersAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtDersId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(281, 506);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 185);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(171, 111);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(100, 30);
            this.TxtDersAd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = " DERS AD :";
            // 
            // TxtDersId
            // 
            this.TxtDersId.Location = new System.Drawing.Point(171, 66);
            this.TxtDersId.Name = "TxtDersId";
            this.TxtDersId.Size = new System.Drawing.Size(100, 30);
            this.TxtDersId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = " DERS ID :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnNotGuncelle);
            this.groupBox3.Controls.Add(this.BtnHesapla);
            this.groupBox3.Controls.Add(this.TxtDurum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtOrtalama);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtSinav3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtSinav2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtSinav1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(602, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 468);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // BtnNotGuncelle
            // 
            this.BtnNotGuncelle.Location = new System.Drawing.Point(66, 387);
            this.BtnNotGuncelle.Name = "BtnNotGuncelle";
            this.BtnNotGuncelle.Size = new System.Drawing.Size(240, 44);
            this.BtnNotGuncelle.TabIndex = 25;
            this.BtnNotGuncelle.Text = "Sınav Notu Güncelle";
            this.BtnNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(95, 327);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(188, 44);
            this.BtnHesapla.TabIndex = 24;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(171, 245);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(100, 30);
            this.TxtDurum.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "DURUM :";
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Location = new System.Drawing.Point(171, 201);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(100, 30);
            this.TxtOrtalama.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "ORTALAMA :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(171, 155);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(100, 30);
            this.TxtSinav3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "SINAV 3 :";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(171, 111);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(100, 30);
            this.TxtSinav2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "SINAV 2 :";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(171, 66);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(100, 30);
            this.TxtSinav1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "SINAV 1 :";
            // 
            // BtnDersListele
            // 
            this.BtnDersListele.Location = new System.Drawing.Point(24, 496);
            this.BtnDersListele.Name = "BtnDersListele";
            this.BtnDersListele.Size = new System.Drawing.Size(188, 44);
            this.BtnDersListele.TabIndex = 9;
            this.BtnDersListele.Text = "Ders Listele";
            this.BtnDersListele.UseVisualStyleBackColor = true;
            this.BtnDersListele.Click += new System.EventHandler(this.BtnDersListele_Click);
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(24, 558);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(188, 44);
            this.BtnNotListesi.TabIndex = 10;
            this.BtnNotListesi.Text = "Not Listesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // BtnProsedur
            // 
            this.BtnProsedur.Location = new System.Drawing.Point(24, 617);
            this.BtnProsedur.Name = "BtnProsedur";
            this.BtnProsedur.Size = new System.Drawing.Size(188, 44);
            this.BtnProsedur.TabIndex = 11;
            this.BtnProsedur.Text = "Prosedür";
            this.BtnProsedur.UseVisualStyleBackColor = true;
            this.BtnProsedur.Click += new System.EventHandler(this.BtnProsedur_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(988, 194);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(243, 29);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala (A-->Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(1033, 451);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(170, 60);
            this.BtnLinqEntity.TabIndex = 13;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(988, 239);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(243, 29);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala (Z-->A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(988, 274);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 29);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk 3 Kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(988, 309);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(211, 29);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ID\'ye Göre Veri Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 703);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnProsedur);
            this.Controls.Add(this.BtnNotListesi);
            this.Controls.Add(this.BtnDersListele);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOgrenciListele;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDersId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDersListele;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.Button BtnNotGuncelle;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnProsedur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

