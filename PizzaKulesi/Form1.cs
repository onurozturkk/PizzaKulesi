using PizzaKulesi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaKulesi
{
    public partial class Form1 : Form
    {
        
        readonly PizzaKulesiContext db = new PizzaKulesiContext();
        public Form1()
        {
            InitializeComponent();
            dgvSiparis.AutoGenerateColumns = false;
            SiparisleriListele();
            PizzalariListele();
            MalzemeleriListele();
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            var filtreMusteriler = db.Musteriler.OrderBy(x => x.AdSoyad).ToList();
            filtreMusteriler.Insert(0, new Musteri { AdSoyad = "Seçiniz" });
            cboMusteri.DataSource = filtreMusteriler;
        }

        private void MalzemeleriListele()
        {
            clbMalzeme.DataSource = db.EkstraMalzemeler.ToList();
        }

        private void PizzalariListele()
        {
            var filtrePizzalar = db.Pizzalar.OrderBy(x => x.Cesit).ToList();
            filtrePizzalar.Insert(0, new Pizza { Cesit = "Seçiniz" });
            cboPizzaCesidi.DataSource = filtrePizzalar;
        }

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {

            if (txtTeslimatAdresi.Text == "" || txtMusteriAdSoyad.Text == "")
            {
                MessageBox.Show("Bilgileri eksik girdiniz.");
                return;
            }
            var adSoyad = txtMusteriAdSoyad.Text;
            var adres = txtTeslimatAdresi.Text;
            if (btnMusteriEkle.Text == "Kaydet")
            {
                var secilenMusteri = (Musteri)cboMusteri.SelectedItem;
                secilenMusteri.AdSoyad = adSoyad;
                secilenMusteri.Adres = adres;
                MusteriFormuResetle();

                return;
            }
            db.Musteriler.Add(new Musteri { AdSoyad = adSoyad, Adres = adres });
            db.SaveChanges();
            txtTeslimatAdresi.Clear();
            txtMusteriAdSoyad.Clear();
            MusterileriListele();
        }
        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            var secilenMusteri = (Musteri)cboMusteri.SelectedItem;
            db.Musteriler.Remove(secilenMusteri);
            MusteriFormuResetle();
        }

        private void MusteriFormuResetle()
        {
            btnMusteriSil.Enabled = false;
            db.SaveChanges();
            btnMusteriEkle.Text = "Ekle";
            txtTeslimatAdresi.Clear();
            txtMusteriAdSoyad.Clear();
            MusterileriListele();
            SiparisleriListele();
        }

        private void SiparisleriListele()
        {
            IQueryable<Siparis> siparisler = db.Siparisler;
            if (chkTeslimEdilenleriGizle.Checked == true)
            {
                siparisler = siparisler.Where(x => x.TeslimDurumu == false);
            }
            dgvSiparis.DataSource = siparisler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cboMusteri.SelectedIndex == 0 || cboPizzaCesidi.SelectedIndex == 0)
            {
                MessageBox.Show("Pizza ve Müşteri seçimi yapınız");
                return;
            }

            if (btnEkle.Text == "Kaydet")
            {
                int seciliSiparisId = Convert.ToInt32(dgvSiparis.SelectedRows[0].Cells[0].Value);
                Siparis secilisiparis = db.Siparisler.FirstOrDefault(x => x.Id == seciliSiparisId);
                secilisiparis.Musteri = (Musteri)cboMusteri.SelectedItem;
                secilisiparis.Pizza = (Pizza)cboPizzaCesidi.SelectedItem;
                secilisiparis.EkstraMalzemeler = clbMalzeme.CheckedItems.OfType<EkstraMalzeme>().ToList();
                secilisiparis.TeslimDurumu = chkTeslim.Checked;
                db.SaveChanges();
                SiparisleriListele();
                FormuResetle();
                return;
            }

            Siparis siparis = new Siparis()
            {
                Musteri = (Musteri)cboMusteri.SelectedItem,
                Pizza = (Pizza)cboPizzaCesidi.SelectedItem,
                EkstraMalzemeler = clbMalzeme.CheckedItems.OfType<EkstraMalzeme>().ToList(),
                TeslimDurumu = chkTeslim.Checked == true ? true : false
        };
            db.Siparisler.Add(siparis);
            db.SaveChanges();
            SiparisleriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvSiparis.SelectedRows.Count <= 0)
            {
                return;
            }
            int seciliSiparisId = Convert.ToInt32(dgvSiparis.SelectedRows[0].Cells[0].Value);
            Siparis secilisiparis = db.Siparisler.FirstOrDefault(x => x.Id == seciliSiparisId);
            db.Siparisler.Remove(secilisiparis);
            db.SaveChanges();
            SiparisleriListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvSiparis.SelectedRows.Count <= 0)
            {
                return;
            }

            for (int i = 0; i < clbMalzeme.Items.Count; i++)
            {
                clbMalzeme.SetItemChecked(i, false);
            }
            int seciliSiparisId = Convert.ToInt32(dgvSiparis.SelectedRows[0].Cells[0].Value);
            Siparis secilisiparis = db.Siparisler.FirstOrDefault(x => x.Id == seciliSiparisId);
 
            cboMusteri.SelectedItem = secilisiparis.Musteri;
            cboPizzaCesidi.SelectedItem = secilisiparis.Pizza;

            for (int i = 0; i < clbMalzeme.Items.Count; i++)
            {
                var ekstraMalzeme = (EkstraMalzeme)clbMalzeme.Items[i];
                if (secilisiparis.EkstraMalzemeler.Any(x => x.Id == ekstraMalzeme.Id))
                {
                    clbMalzeme.SetItemChecked(i, true);
                }
            }

            //Düzenlenin Kaydetine geç
            btnEkle.Text = "Kaydet";
            btnIptal.Visible = true;
            dgvSiparis.Enabled = false;

            chkTeslim.Checked = secilisiparis.TeslimDurumu;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void FormuResetle()
        {
            for (int i = 0; i < clbMalzeme.Items.Count; i++)
            {
                clbMalzeme.SetItemChecked(i, false);
            }

            btnEkle.Text = "Ekle";
            btnIptal.Visible = false;
            dgvSiparis.Enabled = true;
            chkTeslim.Checked = false;
            MusterileriListele();
            PizzalariListele();
        }

        private void chkTeslimEdilenleriGizle_CheckedChanged(object sender, EventArgs e)
        {
            SiparisleriListele();
        }

        private void btnPizzaCesidi_Click(object sender, EventArgs e)
        {
            DuzenleForm frmPizzaDuzenle = new DuzenleForm(db);
            frmPizzaDuzenle.ShowDialog();
            frmPizzaDuzenle.DegisiklikYapildi += FrmPizzaDuzenle_DegisiklikYapildi;
        }

        private void FrmPizzaDuzenle_DegisiklikYapildi(object sender, EventArgs e)
        {
            PizzalariListele();
            SiparisleriListele();
            MalzemeleriListele();
        }

        private void btnEkstraMalzeme_Click(object sender, EventArgs e)
        {
            DuzenleForm frmPizzaDuzenle = new DuzenleForm(db);
            frmPizzaDuzenle.ShowDialog();
            frmPizzaDuzenle.DegisiklikYapildi += FrmPizzaDuzenle_DegisiklikYapildi1;
        }

        private void FrmPizzaDuzenle_DegisiklikYapildi1(object sender, EventArgs e)
        {
            PizzalariListele();
            SiparisleriListele();
            MalzemeleriListele();
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            if (cboMusteri.SelectedIndex <= 0)
            {
                return;
            }
            btnMusteriEkle.Text = "Kaydet";
            btnMusteriSil.Enabled = true;
            var secilenMusteri = (Musteri)cboMusteri.SelectedItem;
            txtMusteriAdSoyad.Text = secilenMusteri.AdSoyad;
            txtTeslimatAdresi.Text = secilenMusteri.Adres;
        }
    }
}
