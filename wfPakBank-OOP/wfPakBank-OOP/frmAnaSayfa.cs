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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mIYeniHesapAc_Click(object sender, EventArgs e)
        {
            frmHesapAcilisi frm = new frmHesapAcilisi();
            FormAcikmi(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void mIHesapDokumu_Click(object sender, EventArgs e)
        {
            frmHesapDokumu frm = new frmHesapDokumu();
            FormAcikmi(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                if (AcilacakForm.Name == this.MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }
        }

        private void mICikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
