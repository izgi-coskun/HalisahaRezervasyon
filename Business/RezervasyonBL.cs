using HalisahaRezervasyon.DataAccess;
using System.Data;

namespace HalisahaRezervasyon.Business
{
    public class RezervasyonBL
    {
        RezervasyonDAL rezervasyonDAL =
            new RezervasyonDAL();

        public DataTable RezervasyonlariListele()
        {
            return rezervasyonDAL
                .RezervasyonlariGetir();
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
            rezervasyonDAL.RezervasyonEkle(
                musteriID,
                sahaID,
                tarih,
                baslangic,
                bitis,
                ucret
            );
        }
    }
}