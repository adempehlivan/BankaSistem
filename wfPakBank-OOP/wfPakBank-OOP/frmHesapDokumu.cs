using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPakBank_OOP
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
        public static string HesapID; //static oarak tanımlanan değişkenler, class ın new ile örneği (instance) oluşturulmadan çağrılabilir.
        public static string HesapNo;

        private void frmHesapDokumu_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text.Trim() != "")
            {
                cHesap hsp = new cHesap();
                hsp = hsp.HesapBilgileriGoster(txtHesapNo.Text);
                txtAdi.Text = hsp.Adi;
                txtSoyadi.Text = hsp.Soyadi;
                txtTcNo.Text = hsp.TCKNo;
                txtHesapTuru.Text = hsp.IslemTuru;
                txtTarih.Text = hsp.Tarih;
                cHesapHareket hh = new cHesapHareket();
                hh.HesapHareketleriGoster(txtHesapNo.Text, lvHareketler);
                ToplamlariGoster();
            }
        }

        private void ToplamlariGoster()
        {
            double toplamYatan = 0;
            double toplamCekilen = 0;
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
        }

        private void btnParaIslemleri_Click(object sender, EventArgs e)
        {       
            HesapID = lvHareketler.Items[0].SubItems[0].Text;
            HesapNo = txtHesapNo.Text;
            frmParaIslemleri frm = new frmParaIslemleri();
            frm.ShowDialog();
            cHesapHareket hh = new cHesapHareket();
            hh.HesapHareketleriGoster(txtHesapNo.Text, lvHareketler);                    
            ToplamlariGoster();
        }
       
        //private void pdocHesap_PrintPage(object sender, PrintPageEventArgs e)
        //{
            
        //}

        private void btnYazici_Click(object sender, EventArgs e)
        {
            ppdHesap.ShowDialog();
        }

        int k = 0;
        private void pdocHesap_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Müşteri : " + txtAdi.Text + " " + txtSoyadi.Text, fntBaslik, sb, 100, 100, fmt);
            e.Graphics.DrawString("Hesap NO : " + txtHesapNo.Text, fntBaslik, sb, 100, 130, fmt);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntBaslik, sb, 650, 110, fmt);
            e.Graphics.DrawString("HESAP HARAKETLERİ", fntBaslik, sb, 300, 180, fmt);
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

                if (i % 22 == 0 && i != 0)
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
            j++;
            e.Graphics.DrawString("Toplam Yatan : ", fntBaslik, sb, 320, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamYatan.Text, fntBaslik, sb, 580, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            j++;
            e.Graphics.DrawString("Toplam Çekilen : ", fntBaslik, sb, 320, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtToplamCekilen.Text, fntBaslik, sb, 580, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Near;
            j++;
            e.Graphics.DrawString("Bakiye : ", fntBaslik, sb, 320, 300 + j * 30, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtBakiye.Text, fntBaslik, sb, 580, 300 + j * 30, fmt);
            k = 0;
        }
    }
}
