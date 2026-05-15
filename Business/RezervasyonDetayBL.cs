using HalisahaRezervasyon.DataAccess;
using System.Data;

namespace HalisahaRezervasyon.Business
{
    public class RezervasyonDetayBL
    {
        RezervasyonDetayDAL detayDAL = new RezervasyonDetayDAL();

        public DataTable DetaylariListele()
        {
            return detayDAL.DetaylariGetir();
        }
    }
}