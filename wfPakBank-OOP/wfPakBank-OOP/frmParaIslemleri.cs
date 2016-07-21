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

namespace wfPakBank_OOP
{
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }

        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            cbIslemTipleri.SelectedIndex = 1; // cekilen islem tipini seçili hale getiriyoruz           
            txtHesapId.Text = frmHesapDokumu.HesapID;
            txtHesapNo.Text = frmHesapDokumu.HesapNo;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            cHesapHareket hh = new cHesapHareket();
            hh.ID = Convert.ToInt32(txtHesapId.Text);
            hh.HesapNo = txtHesapNo.Text;
            hh.Tarih = txtTarih.Text;
            hh.Tutar = Convert.ToDouble(txtTutar.Text);
            hh.IslemTipi = cbIslemTipleri.SelectedItem.ToString();
            if (hh.HesapHareketEkle(hh))
            {
                MessageBox.Show("İşleminiz Tamamlandı");
                this.Close();
            }
        }
    }
}
