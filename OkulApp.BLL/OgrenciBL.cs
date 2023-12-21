using System;
using OkulApp.Model;
using System.Data.SqlClient;
using OkulApp.DAL;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciKaydet(Ogrenci ogr)
        {
            var hlp = new Helper();
            var p = new SqlParameter[]
            {
                new SqlParameter("@Ad", ogr.Ad),
                new SqlParameter("@Soyad", ogr.Soyad),
                new SqlParameter("@Numara", ogr.Numara)
            };

          return  hlp.ExecuteNonQuery("Insert into tblOgrenciler values (@Ad,@Soyad,@Numara", p) > 0;
           // SqlConnection cn = null;
           // SqlCommand cmd = null;
           // try
           // {
           //     using (cn = new SqlConnection(@"Data Source=DESKTOP-A556OS3\VERITABANI;Initial Catalog=OkulDB;Integrated Security=true"))
           //     {
           //         using (cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", cn))
           //         {
           //             SqlParameter[] p =
           //     {
           //         new SqlParameter("@Ad",ogr.Ad),
           //         new SqlParameter("@Soyad",ogr.Soyad),
           //         new SqlParameter("@Numara",ogr.Numara),
           //     };
           //             cmd.Parameters.AddRange(p);
           //             cn.Open();
           //             return cmd.ExecuteNonQuery() > 0;
           //         }
           //     }

            //     //MessageBox.Show(sonuc > 0 ? "Ekleme Başarılı" : "Ekleme Başarısız!!");

            // }
            // catch (SqlException ex)
            // {
            //     throw;
            //     /*switch (ex.Number)
            //     {
            //         case 2627:
            //             MessageBox.Show("Bu Numara daha önce kaydedilmiş!! ");
            //             break;
            //         default:
            //             MessageBox.Show("Veritabanı Hatası!");
            //             break;
            //     }*/
            // }
            // catch (Exception)
            // {
            //     throw;
            //     //MessageBox.Show("Bir Hata Oluştu!"); ;
            // }
            //// finally
            // //{
            //     /* if (cn != null && cn.State != ConnectionState.Closed)
            //      { cn.Close(); }
            //      cn.Dispose();*/



            // //}
        }

    }
}
