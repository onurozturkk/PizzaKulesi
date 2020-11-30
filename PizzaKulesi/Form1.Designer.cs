
namespace PizzaKulesi
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
            if (disposing)
            {
                db.Dispose();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTeslimatAdresi = new System.Windows.Forms.TextBox();
            this.cboPizzaCesidi = new System.Windows.Forms.ComboBox();
            this.btnPizzaCesidi = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkstraMalzeme = new System.Windows.Forms.Button();
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkTeslim = new System.Windows.Forms.CheckBox();
            this.chkTeslimEdilenleriGizle = new System.Windows.Forms.CheckBox();
            this.clbMalzeme = new System.Windows.Forms.CheckedListBox();
            this.cboMusteri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.Ad = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnMusteriDuzenle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizza Çeşidi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eksta Malzemeler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teslimat Adresi";
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(12, 59);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(241, 21);
            this.txtMusteriAdSoyad.TabIndex = 4;
            // 
            // txtTeslimatAdresi
            // 
            this.txtTeslimatAdresi.Location = new System.Drawing.Point(12, 105);
            this.txtTeslimatAdresi.Multiline = true;
            this.txtTeslimatAdresi.Name = "txtTeslimatAdresi";
            this.txtTeslimatAdresi.Size = new System.Drawing.Size(241, 108);
            this.txtTeslimatAdresi.TabIndex = 5;
            // 
            // cboPizzaCesidi
            // 
            this.cboPizzaCesidi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzaCesidi.FormattingEnabled = true;
            this.cboPizzaCesidi.Location = new System.Drawing.Point(13, 343);
            this.cboPizzaCesidi.Name = "cboPizzaCesidi";
            this.cboPizzaCesidi.Size = new System.Drawing.Size(139, 23);
            this.cboPizzaCesidi.TabIndex = 6;
            // 
            // btnPizzaCesidi
            // 
            this.btnPizzaCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPizzaCesidi.Location = new System.Drawing.Point(117, 313);
            this.btnPizzaCesidi.Name = "btnPizzaCesidi";
            this.btnPizzaCesidi.Size = new System.Drawing.Size(38, 27);
            this.btnPizzaCesidi.TabIndex = 7;
            this.btnPizzaCesidi.Text = "+";
            this.btnPizzaCesidi.UseVisualStyleBackColor = true;
            this.btnPizzaCesidi.Click += new System.EventHandler(this.btnPizzaCesidi_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnEkle.Location = new System.Drawing.Point(166, 478);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 39);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnSil.Location = new System.Drawing.Point(374, 478);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 39);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.BackColor = System.Drawing.Color.Black;
            this.btnDuzenle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnDuzenle.Location = new System.Drawing.Point(467, 478);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(87, 39);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkstraMalzeme
            // 
            this.btnEkstraMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkstraMalzeme.Location = new System.Drawing.Point(134, 371);
            this.btnEkstraMalzeme.Name = "btnEkstraMalzeme";
            this.btnEkstraMalzeme.Size = new System.Drawing.Size(38, 27);
            this.btnEkstraMalzeme.TabIndex = 12;
            this.btnEkstraMalzeme.Text = "+";
            this.btnEkstraMalzeme.UseVisualStyleBackColor = true;
            this.btnEkstraMalzeme.Click += new System.EventHandler(this.btnEkstraMalzeme_Click);
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.AllowUserToAddRows = false;
            this.dgvSiparis.AllowUserToDeleteRows = false;
            this.dgvSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparis.BackgroundColor = System.Drawing.Color.White;
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column6});
            this.dgvSiparis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvSiparis.Location = new System.Drawing.Point(278, 44);
            this.dgvSiparis.MultiSelect = false;
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.ReadOnly = true;
            this.dgvSiparis.RowHeadersVisible = false;
            this.dgvSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparis.Size = new System.Drawing.Size(769, 428);
            this.dgvSiparis.TabIndex = 16;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Id";
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Musteri";
            this.Column1.HeaderText = "Müşteri Ad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TeslimDurumu";
            this.Column5.HeaderText = "Teslim Durumu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Pizza";
            this.Column2.HeaderText = "Pizzalar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VirgulluMalzeme";
            this.Column3.HeaderText = "Ekstra Malzemeler";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "AdresiYaz";
            this.Column6.HeaderText = "Adres";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // chkTeslim
            // 
            this.chkTeslim.AutoSize = true;
            this.chkTeslim.Location = new System.Drawing.Point(12, 478);
            this.chkTeslim.Name = "chkTeslim";
            this.chkTeslim.Size = new System.Drawing.Size(97, 19);
            this.chkTeslim.TabIndex = 17;
            this.chkTeslim.Text = "Teslim Edildi";
            this.chkTeslim.UseVisualStyleBackColor = true;
            // 
            // chkTeslimEdilenleriGizle
            // 
            this.chkTeslimEdilenleriGizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTeslimEdilenleriGizle.AutoSize = true;
            this.chkTeslimEdilenleriGizle.Location = new System.Drawing.Point(522, 19);
            this.chkTeslimEdilenleriGizle.Name = "chkTeslimEdilenleriGizle";
            this.chkTeslimEdilenleriGizle.Size = new System.Drawing.Size(149, 19);
            this.chkTeslimEdilenleriGizle.TabIndex = 18;
            this.chkTeslimEdilenleriGizle.Text = "Teslim Edilenleri Gizle";
            this.chkTeslimEdilenleriGizle.UseVisualStyleBackColor = true;
            this.chkTeslimEdilenleriGizle.CheckedChanged += new System.EventHandler(this.chkTeslimEdilenleriGizle_CheckedChanged);
            // 
            // clbMalzeme
            // 
            this.clbMalzeme.CheckOnClick = true;
            this.clbMalzeme.FormattingEnabled = true;
            this.clbMalzeme.Location = new System.Drawing.Point(13, 404);
            this.clbMalzeme.Name = "clbMalzeme";
            this.clbMalzeme.Size = new System.Drawing.Size(240, 68);
            this.clbMalzeme.TabIndex = 20;
            // 
            // cboMusteri
            // 
            this.cboMusteri.DisplayMember = "AdSoyad";
            this.cboMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMusteri.FormattingEnabled = true;
            this.cboMusteri.Location = new System.Drawing.Point(12, 277);
            this.cboMusteri.Name = "cboMusteri";
            this.cboMusteri.Size = new System.Drawing.Size(182, 23);
            this.cboMusteri.TabIndex = 21;
            this.cboMusteri.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Müşteri Ekle";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.Black;
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 220);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(69, 30);
            this.btnMusteriEkle.TabIndex = 24;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click_1);
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(13, 38);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(58, 15);
            this.Ad.TabIndex = 26;
            this.Ad.Text = "Ad Soyad";
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.BackColor = System.Drawing.Color.Black;
            this.btnIptal.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnIptal.Location = new System.Drawing.Point(279, 478);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(87, 39);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.BackColor = System.Drawing.Color.Black;
            this.btnMusteriDuzenle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(134, 246);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(128, 30);
            this.btnMusteriDuzenle.TabIndex = 28;
            this.btnMusteriDuzenle.Text = "Müşteri Düzenle";
            this.btnMusteriDuzenle.UseVisualStyleBackColor = false;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.Black;
            this.btnMusteriSil.Enabled = false;
            this.btnMusteriSil.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnMusteriSil.Location = new System.Drawing.Point(134, 219);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(69, 31);
            this.btnMusteriSil.TabIndex = 29;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1060, 535);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriDuzenle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMusteri);
            this.Controls.Add(this.clbMalzeme);
            this.Controls.Add(this.chkTeslimEdilenleriGizle);
            this.Controls.Add(this.chkTeslim);
            this.Controls.Add(this.dgvSiparis);
            this.Controls.Add(this.btnEkstraMalzeme);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnPizzaCesidi);
            this.Controls.Add(this.cboPizzaCesidi);
            this.Controls.Add(this.txtTeslimatAdresi);
            this.Controls.Add(this.txtMusteriAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Kulesi (Pizza Sipariş Takip)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.TextBox txtTeslimatAdresi;
        private System.Windows.Forms.ComboBox cboPizzaCesidi;
        private System.Windows.Forms.Button btnPizzaCesidi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkstraMalzeme;
        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.CheckBox chkTeslim;
        private System.Windows.Forms.CheckBox chkTeslimEdilenleriGizle;
        private System.Windows.Forms.CheckedListBox clbMalzeme;
        private System.Windows.Forms.ComboBox cboMusteri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnMusteriDuzenle;
        private System.Windows.Forms.Button btnMusteriSil;
    }
}

