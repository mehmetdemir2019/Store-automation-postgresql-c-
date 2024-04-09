using System;
using System.Windows.Forms;

namespace PostgreMagazaProje
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.gris = new System.Windows.Forms.Button();
            this.sifree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifremiunuttum = new System.Windows.Forms.LinkLabel();
            this.kayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(94, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.Location = new System.Drawing.Point(255, 150);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(387, 30);
            this.kullaniciadi.TabIndex = 2;
            this.kullaniciadi.TextChanged += new System.EventHandler(this.kullaniciadi_TextChanged);
            // 
            // gris
            // 
            this.gris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gris.Location = new System.Drawing.Point(371, 267);
            this.gris.Name = "gris";
            this.gris.Size = new System.Drawing.Size(120, 51);
            this.gris.TabIndex = 4;
            this.gris.Text = "Giriş Yap";
            this.gris.UseVisualStyleBackColor = true;
            this.gris.Click += new System.EventHandler(this.gris_Click);
            // 
            // sifree
            // 
            this.sifree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifree.Location = new System.Drawing.Point(255, 212);
            this.sifree.Name = "sifree";
            this.sifree.PasswordChar = '*';
            this.sifree.Size = new System.Drawing.Size(387, 30);
            this.sifree.TabIndex = 6;
            this.sifree.TextChanged += new System.EventHandler(this.sifree_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(161, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // sifremiunuttum
            // 
            this.sifremiunuttum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifremiunuttum.AutoSize = true;
            this.sifremiunuttum.LinkColor = System.Drawing.Color.Black;
            this.sifremiunuttum.Location = new System.Drawing.Point(543, 245);
            this.sifremiunuttum.Name = "sifremiunuttum";
            this.sifremiunuttum.Size = new System.Drawing.Size(99, 16);
            this.sifremiunuttum.TabIndex = 7;
            this.sifremiunuttum.TabStop = true;
            this.sifremiunuttum.Text = "Şifremi Unuttum";
            this.sifremiunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sifremiunuttum_LinkClicked_1);
            // 
            // kayıtol
            // 
            this.kayıtol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayıtol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtol.Location = new System.Drawing.Point(546, 277);
            this.kayıtol.Name = "kayıtol";
            this.kayıtol.Size = new System.Drawing.Size(92, 35);
            this.kayıtol.TabIndex = 8;
            this.kayıtol.Text = "Kayıt Ol";
            this.kayıtol.UseVisualStyleBackColor = true;
            this.kayıtol.Click += new System.EventHandler(this.kayıtol_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(827, 469);
            this.Controls.Add(this.kayıtol);
            this.Controls.Add(this.sifremiunuttum);
            this.Controls.Add(this.sifree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gris);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.Button gris;
        private System.Windows.Forms.TextBox sifree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel sifremiunuttum;
        private System.Windows.Forms.Button kayıtol;
    }
}