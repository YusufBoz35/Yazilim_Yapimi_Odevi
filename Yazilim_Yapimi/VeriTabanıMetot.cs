using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Yazilim_Yapimi
{
    class VeriTabanıMetot
    {

        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");

        //
        //    KAYIT VE GİRİS YAPMA FONKSİYONLARI
        //
        public int giris_kontrol(string username, string parola)  //giris_kontrol fonksiyonu girilen kullanıcı adı ile parolanın eşleşmesi durumunda
        {                                                         // 1 eşleşmemesi durumunda 0 değerini döndürür                    
            int a;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanici WHERE kul_nick = @k1 AND kul_parola = @k2", baglanti);
            komut.Parameters.AddWithValue("@k1", username);
            komut.Parameters.AddWithValue("@k2", parola);
            SqlDataReader dr = komut.ExecuteReader();
            a = Convert.ToInt32(dr.Read());
            baglanti.Close();
            return a;

        }
 
        public void kullanici_kayit(string ad , string soyad ,string nick ,string parola ,string tc ,string mail ,string adres , string tel)
        {

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");

            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("insert into kullanici (kul_ad ,kul_soyad,kul_nick,kul_parola,kul_tc,kul_mail,kul_adres,kul_tel,kul_bakiye) values (@k1 , @k2 , @k3 ,@k4 ,@k5 ,@k6 , @k7 ,@k8 ,@k9)", baglanti);
            komut.Parameters.AddWithValue("@k1", ad);
            komut.Parameters.AddWithValue("@k2", soyad);
            komut.Parameters.AddWithValue("@k3", nick);
            komut.Parameters.AddWithValue("@k4", parola);
            komut.Parameters.AddWithValue("@k5", tc);
            komut.Parameters.AddWithValue("@k6", mail);
            komut.Parameters.AddWithValue("@k7", adres);
            komut.Parameters.AddWithValue("@k8", tel);
            komut.Parameters.AddWithValue("@k9", 0);
            komut.ExecuteNonQuery();
            
            baglanti.Close();

        }


        //
        //    PARA VE ÜRÜN EKLEME İSTEĞİ FONKSİYONLARI
        //

        public void bakiye_ekle(string user_para , int miktar)                      //Bakiye Ekleme Talebi Gönderir
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into para_istek (para_istek_user , para_istek_miktar ,para_istek_birim) values (@p1 ,@p2 ,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", user_para);
            komut.Parameters.AddWithValue("@p2", miktar);
            komut.Parameters.AddWithValue("@p3", "TL");
            komut.ExecuteNonQuery();
            baglanti.Close();

        }


        public void urun_ekle(string kullanici , string urun , string miktar)         //Urun Ekleme Talebi Gönderir
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into urun_istek (urun_istek_user , urun_istek_tip ,urun_istek_miktar ,urun_istek_birim) values (@p1 ,@p2 ,@p3 ,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", kullanici);
            komut.Parameters.AddWithValue("@p2", urun);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(miktar));
            komut.Parameters.AddWithValue("@p4", "Kg");
            komut.ExecuteNonQuery();

            baglanti.Close();

        }


        //
        //    Admin  silme işlemleri
        //


        public void para_istek_sil(string silinecek_istek_id)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");

            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From para_istek Where para_istek_id = @u1", baglanti);
            komutsil.Parameters.AddWithValue("@u1", silinecek_istek_id);//label1.Text
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            

        }



        public void urun_istek_sil(string silinecek_istek_id)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");

            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From urun_istek Where urun_istek_id = @u1", baglanti);
            komutsil.Parameters.AddWithValue("@u1", silinecek_istek_id);//label1.Text
            komutsil.ExecuteNonQuery();
            baglanti.Close();

        }


        //
        //     Admin  güncelleme işlemleri
        //


        public int bakiye_getir(string secilen_kul_nick)                       // guncelleme işlemi için önceki bakiyeyi veri tabanından çeker
        {
            int eski_bakiye ;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");
            
            
            SqlCommand komut = new SqlCommand("SELECT kul_bakiye FROM kullanici WHERE kul_nick = @kn", baglanti);
            komut.Parameters.AddWithValue("@kn", secilen_kul_nick);
           
            baglanti.Open();
            var bakiye = komut.ExecuteScalar();
            eski_bakiye = Convert.ToInt32(bakiye);
            baglanti.Close();

            return eski_bakiye;
        }

        public void para_guncelle(int yeni_bakiye , string kullanici)    // güncellenmiş bakiyey veri tabanına kaydeder
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");

            SqlCommand komut = new SqlCommand("update kullanici Set kul_bakiye = @k1 WHERE kul_nick = @k2 ", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@k1", yeni_bakiye);
            komut.Parameters.AddWithValue("@k2", kullanici);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public void miktar_guncelle(string secilen_kul_nick,string urun_tip , int urun_miktar)
        {
            int eski_miktar = 0;
            int yeni_miktar;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");

            SqlCommand komut = new SqlCommand();
            SqlCommand komut2 = new SqlCommand();

            switch (urun_tip)
            {
                case "Bugday":
                    komut = new SqlCommand("select bugday from kullanici WHERE kul_nick = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set bugday = @k1 WHERE kul_nick = @kn ", baglanti);
                    break;
                case "Arpa":
                    komut = new SqlCommand("select arpa from kullanici WHERE kul_nick = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set arpa = @k1 WHERE kul_nick = @kn ", baglanti);
                    break;
                case "Yulaf":
                    komut = new SqlCommand("select yulaf from kullanici WHERE kul_nick = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set yulaf = @k1 WHERE kul_nick = @kn ", baglanti);
                    break;
                case "Petrol":
                    komut = new SqlCommand("select petrol from kullanici WHERE kul_nick = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set petrol = @k1 WHERE kul_nick = @kn ", baglanti);
                    break;
                case "Pamuk":
                    komut = new SqlCommand("select pamuk from kullanici WHERE kul_nick = @kn", baglanti);
                    komut2 = new SqlCommand("update kullanici Set pamuk = @k1 WHERE kul_nick = @kn ", baglanti);
                    break;
                default:  break;
            }

            komut.Parameters.AddWithValue("@kn", secilen_kul_nick);
            

            baglanti.Open();
            var miktar = komut.ExecuteScalar();
            eski_miktar = Convert.ToInt32(miktar);

            yeni_miktar = eski_miktar + urun_miktar;
            komut2.Parameters.AddWithValue("@kn", secilen_kul_nick);
            komut2.Parameters.AddWithValue("@k1", yeni_miktar);
            komut2.ExecuteNonQuery();

            baglanti.Close();

           
        }

        public void urun_guncelle(int yeni_bakiye, string kullanici)    // güncellenmiş miktarı veri tabanına kaydeder
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JPBDURM\\SQLEXPRESS;Initial Catalog=finans;Integrated Security=True");

            SqlCommand komut = new SqlCommand("update kullanici Set kul_bakiye = @k1 WHERE kul_nick = @k2 ", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@k1", yeni_bakiye);
            komut.Parameters.AddWithValue("@k2", kullanici);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

     





    }
}
