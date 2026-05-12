using MySql.Data.MySqlClient;
using System.Data;

namespace HalisahaRezervasyon.DataAccess
{
    public class MusteriDAL
    {
        public DataTable MusterileriGetir()
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand(
                "MusterilerHepsi",
                baglanti
            );

            komut.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void MusteriEkle(string ad, string soyad)
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand("MusteriEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("ad", ad);
            komut.Parameters.AddWithValue("soyad", soyad);
            komut.Parameters.AddWithValue("tel", "-");
            komut.Parameters.AddWithValue("mail", "-");
            komut.Parameters.AddWithValue("adres", "-");

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
