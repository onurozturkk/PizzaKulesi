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
    public partial class DuzenleForm : Form
    {
        public event EventHandler DegisiklikYapildi;

        private readonly PizzaKulesiContext db;
        public DuzenleForm(PizzaKulesiContext db)
        {
            this.db = db;
            InitializeComponent();
            PizzalariListele();
            MalzemeleriListele();
        }
        protected virtual void DegisiklikYapildiginda(EventArgs args)
        {
            if (DegisiklikYapildi != null)
            {
                DegisiklikYapildi(this, args);
            }
        }

        private void MalzemeleriListele()
        {
            lstMalzemeler.DataSource = db.EkstraMalzemeler.ToList();
        }

        private void PizzalariListele()
        {
            lstPizzalar.DataSource = db.Pizzalar.ToList();
        }

        private void btnPizzaEkle_Click(object sender, EventArgs e)
        {
            if (txtPizzaCesidi.Text == "")
            {
                MessageBox.Show("Boş Yapma :D");
                return;
            }
            db.Pizzalar.Add(new Pizza { Cesit = txtPizzaCesidi.Text });
            db.SaveChanges();
            PizzalariListele();
            txtPizzaCesidi.Clear();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnMalzemeEKle_Click(object sender, EventArgs e)
        {
            if (txtMalzeme.Text == "")
            {
                MessageBox.Show("Boş Yapma :D");
                return;
            }
            db.EkstraMalzemeler.Add(new EkstraMalzeme { MalzemeAd = txtMalzeme.Text });
            db.SaveChanges();
            MalzemeleriListele();
            txtMalzeme.Clear();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnPizzaSil_Click(object sender, EventArgs e)
        {
            if (lstPizzalar.SelectedIndex < 0)
            {
                return;
            }

            var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
            db.Pizzalar.Remove(secilenPizza);
            db.SaveChanges();
            PizzalariListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            if (lstMalzemeler.SelectedIndex < 0)
            {
                return;
            }

            var secilenMalzeme = (EkstraMalzeme)lstMalzemeler.SelectedItem;
            db.EkstraMalzemeler.Remove(secilenMalzeme);
            db.SaveChanges();
            MalzemeleriListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            ///DUZENLE
            btnIptal.Visible = btnKaydet.Visible = true;
            btnDuzenle.Visible = false;
            var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
            var secilenMalzeme = (EkstraMalzeme)lstMalzemeler.SelectedItem;
            txtPizzaCesidi.Text = secilenPizza.Cesit;
            txtMalzeme.Text = secilenMalzeme.MalzemeAd;
            btnMalzemeEKle.Enabled = btnPizzaEkle.Enabled = btnMalzemeSil.Enabled = btnPizzaSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPizzaCesidi.Text  == "" || txtMalzeme.Text == "")
            {
                MessageBox.Show("Boş yapma :D");
                return;
            }
            var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
            var secilenMalzeme = (EkstraMalzeme)lstMalzemeler.SelectedItem;

            secilenPizza.Cesit = txtPizzaCesidi.Text;
            secilenMalzeme.MalzemeAd = txtMalzeme.Text;
            db.SaveChanges();
            FormuResetle();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void FormuResetle()
        {
            MalzemeleriListele();
            PizzalariListele();
            txtMalzeme.Clear();
            txtPizzaCesidi.Clear();
            btnDuzenle.Visible = true;
            btnKaydet.Visible = false;
            btnIptal.Visible = false;
            btnMalzemeEKle.Enabled = btnPizzaEkle.Enabled = btnMalzemeSil.Enabled = btnPizzaSil.Enabled = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }
    }
}
