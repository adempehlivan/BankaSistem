using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPakBank_OOP
{
    class cHesap
    {
        private int _iD;
        private string _hesapNo;
        private string _tarih;
        private string _adi;
        private string _soyadi;
        private string _tCKNo;
        private double _bakiye;
        private string _islemTuru;

        #region Properties
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public string HesapNo
        {
            get { return _hesapNo; }
            set { _hesapNo = value; }
        }

        public string Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }

        public string Soyadi
        {
            get { return _soyadi; }
            set { _soyadi = value; }
        }

        public string TCKNo
        {
            get { return _tCKNo; }
            set { _tCKNo = value; }
        }

        public double Bakiye
        {
            get { return _bakiye; }
            set { _bakiye = value; }
        }


        public string IslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
        } 
        #endregion

        Random rnd = new Random();

        public int SonIDBul()
        {
            int ID = 0;
            StreamWriter DosyaAc = new StreamWriter("HesapKartlari.txt", true); // FileMod.append yazcağımıza direkt true diyerek bunu tanımladık
            DosyaAc.Close();

            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            if (okunan == null)
            {
                ID = 1;
            }
            else
            {
                while (okunan != null)
                {
                    string[] Degerler = okunan.Split(';');
                    ID = Convert.ToInt32(Degerler[0]) +1;
                    okunan = DosyaOku.ReadLine();
                }
            }
            DosyaOku.Close();
            return ID;
        }

        public string HesapNumarasiOlustur()
        {
            string HesapNO = "";
            bool Varmi = false;
            do
            {
                HesapNO =  "ACC" + rnd.Next(1000, 10000).ToString();
                Varmi = HesapVarmi(HesapNO); //hesapVarmi metodundan true döndüğü sürece tekrar hesap no oluşturulup baştan kontrol edilmeye devam ediyor.
            } while (Varmi);
            return HesapNO;
        }

        private bool HesapVarmi(string HesapNO)
        {          
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (HesapNO == Degerler[1])
                {
                    DosyaOku.Close();
                    return true;                   
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }

        public bool HesapEkle(int HesapID, string HesapNO, string Tarih, TextBox Adi, TextBox Soyadi, TextBox TCKNo, TextBox Bakiye, string HesapTuru )
        {
            StreamWriter DosyaAc = new StreamWriter("HesapKartlari.txt", true);
            DosyaAc.WriteLine(HesapID + ";" + HesapNO + ";" + Tarih + ";" + Adi.Text + ";" + Soyadi.Text + ";" + TCKNo.Text + ";" + Bakiye.Text + ";" + HesapTuru);
            DosyaAc.Close();
            return true;
        }

        public bool HesapEkle(cHesap hsp) //encapsüle yaptıklarımızı çalıştırmak için
        {
            StreamWriter DosyaAc = new StreamWriter("HesapKartlari.txt", true);
            DosyaAc.WriteLine(hsp._iD + ";" + hsp._hesapNo + ";" + hsp._tarih + ";" + hsp._adi + ";" + hsp._soyadi + ";" + hsp._tCKNo + ";" + hsp._bakiye + ";" + hsp._islemTuru);
            DosyaAc.Close();
            return true;
        }

        public cHesap HesapBilgileriGoster(string HesapNo)
        {
            cHesap h = new cHesap();
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (HesapNo == Degerler[1])
                {
                    h._adi = Degerler[3];
                    h._soyadi = Degerler[4];
                    h._tCKNo = Degerler[5];
                    h._islemTuru = Degerler[7];
                    h._tarih = Degerler[2];
                    break;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return h;
        }      
    }
}
