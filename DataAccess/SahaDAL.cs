using MySql.Data.MySqlClient;
using System.Data;

namespace HalisahaRezervasyon.DataAccess
{
    public class SahaDAL
    {
        public DataTable SahalariGetir()
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand(
                "SahalarHepsi",
                baglanti
            );

            komut.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void SahaEkle(
            string ad,
            float ucret
        )
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand(
                "SahaEkle",
                baglanti
            );

            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("ad", ad);
            komut.Parameters.AddWithValue("tur", "Halı Saha");
            komut.Parameters.AddWithValue("ucret", ucret);
            komut.Parameters.AddWithValue("durum", "Aktif");

            baglanti.Open();

            komut.ExecuteNonQuery();

            baglanti.Close();
        }
    }
}