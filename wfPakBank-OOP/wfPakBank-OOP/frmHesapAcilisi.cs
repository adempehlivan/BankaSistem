using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPakBank_OOP
{
    public partial class frmHesapAcilisi : Form
    {
        public frmHesapAcilisi()
        {
            InitializeComponent();
        }

        private void frmHesapAcilisi_Load(object sender, EventArgs e)
        {
            this.Top = 0; //form zaten bunun içinde açılcak mdi parent oldugu için dışarayıa çıkamayacak
            this.Left = 0;
            cHesap hsp = new cHesap();
            lblHesapId.Text = hsp.SonIDBul().ToString();
            lblHesapNo.Text = hsp.HesapNumarasiOlustur();
            lblTarih.Text = DateTime.Now.ToShortDateString();
            cbHesapTurleri.SelectedIndex = 0;
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyAdi.Text.Trim() != "" && txtTcNo.Text.Trim() != "" && txtBakiye.Text.Trim() != "")
            {
                cHesap hsp = new cHesap();
                hsp.ID = Convert.ToInt32(lblHesapId.Text);
                hsp.HesapNo = lblHesapNo.Text;
                hsp.Tarih = lblTarih.Text;
                hsp.Adi = txtAdi.Text;
                hsp.Soyadi = txtSoyAdi.Text;
                hsp.TCKNo = txtTcNo.Text;
                hsp.Bakiye = Convert.ToDouble(txtBakiye.Text);
                hsp.IslemTuru = cbHesapTurleri.SelectedItem.ToString();               
                //bool Sonuc = hsp.HesapEkle(Convert.ToInt32(lblHesapId.Text), lblHesapNo.Text, lblTarih.Text, txtAdi, txtSoyAdi, txtTcNo, txtBakiye, cbHesapTurleri.SelectedItem.ToString());
                bool Sonuc = hsp.HesapEkle(hsp);
                if (Sonuc)
                {
                    cHesapHareket hh = new cHesapHareket();
                    hh.ID = hsp.ID;
                    hh.HesapNo = hsp.HesapNo;
                    hh.Tarih = hsp.Tarih;
                    hh.Tutar = hsp.Bakiye;
                    hh.IslemTipi = "yatan";
                    //Sonuc = hh.HesapHareketEkle(Convert.ToInt32(lblHesapId.Text), lblHesapNo.Text, lblTarih.Text, txtBakiye, "yatan");
                    Sonuc = hh.HesapHareketEkle(hh);
                    if (Sonuc)
                    {
                        MessageBox.Show("Yeni Hesap Bilgileri Oluşturuldu.Lütfen HesapNo ' sunu not alınız.");
                        temizle();
                        lblHesapId.Text = hsp.SonIDBul().ToString();
                        lblHesapNo.Text = hsp.HesapNumarasiOlustur();                      
                    }
                    else
                    {
                        MessageBox.Show("Hesap Hareketleri Kayıt Edilemedi");
                    }
                }
                else
                {
                    MessageBox.Show("Girilmesi zorunlu alanları boş bırakmayınız!","DİKKAT EKSİK BİLGİ!");
                }

            }
        }

        private void temizle()
        {         
            txtAdi.Clear();
            txtSoyAdi.Clear();
            txtTcNo.Clear();
            txtBakiye.Clear();
            txtAdi.Focus();
        }

    }
}
