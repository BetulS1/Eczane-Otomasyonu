namespace EczaneOtomasyonu
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.barkod = new System.Windows.Forms.TextBox();
            this.uretici = new System.Windows.Forms.TextBox();
            this.ilacad = new System.Windows.Forms.TextBox();
            this.adet = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "STOK EKLE / SİL ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(78, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "BARKOD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(78, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "ÜRETİCİ FİRMA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(78, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "İLAÇ ADI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(78, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "ADET";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.White;
            this.ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ekle.FlatAppearance.BorderSize = 10;
            this.ekle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ekle.Location = new System.Drawing.Point(432, 378);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(115, 37);
            this.ekle.TabIndex = 25;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.White;
            this.sil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sil.FlatAppearance.BorderSize = 10;
            this.sil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sil.Location = new System.Drawing.Point(288, 378);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(115, 37);
            this.sil.TabIndex = 26;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // barkod
            // 
            this.barkod.BackColor = System.Drawing.Color.White;
            this.barkod.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkod.Location = new System.Drawing.Point(392, 122);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(155, 26);
            this.barkod.TabIndex = 27;
            this.barkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uretici
            // 
            this.uretici.BackColor = System.Drawing.Color.White;
            this.uretici.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uretici.Location = new System.Drawing.Point(392, 178);
            this.uretici.Name = "uretici";
            this.uretici.Size = new System.Drawing.Size(155, 26);
            this.uretici.TabIndex = 29;
            this.uretici.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ilacad
            // 
            this.ilacad.BackColor = System.Drawing.Color.White;
            this.ilacad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacad.Location = new System.Drawing.Point(392, 230);
            this.ilacad.Name = "ilacad";
            this.ilacad.Size = new System.Drawing.Size(155, 26);
            this.ilacad.TabIndex = 30;
            this.ilacad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adet
            // 
            this.adet.BackColor = System.Drawing.Color.White;
            this.adet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adet.Location = new System.Drawing.Point(392, 284);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(155, 26);
            this.adet.TabIndex = 31;
            this.adet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(34, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 36);
            this.button3.TabIndex = 32;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(651, 536);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.ilacad);
            this.Controls.Add(this.uretici);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE OTOMASYONU STOK EKLE/SİL";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox barkod;
        private System.Windows.Forms.TextBox uretici;
        private System.Windows.Forms.TextBox ilacad;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.Button button3;
    }
}