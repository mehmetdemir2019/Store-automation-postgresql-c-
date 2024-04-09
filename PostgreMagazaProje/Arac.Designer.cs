namespace PostgreMagazaProje
{
    partial class Arac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAracıd = new System.Windows.Forms.TextBox();
            this.TxtAracMarka = new System.Windows.Forms.TextBox();
            this.TxtAracModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboAracTedarik = new System.Windows.Forms.ComboBox();
            this.AracListele = new System.Windows.Forms.Button();
            this.AracEkle = new System.Windows.Forms.Button();
            this.AracSil = new System.Windows.Forms.Button();
            this.AracAra = new System.Windows.Forms.Button();
            this.AracGüncelle = new System.Windows.Forms.Button();
            this.TxtAracFiloMarka = new System.Windows.Forms.TextBox();
            this.TxtAracFiloID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FiloGüncelle = new System.Windows.Forms.Button();
            this.FiloAra = new System.Windows.Forms.Button();
            this.FİloSİl = new System.Windows.Forms.Button();
            this.FiloEkle = new System.Windows.Forms.Button();
            this.FiloListele = new System.Windows.Forms.Button();
            this.AracdanMenüye = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(400, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARAÇ İŞLEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ARAÇ TEDARİKÇİ İŞLEMLERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arac ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Araç Marka :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Araç Model Yılı :";
            // 
            // TxtAracıd
            // 
            this.TxtAracıd.Location = new System.Drawing.Point(112, 55);
            this.TxtAracıd.Name = "TxtAracıd";
            this.TxtAracıd.Size = new System.Drawing.Size(120, 23);
            this.TxtAracıd.TabIndex = 6;
            // 
            // TxtAracMarka
            // 
            this.TxtAracMarka.Location = new System.Drawing.Point(113, 96);
            this.TxtAracMarka.Name = "TxtAracMarka";
            this.TxtAracMarka.Size = new System.Drawing.Size(120, 23);
            this.TxtAracMarka.TabIndex = 7;
            // 
            // TxtAracModel
            // 
            this.TxtAracModel.Location = new System.Drawing.Point(113, 134);
            this.TxtAracModel.Name = "TxtAracModel";
            this.TxtAracModel.Size = new System.Drawing.Size(120, 23);
            this.TxtAracModel.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Araç Tedarikçisi :";
            // 
            // comboAracTedarik
            // 
            this.comboAracTedarik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAracTedarik.FormattingEnabled = true;
            this.comboAracTedarik.Location = new System.Drawing.Point(112, 177);
            this.comboAracTedarik.Name = "comboAracTedarik";
            this.comboAracTedarik.Size = new System.Drawing.Size(121, 25);
            this.comboAracTedarik.TabIndex = 10;
            // 
            // AracListele
            // 
            this.AracListele.Location = new System.Drawing.Point(10, 253);
            this.AracListele.Name = "AracListele";
            this.AracListele.Size = new System.Drawing.Size(75, 43);
            this.AracListele.TabIndex = 11;
            this.AracListele.Text = "Listele";
            this.AracListele.UseVisualStyleBackColor = true;
            this.AracListele.Click += new System.EventHandler(this.AracListele_Click);
            // 
            // AracEkle
            // 
            this.AracEkle.Location = new System.Drawing.Point(157, 253);
            this.AracEkle.Name = "AracEkle";
            this.AracEkle.Size = new System.Drawing.Size(75, 43);
            this.AracEkle.TabIndex = 16;
            this.AracEkle.Text = "Ekle";
            this.AracEkle.UseVisualStyleBackColor = true;
            this.AracEkle.Click += new System.EventHandler(this.AracEkle_Click);
            // 
            // AracSil
            // 
            this.AracSil.Location = new System.Drawing.Point(10, 324);
            this.AracSil.Name = "AracSil";
            this.AracSil.Size = new System.Drawing.Size(75, 43);
            this.AracSil.TabIndex = 17;
            this.AracSil.Text = "Sil";
            this.AracSil.UseVisualStyleBackColor = true;
            this.AracSil.Click += new System.EventHandler(this.AracSil_Click);
            // 
            // AracAra
            // 
            this.AracAra.Location = new System.Drawing.Point(157, 324);
            this.AracAra.Name = "AracAra";
            this.AracAra.Size = new System.Drawing.Size(75, 43);
            this.AracAra.TabIndex = 18;
            this.AracAra.Text = "Ara";
            this.AracAra.UseVisualStyleBackColor = true;
            this.AracAra.Click += new System.EventHandler(this.AracAra_Click);
            // 
            // AracGüncelle
            // 
            this.AracGüncelle.Location = new System.Drawing.Point(77, 385);
            this.AracGüncelle.Name = "AracGüncelle";
            this.AracGüncelle.Size = new System.Drawing.Size(75, 43);
            this.AracGüncelle.TabIndex = 19;
            this.AracGüncelle.Text = "Güncelle";
            this.AracGüncelle.UseVisualStyleBackColor = true;
            this.AracGüncelle.Click += new System.EventHandler(this.AracGüncelle_Click);
            // 
            // TxtAracFiloMarka
            // 
            this.TxtAracFiloMarka.Location = new System.Drawing.Point(801, 99);
            this.TxtAracFiloMarka.Name = "TxtAracFiloMarka";
            this.TxtAracFiloMarka.Size = new System.Drawing.Size(120, 23);
            this.TxtAracFiloMarka.TabIndex = 23;
            // 
            // TxtAracFiloID
            // 
            this.TxtAracFiloID.Location = new System.Drawing.Point(799, 52);
            this.TxtAracFiloID.Name = "TxtAracFiloID";
            this.TxtAracFiloID.Size = new System.Drawing.Size(120, 23);
            this.TxtAracFiloID.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Araç Filo Marka :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Arac Filo ID :";
            // 
            // FiloGüncelle
            // 
            this.FiloGüncelle.Location = new System.Drawing.Point(766, 385);
            this.FiloGüncelle.Name = "FiloGüncelle";
            this.FiloGüncelle.Size = new System.Drawing.Size(75, 43);
            this.FiloGüncelle.TabIndex = 28;
            this.FiloGüncelle.Text = "Güncelle";
            this.FiloGüncelle.UseVisualStyleBackColor = true;
            this.FiloGüncelle.Click += new System.EventHandler(this.FiloGüncelle_Click);
            // 
            // FiloAra
            // 
            this.FiloAra.Location = new System.Drawing.Point(846, 324);
            this.FiloAra.Name = "FiloAra";
            this.FiloAra.Size = new System.Drawing.Size(75, 43);
            this.FiloAra.TabIndex = 27;
            this.FiloAra.Text = "Ara";
            this.FiloAra.UseVisualStyleBackColor = true;
            this.FiloAra.Click += new System.EventHandler(this.FiloAra_Click);
            // 
            // FİloSİl
            // 
            this.FİloSİl.Location = new System.Drawing.Point(699, 324);
            this.FİloSİl.Name = "FİloSİl";
            this.FİloSİl.Size = new System.Drawing.Size(75, 43);
            this.FİloSİl.TabIndex = 26;
            this.FİloSİl.Text = "Sil";
            this.FİloSİl.UseVisualStyleBackColor = true;
            this.FİloSİl.Click += new System.EventHandler(this.FİloSİl_Click);
            // 
            // FiloEkle
            // 
            this.FiloEkle.Location = new System.Drawing.Point(846, 253);
            this.FiloEkle.Name = "FiloEkle";
            this.FiloEkle.Size = new System.Drawing.Size(75, 43);
            this.FiloEkle.TabIndex = 25;
            this.FiloEkle.Text = "Ekle";
            this.FiloEkle.UseVisualStyleBackColor = true;
            this.FiloEkle.Click += new System.EventHandler(this.FiloEkle_Click);
            // 
            // FiloListele
            // 
            this.FiloListele.Location = new System.Drawing.Point(699, 253);
            this.FiloListele.Name = "FiloListele";
            this.FiloListele.Size = new System.Drawing.Size(75, 43);
            this.FiloListele.TabIndex = 24;
            this.FiloListele.Text = "Listele";
            this.FiloListele.UseVisualStyleBackColor = true;
            this.FiloListele.Click += new System.EventHandler(this.FiloListele_Click);
            // 
            // AracdanMenüye
            // 
            this.AracdanMenüye.Location = new System.Drawing.Point(391, 317);
            this.AracdanMenüye.Name = "AracdanMenüye";
            this.AracdanMenüye.Size = new System.Drawing.Size(143, 111);
            this.AracdanMenüye.TabIndex = 29;
            this.AracdanMenüye.Text = "MENÜ DÖN";
            this.AracdanMenüye.UseVisualStyleBackColor = true;
            this.AracdanMenüye.Click += new System.EventHandler(this.AracdanMenüye_Click);
            // 
            // Arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.AracdanMenüye);
            this.Controls.Add(this.FiloGüncelle);
            this.Controls.Add(this.FiloAra);
            this.Controls.Add(this.FİloSİl);
            this.Controls.Add(this.FiloEkle);
            this.Controls.Add(this.FiloListele);
            this.Controls.Add(this.TxtAracFiloMarka);
            this.Controls.Add(this.TxtAracFiloID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AracGüncelle);
            this.Controls.Add(this.AracAra);
            this.Controls.Add(this.AracSil);
            this.Controls.Add(this.AracEkle);
            this.Controls.Add(this.AracListele);
            this.Controls.Add(this.comboAracTedarik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAracModel);
            this.Controls.Add(this.TxtAracMarka);
            this.Controls.Add(this.TxtAracıd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Arac";
            this.Text = "Arac";
            this.Load += new System.EventHandler(this.Arac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAracıd;
        private System.Windows.Forms.TextBox TxtAracMarka;
        private System.Windows.Forms.TextBox TxtAracModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboAracTedarik;
        private System.Windows.Forms.Button AracListele;
        private System.Windows.Forms.Button AracEkle;
        private System.Windows.Forms.Button AracSil;
        private System.Windows.Forms.Button AracAra;
        private System.Windows.Forms.Button AracGüncelle;
        private System.Windows.Forms.TextBox TxtAracFiloMarka;
        private System.Windows.Forms.TextBox TxtAracFiloID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button FiloGüncelle;
        private System.Windows.Forms.Button FiloAra;
        private System.Windows.Forms.Button FİloSİl;
        private System.Windows.Forms.Button FiloEkle;
        private System.Windows.Forms.Button FiloListele;
        private System.Windows.Forms.Button AracdanMenüye;
    }
}