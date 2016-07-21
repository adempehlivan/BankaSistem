using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_PAKBANK
{
    public partial class frmHesapDokumu : Form
    {
        public frmHesapDokumu()
        {
            InitializeComponent();
        }
        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntDetay = new Font("Times New Roman", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
       // public static string HesapID; //static oarak tanımlanan değişkenler, class ın new ile örneği (instance) oluşturulmadan çağrılabilir.
       // public static string HesapNo;
        

        private void frmHesapDokumu_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 15;
        }

        private void btnParaIslemleri_Click(object sender, EventArgs e)
        {
            //HesaID ve HesapNo yu yukarda pubic tanımladik burdan onları gönderip frmParaIslemlerinden göreceğiz.
           // HesapID = lvHareketler.Items[0].SubItems[0].Text;
           // HesapNo = txtHesapNo.Text;
          
            frmParaIslemleri frm = new frmParaIslemleri();
            //ParaIslemleri ekranındaki HesapID ve HesapNo TextBox larının Modifiers özelliklerini Public yaptık.
            //frm.txtHesapId.Text = lvHareketler.Items[0].SubItems[0].Text;
            //frm.txtHesapNo.Text = lvHareketler.Items[0].SubItems[1].Text;

            //frmParaIslemler kısmında tanımladığımız pbulic HesapDIveNo metodunu burda dolduruyoruz.
            frm.HesapDIveNO(lvHareketler.Items[0].SubItems[0].Text, txtHesapNo.Text);
            frm.ShowDialog();    
            //ParaIslemleri formu kapatıldığında programın işleyişi burdan devam eder.
            HesapHaraketleriGoster();
            ToplamlariGoster();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {           
            if (txtHesapNo.Text.Trim() != "")
            {
                HesapBilgileriGoster();
                HesapHaraketleriGoster();
                ToplamlariGoster();
            }
        }
       
        private void ToplamlariGoster()
        {           
            //StreamReader DosyaOku = new StreamReader("HesapHareketleri.txt");
            //string okunan = DosyaOku.ReadLine();
            double toplamYatan = 0;
            double toplamCekilen = 0;
            //***********************************************************************************

            //-----------------------------------------------------------------------------------
            #region Hocanın ki
            for (int i = 0; i < lvHareketler.Items.Count; i++)
            {
                if (lvHareketler.Items[i].SubItems[4].Text == "yatan")
                {
                    toplamYatan += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                }
                else
                {
                    toplamCekilen += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                }
                txtToplamYatan.Text = toplamYatan.ToString();
                txtToplamCekilen.Text = toplamCekilen.ToString();
                txtBakiye.Text = (toplamYatan - toplamCekilen).ToString();
            } 
            #endregion
            //----------------------------------------------------------------------------------

            //***************************************************************************************
            //while (okunan != null)
            //{
            //    string[] Degerler = okunan.Split(';');
            //    if (txtHesapNo.Text == Degerler[1])
            //    {
            //        if (Degerler[4] == "yatan")
            //        {

            //            toplamYatan += (Convert.ToDouble(Degerler[3]));
            //        }
            //        else
            //        {
            //            toplamCekilen += (Convert.ToDouble(Degerler[3]));
            //        }
            //    }
                
            //    okunan = DosyaOku.ReadLine();
            //}
            //DosyaOku.Close();
            //txtToplamYatan.Text = toplamYatan.ToString();
            //txtToplamCekilen.Text = toplamCekilen.ToString();
            //txtBakiye.Text = (toplamYatan - toplamCekilen).ToString();
        }

        private void HesapHaraketleriGoster()
        {
            lvHareketler.Items.Clear();
            StreamReader DosyaOku = new StreamReader("HesapHareketleri.txt");
            string okunan = DosyaOku.ReadLine();
            int index = 0;
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                
                if (txtHesapNo.Text == Degerler[1])
                {
                    lvHareketler.Items.Add(Degerler[0]);
                    lvHareketler.Items[index].SubItems.Add(Degerler[1]);
                    lvHareketler.Items[index].SubItems.Add(Degerler[2]);
                    lvHareketler.Items[index].SubItems.Add(Degerler[3]);
                    lvHareketler.Items[index].SubItems.Add(Degerler[4]);
                    index++;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();  
        }

        private void HesapBilgileriGoster()
        {          
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (txtHesapNo.Text == Degerler[1])
                {
                    txtAdi.Text = Degerler[3];
                    txtSoyadi.Text = Degerler[4];
                    txtTcNo.Text = Degerler[5];
                    txtHesapTuru.Text = Degerler[7];
                    txtTarih.Text = Degerler[2];
                    break;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();         
        }

        int k = 0;
        private void pdocHesap_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Müşteri : " + txtAdi.Text + " " + txtSoyadi.Text, fntBaslik, sb, 100, 100,fmt);
            e.Graphics.DrawString("Hesap NO : " + txtHesapNo.Text, fntBaslik, sb, 100, 130, fmt);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntBaslik, sb, 650, 110, fmt);
            e.Graphics.DrawString("HESAP HARAKETLERİ", fntBaslik, sb, 300, 180, fmt);
            //Müşteri adı soyada hesapno : sağ tarafa tarih, listviev gibi bir başlıklar atalım altında çizgi olsun, listviev içindeki bütün hareketleri döngü ile basacağız.bitince bir çizgi daha sonra toplam yatan toplam çekilen bakiye bunları yazılacak           
            e.Graphics.DrawString("  ID        HesapNo        İşlemTarihi        İşlemTutarı         İşlemTipi", fntBaslik, sb, 100, 250, fmt);
            e.Graphics.DrawString("________________________________________________________", fntBaslik, sb, 100, 270, fmt);
            int j = 0;
            for (int i = k; i < lvHareketler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[0].Text, fntDetay, sb, 114, 300 + j * 30, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[1].Text, fntDetay, sb, 190, 300 + j * 30, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[2].Text, fntDetay, sb, 340, 300 + j * 30, fmt);
                fmt.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[3].Text, fntDetay, sb, 540, 300 + j * 30, fmt);
                fmt.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[4].Text, fntDetay, sb, 650, 300 + j * 30, fmt);
             
                if (i %22 == 0 && i != 0)
                {
                    e.HasMorePages = true;
                    k++;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                    j++;
                    k++;
                }
            }
            //j++; ;
            e.Graphics.DrawString("________________________________________________________", fntBaslik, sb, 100, 300 + j * 30, fmt);
            j ++;
            e.Graphics.DrawString("Toplam Yatan : ", fntBaslik, sb, 320, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamYatan.Text, fntBaslik, sb, 580, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            j ++;
            e.Graphics.DrawString("Toplam Çekilen : ", fntBaslik, sb, 320, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamCekilen.Text, fntBaslik, sb, 580, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            j ++;
            e.Graphics.DrawString("Bakiye : ", fntBaslik, sb, 320, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtBakiye.Text, fntBaslik, sb, 580, 300 + j * 30, fmt);
            k = 0;
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            ppdHesap.ShowDialog();
        }
       
    }
}
