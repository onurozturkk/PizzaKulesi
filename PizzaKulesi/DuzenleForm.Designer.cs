
namespace PizzaKulesi
{
    partial class DuzenleForm
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
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.txtPizzaCesidi = new System.Windows.Forms.TextBox();
            this.btnPizzaSil = new System.Windows.Forms.Button();
            this.btnPizzaEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnMalzemeEKle = new System.Windows.Forms.Button();
            this.txtMalzeme = new System.Windows.Forms.TextBox();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.ItemHeight = 15;
            this.lstPizzalar.Location = new System.Drawing.Point(14, 62);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(317, 214);
            this.lstPizzalar.TabIndex = 0;
            // 
            // txtPizzaCesidi
            // 
            this.txtPizzaCesidi.Location = new System.Drawing.Point(12, 35);
            this.txtPizzaCesidi.Name = "txtPizzaCesidi";
            this.txtPizzaCesidi.Size = new System.Drawing.Size(177, 21);
            this.txtPizzaCesidi.TabIndex = 2;
            // 
            // btnPizzaSil
            // 
            this.btnPizzaSil.BackColor = System.Drawing.Color.Black;
            this.btnPizzaSil.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnPizzaSil.Location = new System.Drawing.Point(266, 17);
            this.btnPizzaSil.Name = "btnPizzaSil";
            this.btnPizzaSil.Size = new System.Drawing.Size(65, 39);
            this.btnPizzaSil.TabIndex = 29;
            this.btnPizzaSil.Text = "Sil";
            this.btnPizzaSil.UseVisualStyleBackColor = false;
            this.btnPizzaSil.Click += new System.EventHandler(this.btnPizzaSil_Click);
            // 
            // btnPizzaEkle
            // 
            this.btnPizzaEkle.BackColor = System.Drawing.Color.Black;
            this.btnPizzaEkle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnPizzaEkle.Location = new System.Drawing.Point(195, 17);
            this.btnPizzaEkle.Name = "btnPizzaEkle";
            this.btnPizzaEkle.Size = new System.Drawing.Size(65, 39);
            this.btnPizzaEkle.TabIndex = 28;
            this.btnPizzaEkle.Text = "Ekle";
            this.btnPizzaEkle.UseVisualStyleBackColor = false;
            this.btnPizzaEkle.Click += new System.EventHandler(this.btnPizzaEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.BackColor = System.Drawing.Color.Black;
            this.btnDuzenle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnDuzenle.Location = new System.Drawing.Point(256, 282);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(182, 39);
            this.btnDuzenle.TabIndex = 30;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pizza";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(367, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ekstra Malzeme";
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMalzemeSil.BackColor = System.Drawing.Color.Black;
            this.btnMalzemeSil.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnMalzemeSil.Location = new System.Drawing.Point(621, 17);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(65, 39);
            this.btnMalzemeSil.TabIndex = 35;
            this.btnMalzemeSil.Text = "Sil";
            this.btnMalzemeSil.UseVisualStyleBackColor = false;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnMalzemeEKle
            // 
            this.btnMalzemeEKle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMalzemeEKle.BackColor = System.Drawing.Color.Black;
            this.btnMalzemeEKle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnMalzemeEKle.Location = new System.Drawing.Point(550, 17);
            this.btnMalzemeEKle.Name = "btnMalzemeEKle";
            this.btnMalzemeEKle.Size = new System.Drawing.Size(65, 39);
            this.btnMalzemeEKle.TabIndex = 34;
            this.btnMalzemeEKle.Text = "Ekle";
            this.btnMalzemeEKle.UseVisualStyleBackColor = false;
            this.btnMalzemeEKle.Click += new System.EventHandler(this.btnMalzemeEKle_Click);
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalzeme.Location = new System.Drawing.Point(367, 35);
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.Size = new System.Drawing.Size(177, 21);
            this.txtMalzeme.TabIndex = 33;
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.ItemHeight = 15;
            this.lstMalzemeler.Location = new System.Drawing.Point(369, 62);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(317, 214);
            this.lstMalzemeler.TabIndex = 32;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKaydet.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnKaydet.Location = new System.Drawing.Point(78, 327);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(182, 39);
            this.btnKaydet.TabIndex = 37;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.BackColor = System.Drawing.Color.Black;
            this.btnIptal.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnIptal.Location = new System.Drawing.Point(433, 327);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(182, 39);
            this.btnIptal.TabIndex = 38;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // DuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(702, 390);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMalzemeSil);
            this.Controls.Add(this.btnMalzemeEKle);
            this.Controls.Add(this.txtMalzeme);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnPizzaSil);
            this.Controls.Add(this.btnPizzaEkle);
            this.Controls.Add(this.txtPizzaCesidi);
            this.Controls.Add(this.lstPizzalar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "DuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PizzaCesidiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.TextBox txtPizzaCesidi;
        private System.Windows.Forms.Button btnPizzaSil;
        private System.Windows.Forms.Button btnPizzaEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Button btnMalzemeEKle;
        private System.Windows.Forms.TextBox txtMalzeme;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}