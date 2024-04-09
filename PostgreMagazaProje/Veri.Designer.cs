namespace PostgreMagazaProje
{
    partial class Veri
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
            this.VeriMaasOrtalama = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VeridenMenüye = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // VeriMaasOrtalama
            // 
            this.VeriMaasOrtalama.Location = new System.Drawing.Point(36, 23);
            this.VeriMaasOrtalama.Name = "VeriMaasOrtalama";
            this.VeriMaasOrtalama.Size = new System.Drawing.Size(135, 86);
            this.VeriMaasOrtalama.TabIndex = 1;
            this.VeriMaasOrtalama.Text = "Şirketimizin Çalışanlar İçin Ortalama Maaş Değerini Göster";
            this.VeriMaasOrtalama.UseVisualStyleBackColor = true;
            this.VeriMaasOrtalama.Click += new System.EventHandler(this.VeriMaasOrtalama_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 234);
            this.dataGridView1.TabIndex = 2;
            // 
            // VeridenMenüye
            // 
            this.VeridenMenüye.Location = new System.Drawing.Point(701, 304);
            this.VeridenMenüye.Name = "VeridenMenüye";
            this.VeridenMenüye.Size = new System.Drawing.Size(135, 86);
            this.VeridenMenüye.TabIndex = 3;
            this.VeridenMenüye.Text = "MENÜ İÇİN";
            this.VeridenMenüye.UseVisualStyleBackColor = true;
            this.VeridenMenüye.Click += new System.EventHandler(this.VeridenMenüye_Click);
            // 
            // Veri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.VeridenMenüye);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.VeriMaasOrtalama);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Veri";
            this.Text = "Veri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button VeriMaasOrtalama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button VeridenMenüye;
    }
}