using HalisahaRezervasyon.DataAccess;
using System.Data;

namespace HalisahaRezervasyon.Business
{
    public class MusteriBL
    {
        MusteriDAL musteriDAL = new MusteriDAL();

        public DataTable MusterileriListele()
        {
            return musteriDAL.MusterileriGetir();
        }

        public void MusteriEkle(string ad, string soyad)
        {
            musteriDAL.MusteriEkle(ad, soyad);
        }
    }
}