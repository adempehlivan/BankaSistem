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
            //frmHesapDokumu frm = new frmHesapDokumu();//burda yeni form oluşturdugu için ordaki ıdleri alamıyor boş oluyor.
            //txtHesapId.Text = frmHesapDokumu.HesapID;
            //txtHesapNo.Text = frmHesapDokumu.HesapNo; 
        }

        public void HesapDIveNO(string ID,string NO)
        {
            txtHesapId.Text = ID;
            txtHesapNo.Text = NO;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
            HareketYaz.WriteLine(txtHesapId.Text + ";" + txtHesapNo.Text + ";" + txtTarih.Text + ";" + txtTutar.Text + ";" + cbIslemTipleri.SelectedItem.ToString());
            HareketYaz.Close();
            MessageBox.Show("İşleminiz Tamamlanmıştır");
            this.Close();
        }
    }
}
