using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.BLL;

namespace OkulApp
{
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();

        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            try
            {
                bool sonuc = obl.OgrenciKaydet(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu Numara daha önce kaydedilmiş!! ");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!");
            }
        }

    }


   /* interface TransferIslemleri
    {
        int Eft(string gondereniban, string aliciiban, double tutar);
        int Havale(string gondereniban, string aliciiban, double tutar);
    }*/


}

