using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Enumerables
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<string> cities = new List<string>();
        private void frmMain_Load(object sender, EventArgs e)
        {
            lstDuz.Items.Add("Elma");
            lstDuz.Items.Add("Armut");
            lstDuz.Items.Add("Kiraz");
            lstDuz.Items.AddRange(new string[] { "Vişne", "Karpuz", "Limon" });

            cities.Add("Ankara");
            cities.Add("Kars");
            cities.Add("Erzurum");
            cities.Add("Hatay");
            lstBaglanti.DataSource = cities;

            lstCoklu.Items.AddRange(new string[] { "Galatasaray", "Fenerbahçe", "Beşiktaş",
                                                   "Trabzonspor", "Ankaragücü", "Kasımpaşa",
                                                   "Antalyaspor", "Sivasspor", "Kayserispor"});
        }

        private void btnEkleDuz_Click(object sender, EventArgs e)
        {
            erpWarning.Clear();
            if(string.IsNullOrEmpty(txtDuz.Text))
            {
                erpWarning.SetError(txtDuz, "Değer giriniz");
                return;
            }
            if (lstDuz.Items.Contains(txtDuz.Text))
            {
                erpWarning.SetError(txtDuz, "Zaten var");
                return;
            }

            //if (lstDuz.Items.IndexOf(txtDuz.Text) > -1)
            //{
                    //Üstteki ile aynı
            //}
            lstDuz.Items.Add(txtDuz.Text);
            txtDuz.Clear();
            txtDuz.Focus();
        }

        private void btnDuzTemizle_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lstDuz.Items.Clear();
            }
        }

        private void btnSilDuz_Click(object sender, EventArgs e)
        {
            if (lstDuz.SelectedItem != null)
            {
                lstDuz.Items.Remove(lstDuz.SelectedItems);
            }
        }

        private void txtDuz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEkleDuz_Click(null, null);
            }
        }

        private void btnBaglantiEkle_Click(object sender, EventArgs e)
        {
            if (!cities.Contains(txtBaglanti.Text))
            {
                cities.Add(txtBaglanti.Text);
                lstBaglanti.DataSource = null;
                lstBaglanti.DataSource = cities;
            }
        }

        private void btnCokluSil_Click(object sender, EventArgs e)
        {
            if (lstCoklu.SelectedItems.Count > 0)
            {
                var deleteArray = new string[lstCoklu.SelectedItems.Count];
                lstCoklu.SelectedItems.CopyTo(deleteArray, 0);

                foreach(var s in deleteArray)
                {
                    lstCoklu.Items.Remove(s);
                }
            }
        }
    }
}


/*
 Bir alışveriş listesinde yer alan ürünleri sepete tekli veya çoklu ekleme, toplu veya
 çok sepetten çıkarma işlemleri yapılacak

 her eklemede ekranda bir yerde sepette ürünleri toplam fiyatı da yazacak
 */