
namespace EczaneOtomasyonu
{
    partial class Form14
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.label1 = new System.Windows.Forms.Label();
            this.satis_islemi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uretici = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ilacad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kullanım_amaci = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.barkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fatura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(84, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "SATIŞ İŞLEMLERİ ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // satis_islemi
            // 
            this.satis_islemi.BackColor = System.Drawing.Color.White;
            this.satis_islemi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satis_islemi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.satis_islemi.Location = new System.Drawing.Point(807, 482);
            this.satis_islemi.Name = "satis_islemi";
            this.satis_islemi.Size = new System.Drawing.Size(96, 47);
            this.satis_islemi.TabIndex = 31;
            this.satis_islemi.Text = "SATIŞ YAP  ";
            this.satis_islemi.UseVisualStyleBackColor = false;
            this.satis_islemi.Click += new System.EventHandler(this.satis_islemi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(40, 96);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(748, 468);
            this.dataGridView1.TabIndex = 32;
            // 
            // uretici
            // 
            this.uretici.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uretici.Location = new System.Drawing.Point(823, 201);
            this.uretici.Name = "uretici";
            this.uretici.Size = new System.Drawing.Size(155, 26);
            this.uretici.TabIndex = 40;
            this.uretici.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uretici.TextChanged += new System.EventHandler(this.uretici_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(823, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "ÜRETİCİ FİRMA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilacad
            // 
            this.ilacad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacad.Location = new System.Drawing.Point(823, 137);
            this.ilacad.Name = "ilacad";
            this.ilacad.Size = new System.Drawing.Size(155, 26);
            this.ilacad.TabIndex = 38;
            this.ilacad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ilacad.TextChanged += new System.EventHandler(this.ilacad_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(823, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "İLAÇ ADI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kullanım_amaci
            // 
            this.kullanım_amaci.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanım_amaci.Location = new System.Drawing.Point(823, 265);
            this.kullanım_amaci.Name = "kullanım_amaci";
            this.kullanım_amaci.Size = new System.Drawing.Size(155, 26);
            this.kullanım_amaci.TabIndex = 42;
            this.kullanım_amaci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kullanım_amaci.TextChanged += new System.EventHandler(this.kullanım_amaci_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(823, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 26);
            this.label8.TabIndex = 41;
            this.label8.Text = "KULLANIM AMACI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barkod
            // 
            this.barkod.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkod.Location = new System.Drawing.Point(823, 329);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(155, 26);
            this.barkod.TabIndex = 44;
            this.barkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barkod.TextChanged += new System.EventHandler(this.barkod_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(826, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "BARKOD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tutar
            // 
            this.tutar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tutar.BackColor = System.Drawing.Color.White;
            this.tutar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tutar.Location = new System.Drawing.Point(826, 414);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(106, 47);
            this.tutar.TabIndex = 45;
            this.tutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(41, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 46;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(826, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 47);
            this.label5.TabIndex = 47;
            this.label5.Text = "TOPLAM FİYAT: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(938, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 47);
            this.label6.TabIndex = 48;
            this.label6.Text = "TL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatura
            // 
            this.fatura.BackColor = System.Drawing.Color.White;
            this.fatura.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fatura.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fatura.Location = new System.Drawing.Point(909, 482);
            this.fatura.Name = "fatura";
            this.fatura.Size = new System.Drawing.Size(99, 47);
            this.fatura.TabIndex = 49;
            this.fatura.Text = "SATIŞ BİLGİLERİ";
            this.fatura.UseVisualStyleBackColor = false;
            this.fatura.Click += new System.EventHandler(this.fatura_Click);
            // 
            // Form14
            // 
            this.AcceptButton = this.satis_islemi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1054, 576);
            this.Controls.Add(this.fatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanım_amaci);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uretici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ilacad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.satis_islemi);
            this.Controls.Add(this.label1);
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE OTOMASYONU SATIŞ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button satis_islemi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox uretici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ilacad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kullanım_amaci;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox barkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button fatura;
    }
}