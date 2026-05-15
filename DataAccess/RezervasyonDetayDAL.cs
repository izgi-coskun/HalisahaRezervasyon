using MySql.Data.MySqlClient;
using System.Data;

namespace HalisahaRezervasyon.DataAccess
{
    public class RezervasyonDetayDAL
    {
        public DataTable DetaylariGetir()
        {
            MySqlConnection baglanti = Veritabani.Baglanti();

            MySqlCommand komut = new MySqlCommand(
                "RezervasyonDetaylariGetir",
                baglanti
            );

            komut.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}