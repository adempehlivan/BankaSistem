using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_PAKBANK
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mICikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // uygulamayı sonlandırır.
            //this.Close(); // aktif sayfayı kapatır.
        }

        private void mIYeniHesapAc_Click(object sender, EventArgs e)
        {
            frmHesapAcilisi frm = new frmHesapAcilisi();
            frm.ShowDialog(); // 2. pencere kapatmadan başka pencere açılmıyor -messagebox gibi-
        }

        private void mIHesapDokumu_Click(object sender, EventArgs e)
        {
            frmHesapDokumu frm = new frmHesapDokumu();
            frm.ShowDialog();
        }
    }
}
