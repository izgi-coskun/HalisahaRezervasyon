using MySql.Data.MySqlClient;
using System.Data;

namespace HalisahaRezervasyon.DataAccess
{
    public class RezervasyonDAL
    {
        public DataTable RezervasyonlariGetir()
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand(
                "RezervasyonlariGetir",
                baglanti
            );

            komut.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void RezervasyonEkle(
            int musteriID,
            int sahaID,
            string tarih,
            string baslangic,
            string bitis,
            float ucret
        )
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand(
                "RezervasyonEkle",
                baglanti
            );

            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("musteri", musteriID);
            komut.Parameters.AddWithValue("saha", sahaID);
            komut.Parameters.AddWithValue("tarih", tarih);
            komut.Parameters.AddWithValue("baslangic", baslangic);
            komut.Parameters.AddWithValue("bitis", bitis);
            komut.Parameters.AddWithValue("ucret", ucret);
            komut.Parameters.AddWithValue("durum", "Aktif");

            baglanti.Open();

            komut.ExecuteNonQuery();

            baglanti.Close();
        }
    }
}