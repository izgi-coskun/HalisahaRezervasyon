using MySql.Data.MySqlClient;
using System.Data;

namespace HalisahaRezervasyon.DataAccess
{
    public class OdemeDAL
    {
        public DataTable OdemeleriGetir()
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand("OdemeleriGetir", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void OdemeEkle(int rezervasyonID, string tarih, float tutar, string aciklama)
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand("OdemeEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("rezervasyon", rezervasyonID);
            komut.Parameters.AddWithValue("tarih", tarih);
            komut.Parameters.AddWithValue("tutar", tutar);
            komut.Parameters.AddWithValue("aciklama", aciklama);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}