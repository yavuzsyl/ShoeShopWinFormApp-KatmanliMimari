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
    public class MarkaRepository
    {
        public List<Marka> GetMarkas()
        {
            List<Marka> markalar = new List<Marka>();
            string sql = "select *from Markalar order by MarkaAdi";
            DataTable dt=  DataHelper.Select(sql);
            foreach (DataRow item in dt.Rows)
            {
                Marka marka = new Marka();
                marka.Id =(int)item["id"];
                marka.MarkaAdi = item["MarkaAdi"].ToString();
                markalar.Add(marka);
            }
            return markalar;
        }
        public bool Insert(Marka m,out int id)
        {
            string sql = "insert into Markalar (MarkaAdi) values(@MarkaAdi)";
            SqlParameter p1 = new SqlParameter("MarkaAdi", m.MarkaAdi);
            bool x = DataHelper.ExecuteCommand(sql,p1);
            if (x)
            {
                string sql2 = "Select MAX(id) from Markalar";
                DataTable dt= DataHelper.Select(sql2);
                id =(int)dt.Rows[0][0];
            }
            else
            {
                id = -1;
            }
            return x;
                

        }
        public bool Delete(int id)
        {
            string sql = "Delete From Markalar where id=@Id";
            SqlParameter p1 = new SqlParameter("Id",id);
            return DataHelper.ExecuteCommand(sql, p1);
        }
        public bool Update(Marka m)
        {
            string sql = "Update Markalar set MarkaAdi=@MarkaAdi where id=@Id";
            SqlParameter p1 = new SqlParameter("MarkaAdi", m.MarkaAdi);
            SqlParameter p2 = new SqlParameter("Id",m.Id);
            return DataHelper.ExecuteCommand(sql, p1,p2);
        }
    }
}
