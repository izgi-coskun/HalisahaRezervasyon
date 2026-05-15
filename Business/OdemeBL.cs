using HalisahaRezervasyon.DataAccess;
using System.Data;

namespace HalisahaRezervasyon.Business
{
    public class OdemeBL
    {
        OdemeDAL odemeDAL = new OdemeDAL();

        public DataTable OdemeleriListele()
        {
            return odemeDAL.OdemeleriGetir();
        }

        public void OdemeEkle(int rezervasyonID, string tarih, float tutar, string aciklama)
        {
            odemeDAL.OdemeEkle(rezervasyonID, tarih, tutar, aciklama);
        }
    }
}