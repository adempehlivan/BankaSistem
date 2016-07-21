using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_PAKBANK
{
    public partial class frmHesapAcilisi : Form
    {
        public frmHesapAcilisi()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void frmHesapAcilisi_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 15;
            lblTarih.Text = DateTime.Now.ToShortDateString();
            cbHesapTurleri.SelectedIndex = 0;
            SonHesapIDBul();
            HesapNumarasiOlustur();
        }

        private void HesapNumarasiOlustur()
        {
            bool Varmi = false;
            do
            {
                Varmi = HesapVarmi(); //hesapVarmi metodundan true döndüğü sürece tekrar hesap no oluşturulup baştan kontrol edilmeye devam ediyor.
            } while (Varmi);
        }

        private bool HesapVarmi()
        {         
            lblHesapNo.Text = "ACC" + rnd.Next(1000, 10000).ToString();
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (lblHesapNo.Text == Degerler[1])//eğer yeni hesapnoya sahip önceden tanımlı bir kayıt bulursa, dosyayı kapatıp yeniden hesapolustur metotdundaki döngüye true değeri ile dönüyor.
                {
                    DosyaOku.Close();
                    return true;
                    //HesapNumarasiOlustur(); // recursive methods (kendini çalıştıran metotlar)
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }

        private void SonHesapIDBul()
        {
            StreamWriter DosyaAc = new StreamWriter("HesapKartlari.txt", true); // FileMod.append yazcağımıza direkt true diyerek bunu tanımladık

            DosyaAc.Close();

            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            if (okunan == null)
            {
                lblHesapId.Text = "1";
            }
            else
            {
                while (okunan != null)
                {
                   string[] Degerler = okunan.Split(';');
                   lblHesapId.Text = (Convert.ToInt32(Degerler[0]) + 1).ToString();
                   okunan = DosyaOku.ReadLine();
                }
            }
            DosyaOku.Close();                    
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("HesapKartlari.txt", FileMode.Append); 
            //StreamWriter sw = StreamWriter(fs);
            if (txtAdi.Text.Trim() != "" && txtSoyAdi.Text.Trim() != "" && txtTcNo.Text.Trim() != "" && txtBakiye.Text.Trim() != "")
            {
                StreamWriter DosyaAc = new StreamWriter("HesapKartlari.txt", true);
                DosyaAc.WriteLine(lblHesapId.Text + ";" + lblHesapNo.Text + ";" + lblTarih.Text + ";" + txtAdi.Text + ";" + txtSoyAdi.Text + ";" + txtTcNo.Text + ";" + txtBakiye.Text + ";" + cbHesapTurleri.SelectedItem.ToString());
                DosyaAc.Close();


                StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
                HareketYaz.WriteLine(lblHesapId.Text + ";" + lblHesapNo.Text + ";" + lblTarih.Text + ";" + txtBakiye.Text + ";" + "yatan");
                HareketYaz.Close();

                MessageBox.Show("Yeni Hesap Bilgileri Oluşturuldu.Lütfen HesapNo ' sunu not alınız.");
                temizle();
                SonHesapIDBul();
                HesapNumarasiOlustur();
            }
            else
            {
                MessageBox.Show("Girilmesi zorunlu alanları boş bırakmayınız!","DİKKAT EKSİK BİLGİ!");
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
