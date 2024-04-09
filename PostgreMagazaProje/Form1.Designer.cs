namespace PostgreMagazaProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrunListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboUrunTedarikci = new System.Windows.Forms.ComboBox();
            this.TxtUrunID = new System.Windows.Forms.TextBox();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAlıs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUrunSatıs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UrunEkle = new System.Windows.Forms.Button();
            this.UrunSil = new System.Windows.Forms.Button();
            this.UrunAra = new System.Windows.Forms.Button();
            this.UrunGüncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboUrunKategori = new System.Windows.Forms.ComboBox();
            this.UrundenMenüye = new System.Windows.Forms.Button();
            this.comboBeden = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboSigorta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(553, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // UrunListele
            // 
            this.UrunListele.Location = new System.Drawing.Point(854, 27);
            this.UrunListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UrunListele.Name = "UrunListele";
            this.UrunListele.Size = new System.Drawing.Size(88, 37);
            this.UrunListele.TabIndex = 1;
            this.UrunListele.Text = "Listele";
            this.UrunListele.UseVisualStyleBackColor = true;
            this.UrunListele.Click += new System.EventHandler(this.UrunListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "URUN ID :";
            // 
            // comboUrunTedarikci
            // 
            this.comboUrunTedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUrunTedarikci.FormattingEnabled = true;
            this.comboUrunTedarikci.Location = new System.Drawing.Point(687, 274);
            this.comboUrunTedarikci.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboUrunTedarikci.Name = "comboUrunTedarikci";
            this.comboUrunTedarikci.Size = new System.Drawing.Size(142, 25);
            this.comboUrunTedarikci.TabIndex = 4;
            // 
            // TxtUrunID
            // 
            this.TxtUrunID.Location = new System.Drawing.Point(687, 27);
            this.TxtUrunID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUrunID.Name = "TxtUrunID";
            this.TxtUrunID.Size = new System.Drawing.Size(142, 23);
            this.TxtUrunID.TabIndex = 5;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(687, 68);
            this.TxtUrunAd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(142, 23);
            this.TxtUrunAd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "URUN AD :";
            // 
            // TxtUrunAlıs
            // 
            this.TxtUrunAlıs.Location = new System.Drawing.Point(687, 138);
            this.TxtUrunAlıs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUrunAlıs.Name = "TxtUrunAlıs";
            this.TxtUrunAlıs.Size = new System.Drawing.Size(142, 23);
            this.TxtUrunAlıs.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "URUN ALIS :";
            // 
            // TxtUrunSatıs
            // 
            this.TxtUrunSatıs.Location = new System.Drawing.Point(687, 183);
            this.TxtUrunSatıs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUrunSatıs.Name = "TxtUrunSatıs";
            this.TxtUrunSatıs.Size = new System.Drawing.Size(142, 23);
            this.TxtUrunSatıs.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "URUN SATIS :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "KATEGORİ :";
            // 
            // UrunEkle
            // 
            this.UrunEkle.Location = new System.Drawing.Point(854, 79);
            this.UrunEkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UrunEkle.Name = "UrunEkle";
            this.UrunEkle.Size = new System.Drawing.Size(88, 37);
            this.UrunEkle.TabIndex = 16;
            this.UrunEkle.Text = "Ekle";
            this.UrunEkle.UseVisualStyleBackColor = true;
            this.UrunEkle.Click += new System.EventHandler(this.UrunEkle_Click);
            // 
            // UrunSil
            // 
            this.UrunSil.Location = new System.Drawing.Point(854, 138);
            this.UrunSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UrunSil.Name = "UrunSil";
            this.UrunSil.Size = new System.Drawing.Size(88, 37);
            this.UrunSil.TabIndex = 17;
            this.UrunSil.Text = "Sil";
            this.UrunSil.UseVisualStyleBackColor = true;
            this.UrunSil.Click += new System.EventHandler(this.UrunSil_Click);
            // 
            // UrunAra
            // 
            this.UrunAra.Location = new System.Drawing.Point(854, 195);
            this.UrunAra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UrunAra.Name = "UrunAra";
            this.UrunAra.Size = new System.Drawing.Size(88, 37);
            this.UrunAra.TabIndex = 18;
            this.UrunAra.Text = "Ara";
            this.UrunAra.UseVisualStyleBackColor = true;
            this.UrunAra.Click += new System.EventHandler(this.UrunAra_Click);
            // 
            // UrunGüncelle
            // 
            this.UrunGüncelle.Location = new System.Drawing.Point(854, 261);
            this.UrunGüncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UrunGüncelle.Name = "UrunGüncelle";
            this.UrunGüncelle.Size = new System.Drawing.Size(88, 37);
            this.UrunGüncelle.TabIndex = 19;
            this.UrunGüncelle.Text = "Güncelle";
            this.UrunGüncelle.UseVisualStyleBackColor = true;
            this.UrunGüncelle.Click += new System.EventHandler(this.UrunGüncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "TEDARİKCİ :";
            // 
            // comboUrunKategori
            // 
            this.comboUrunKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUrunKategori.FormattingEnabled = true;
            this.comboUrunKategori.Location = new System.Drawing.Point(687, 230);
            this.comboUrunKategori.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboUrunKategori.Name = "comboUrunKategori";
            this.comboUrunKategori.Size = new System.Drawing.Size(142, 25);
            this.comboUrunKategori.TabIndex = 22;
            // 
            // UrundenMenüye
            // 
            this.UrundenMenüye.Location = new System.Drawing.Point(699, 416);
            this.UrundenMenüye.Name = "UrundenMenüye";
            this.UrundenMenüye.Size = new System.Drawing.Size(105, 97);
            this.UrundenMenüye.TabIndex = 23;
            this.UrundenMenüye.Text = "MENÜ İÇİN";
            this.UrundenMenüye.UseVisualStyleBackColor = true;
            this.UrundenMenüye.Click += new System.EventHandler(this.UrundenUrune_Click);
            // 
            // comboBeden
            // 
            this.comboBeden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBeden.FormattingEnabled = true;
            this.comboBeden.Location = new System.Drawing.Point(687, 319);
            this.comboBeden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBeden.Name = "comboBeden";
            this.comboBeden.Size = new System.Drawing.Size(142, 25);
            this.comboBeden.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 366);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "ÜRÜN SİGORTA SÜRESİ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "BEDEN :";
            // 
            // comboSigorta
            // 
            this.comboSigorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSigorta.FormattingEnabled = true;
            this.comboSigorta.Location = new System.Drawing.Point(687, 363);
            this.comboSigorta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboSigorta.Name = "comboSigorta";
            this.comboSigorta.Size = new System.Drawing.Size(142, 25);
            this.comboSigorta.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 29;
            this.button1.Text = "ÖZEL LİSTELEME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(687, 104);
            this.TxtUrunStok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.Size = new System.Drawing.Size(142, 23);
            this.TxtUrunStok.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "URUN STOK :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 90);
            this.button2.TabIndex = 34;
            this.button2.Text = "Seçili Kategorideki Ürün Sayısı İçin ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 325);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 25);
            this.comboBox1.TabIndex = 35;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(238, 325);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 25);
            this.comboBox2.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 90);
            this.button3.TabIndex = 36;
            this.button3.Text = "Seçili Bedendeki Ürün Sayısı İçin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(980, 525);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtUrunStok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBeden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboSigorta);
            this.Controls.Add(this.UrundenMenüye);
            this.Controls.Add(this.comboUrunKategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UrunGüncelle);
            this.Controls.Add(this.UrunAra);
            this.Controls.Add(this.UrunSil);
            this.Controls.Add(this.UrunEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtUrunSatıs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtUrunAlıs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunID);
            this.Controls.Add(this.comboUrunTedarikci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrunListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UrunListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboUrunTedarikci;
        private System.Windows.Forms.TextBox TxtUrunID;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrunAlıs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUrunSatıs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UrunEkle;
        private System.Windows.Forms.Button UrunSil;
        private System.Windows.Forms.Button UrunAra;
        private System.Windows.Forms.Button UrunGüncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboUrunKategori;
        private System.Windows.Forms.Button UrundenMenüye;
        private System.Windows.Forms.ComboBox comboBeden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboSigorta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
    }
}

