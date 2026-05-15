using HalisahaRezervasyon.DataAccess;
using System.Data;

namespace HalisahaRezervasyon.Business
{
    public class SahaBL
    {
        SahaDAL sahaDAL = new SahaDAL();

        public DataTable SahalariListele()
        {
            return sahaDAL.SahalariGetir();
        }

        public void SahaEkle(string ad, float ucret)
        {
            sahaDAL.SahaEkle(ad, ucret);
        }
    }
}