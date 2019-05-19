using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StokManager
    {
        public List<StokEnvanter> EnvanterGetir()
        {
            List<StokEnvanter> envanters = new List<StokEnvanter>();
            string sql = "Select s.*,m.MarkaAdi,a.Model from Stok s inner join Ayakkabilar a on a.id=s.AyakkabıId inner join Markalar m on m.id=a.MarkaId";
             DataTable dt= DataHelper.Select(sql);
            foreach (DataRow item in dt.Rows)
            {
                StokEnvanter se = new StokEnvanter()
                {
                   Adet = (int)item["Adet"],
                   AyakkabıId=(int)item["AyakkabıId"],
                   MarkaAdi=item["MarkaAdi"].ToString(),
                   Model=item["Model"].ToString(),
                   Numara=(int)item["Numara"],
                   stId=(int)item["id"]               
                };
                envanters.Add(se);
            }
            return envanters;
        }

        public bool StokHareket(StokViewModel svm)
        {
            string sql = "exec StokHareket @Numara,@islemTipi,@aid,@adet";
            SqlParameter p1 = new SqlParameter("Numara",svm.Numara);
            SqlParameter p2 = new SqlParameter("islemTipi", svm.islemTipi);
            SqlParameter p3 = new SqlParameter("aid", svm.AyakkabiId);
            SqlParameter p4 = new SqlParameter("adet", svm.Adet);
            return  DataHelper.ExecuteCommand(sql, p1, p2, p3, p4);
        }
    }
}
