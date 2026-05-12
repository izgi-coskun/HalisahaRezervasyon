using MySql.Data.MySqlClient;

namespace HalisahaRezervasyon
{
    public class Veritabani
    {
        public static MySqlConnection Baglanti()
        {
            MySqlConnection baglanti = new MySqlConnection(
                "Server=localhost;Database=halisaha_rezervasyon;Uid=root;Pwd=;"
            );

            return baglanti;
        }
    }
}