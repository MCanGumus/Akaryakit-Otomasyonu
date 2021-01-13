using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AkaryakıtİstasyonuOtomasyonu
{
    class Baglanti
    {
        SqlConnection con;
        
        
        public SqlConnection Connection()
        {
             con = new SqlConnection("Data Source=DESKTOP-JSQ73E8\\SQLEXPRESS01;Initial Catalog=dbLogin;Integrated Security=True"); 
             con.Open();
             
             return con;
         
        }
        public SqlConnection Disconnect()
        {
            con.Close();
            
            return con;
        }
        public string Update()
        {
         
            string Benzin_Kalan_Sorgu = "Update YakitMiktari Set Benzin=@p1";
            return Benzin_Kalan_Sorgu;

        }
        public string DizelUpdate()
        {
            string Dizel_Kalan_Sorgu = "Update YakitMiktari Set Dizel=@p1";
            return Dizel_Kalan_Sorgu;
        }
        public void Delete()
        {
            con.Open();
            con.Close();
        }
        public string Ekle()
        {
            string Benzin_Sorgu = "insert into gelenAracListesi (Plaka,Para,Fiyat,Miktar,Yakit_Turu) values (@p1,@p2,@p3,@p4,@p5)";
            return Benzin_Sorgu;
        }
        public string Transfer()
        {
            string Gelen_Sorgu = "Select * from gelenAracListesi";
            return Gelen_Sorgu;
            
           
        }
        public string litreMiktarTransfer()
        {
            string Litre_Benzin_Sorgu = "Select Benzin from YakitMiktari";
            return Litre_Benzin_Sorgu;
        }
        public string dizelLitreMiktarTransfer()
        {
            string Litre_Dizel_Sorgu = "Select Dizel from YakitMiktari";
            return Litre_Dizel_Sorgu;
        }
        public string dizelLitreTransfer()
        {
            string Dizel_Litre_Transfer= "Select Dizel from YakitMiktari";
            return Dizel_Litre_Transfer;
        } 
        public string lpgLitreTransfer()
        {
            string LPG_Litre_Transfer = "Select LPG from YakitMiktari";
            return LPG_Litre_Transfer;
        }
        public string lpgUpdate()
        {
            string LPG_Update = "Update YakitMiktari Set LPG=@p1";
            return LPG_Update;
        }
        public string euroDizelTransfer()
        {
            string EuroDizel_Litre_Transfer = "Select EuroDizel from YakitMiktari";
            return EuroDizel_Litre_Transfer;
        }
        public string euroDizelUpdate()
        {
            string EuroDizel_Update = "Update YakitMiktari Set EuroDizel=@p1";
            return EuroDizel_Update;
        }
        public string kursunluBenzinTransfer()
        {
            string kursunluBenzin_Litre_Transfer = "Select KursunluBenzin from YakitMiktari";
            return kursunluBenzin_Litre_Transfer;
        }
        public string kursunluBenzinUpdate()
        {
            string kursunluBenzin_Update = "Update YakitMiktari Set KursunluBenzin=@p1";
            return kursunluBenzin_Update;
        }
        public string tumYakitlariGetir()
        {
            string komut = "Select * From YakitMiktari";
            return komut;
        }



        //Yönetim paneli bağlantı komutları


        public string userGiris(string username,string password)
        {
            string girisKomutu = "SELECT * FROM dbUser where username='" + username + "'AND password='" + password + "'";
            return girisKomutu;
        }

        public string isciListesi()
        {
            string komut = "SELECT * FROM isciListe";
            return komut;
        }
        public string isciEkle()
        {
            string komut = "insert into isciListe (Tc,Adı,Soyadı,Mesai) values (@p1,@p2,@p3,@p4)";
            return komut;
        }
        public string isciGuncelle(string tc, string ad, string soyad, string mesai)
        {
            string komut = $"UPDATE isciListe SET Adı='{ad}',Soyadı='{soyad}',Mesai='{mesai}' WHERE Tc ='{tc}'"; 
            return komut;
        }
        public string tumnKayitSil()
        {
            string komut = "Delete From isciListe";
            return komut;
        }
        public string seciliKayitSil(string tc)
        {
            string komut = $"Delete From isciListe Where Tc='{tc}'";
            return komut;
        }
        public string toplamParaHesapla()
        {
            string komut = "Select * From Ekonomi";
            return komut;
        }
        public string paraUpdate()
        {
            string komut = "Update Ekonomi Set Para=@p1";
            return komut;
        }
        //Mudur paneli komutları

        public string yonetimListele()
        {
            string komut = "Select * From dbUser";
            return komut;
        }
        public string yonetimKayıt()
        {
            string komut = "Insert Into dbUser (username,password,adi,soyadi) values (@p1,@p2,@p3,@p4)";
            return komut;
        }
        public string yonetGuncelle(string ad, string soyad, string username, string pass)
        {
            string komut = $"UPDATE dbUser SET adi='{ad}',soyadi='{soyad}',password ='{pass}' WHERE username='{username}'";
            return komut;
        }
        public string yonetSil()
        {
            string komut = "Delete From dbUser";
            return komut;
        }




    }
}
