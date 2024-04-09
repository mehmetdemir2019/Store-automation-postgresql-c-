namespace PostgreMagazaProje
{
    partial class Siparis
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
            this.TxtSiparisID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSiparisMusteri = new System.Windows.Forms.ComboBox();
            this.SiparistenMenüye = new System.Windows.Forms.Button();
            this.SiparişListele = new System.Windows.Forms.Button();
            this.SiparisEkle = new System.Windows.Forms.Button();
            this.SiparisSil = new System.Windows.Forms.Button();
            this.SiparişAra = new System.Windows.Forms.Button();
            this.SiparişGüncelle = new System.Windows.Forms.Button();
            this.SiparişteKuryeListele = new System.Windows.Forms.Button();
            this.TxtSiparisKuryeID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtSiparisUrunID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(564, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siparis ID :";
            // 
            // TxtSiparisID
            // 
            this.TxtSiparisID.Location = new System.Drawing.Point(779, 37);
            this.TxtSiparisID.Name = "TxtSiparisID";
            this.TxtSiparisID.Size = new System.Drawing.Size(142, 22);
            this.TxtSiparisID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Siparis Urun ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Siparis Kurye ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sİparis Musteri : ";
            // 
            // comboSiparisMusteri
            // 
            this.comboSiparisMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSiparisMusteri.FormattingEnabled = true;
            this.comboSiparisMusteri.Location = new System.Drawing.Point(779, 168);
            this.comboSiparisMusteri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboSiparisMusteri.Name = "comboSiparisMusteri";
            this.comboSiparisMusteri.Size = new System.Drawing.Size(142, 24);
            this.comboSiparisMusteri.TabIndex = 12;
            // 
            // SiparistenMenüye
            // 
            this.SiparistenMenüye.Location = new System.Drawing.Point(248, 299);
            this.SiparistenMenüye.Name = "SiparistenMenüye";
            this.SiparistenMenüye.Size = new System.Drawing.Size(118, 76);
            this.SiparistenMenüye.TabIndex = 13;
            this.SiparistenMenüye.Text = "MENÜ İÇİN ";
            this.SiparistenMenüye.UseVisualStyleBackColor = true;
            this.SiparistenMenüye.Click += new System.EventHandler(this.SiparistenMenüye_Click);
            // 
            // SiparişListele
            // 
            this.SiparişListele.Location = new System.Drawing.Point(614, 260);
            this.SiparişListele.Name = "SiparişListele";
            this.SiparişListele.Size = new System.Drawing.Size(75, 56);
            this.SiparişListele.TabIndex = 14;
            this.SiparişListele.Text = "Listele";
            this.SiparişListele.UseVisualStyleBackColor = true;
            this.SiparişListele.Click += new System.EventHandler(this.SiparişListele_Click);
            // 
            // SiparisEkle
            // 
            this.SiparisEkle.Location = new System.Drawing.Point(730, 260);
            this.SiparisEkle.Name = "SiparisEkle";
            this.SiparisEkle.Size = new System.Drawing.Size(75, 56);
            this.SiparisEkle.TabIndex = 15;
            this.SiparisEkle.Text = "Ekle";
            this.SiparisEkle.UseVisualStyleBackColor = true;
            this.SiparisEkle.Click += new System.EventHandler(this.SiparisEkle_Click);
            // 
            // SiparisSil
            // 
            this.SiparisSil.Location = new System.Drawing.Point(846, 260);
            this.SiparisSil.Name = "SiparisSil";
            this.SiparisSil.Size = new System.Drawing.Size(75, 56);
            this.SiparisSil.TabIndex = 16;
            this.SiparisSil.Text = "Sil";
            this.SiparisSil.UseVisualStyleBackColor = true;
            this.SiparisSil.Click += new System.EventHandler(this.SiparisSil_Click);
            // 
            // SiparişAra
            // 
            this.SiparişAra.Location = new System.Drawing.Point(671, 334);
            this.SiparişAra.Name = "SiparişAra";
            this.SiparişAra.Size = new System.Drawing.Size(75, 56);
            this.SiparişAra.TabIndex = 17;
            this.SiparişAra.Text = "Ara";
            this.SiparişAra.UseVisualStyleBackColor = true;
            this.SiparişAra.Click += new System.EventHandler(this.SiparişAra_Click);
            // 
            // SiparişGüncelle
            // 
            this.SiparişGüncelle.Location = new System.Drawing.Point(795, 334);
            this.SiparişGüncelle.Name = "SiparişGüncelle";
            this.SiparişGüncelle.Size = new System.Drawing.Size(75, 56);
            this.SiparişGüncelle.TabIndex = 18;
            this.SiparişGüncelle.Text = "Güncelle";
            this.SiparişGüncelle.UseVisualStyleBackColor = true;
            this.SiparişGüncelle.Click += new System.EventHandler(this.SiparişGüncelle_Click);
            // 
            // SiparişteKuryeListele
            // 
            this.SiparişteKuryeListele.Location = new System.Drawing.Point(596, 131);
            this.SiparişteKuryeListele.Name = "SiparişteKuryeListele";
            this.SiparişteKuryeListele.Size = new System.Drawing.Size(60, 39);
            this.SiparişteKuryeListele.TabIndex = 19;
            this.SiparişteKuryeListele.Text = "Kurye Listele";
            this.SiparişteKuryeListele.UseVisualStyleBackColor = true;
            this.SiparişteKuryeListele.Click += new System.EventHandler(this.SiparişteKuryeListele_Click);
            // 
            // TxtSiparisKuryeID
            // 
            this.TxtSiparisKuryeID.Location = new System.Drawing.Point(779, 128);
            this.TxtSiparisKuryeID.Name = "TxtSiparisKuryeID";
            this.TxtSiparisKuryeID.Size = new System.Drawing.Size(142, 22);
            this.TxtSiparisKuryeID.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Urun Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtSiparisUrunID
            // 
            this.TxtSiparisUrunID.Location = new System.Drawing.Point(779, 81);
            this.TxtSiparisUrunID.Name = "TxtSiparisUrunID";
            this.TxtSiparisUrunID.Size = new System.Drawing.Size(142, 22);
            this.TxtSiparisUrunID.TabIndex = 22;
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 424);
            this.Controls.Add(this.TxtSiparisUrunID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtSiparisKuryeID);
            this.Controls.Add(this.SiparişteKuryeListele);
            this.Controls.Add(this.SiparişGüncelle);
            this.Controls.Add(this.SiparişAra);
            this.Controls.Add(this.SiparisSil);
            this.Controls.Add(this.SiparisEkle);
            this.Controls.Add(this.SiparişListele);
            this.Controls.Add(this.SiparistenMenüye);
            this.Controls.Add(this.comboSiparisMusteri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSiparisID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Siparis";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSiparisID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboSiparisMusteri;
        private System.Windows.Forms.Button SiparistenMenüye;
        private System.Windows.Forms.Button SiparişListele;
        private System.Windows.Forms.Button SiparisEkle;
        private System.Windows.Forms.Button SiparisSil;
        private System.Windows.Forms.Button SiparişAra;
        private System.Windows.Forms.Button SiparişGüncelle;
        private System.Windows.Forms.Button SiparişteKuryeListele;
        private System.Windows.Forms.TextBox TxtSiparisKuryeID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtSiparisUrunID;
    }
}