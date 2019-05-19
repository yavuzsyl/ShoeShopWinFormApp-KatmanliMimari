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
    public class AyakkabiRepository
    {
        public List<Ayakkabi> MarkayaGoreGetir(int markaId)
        {
            List<Ayakkabi> ayakkabis = new List<Ayakkabi>();
            string sql = "select a.* from Ayakkabilar a  where MarkaId="+markaId;
            DataTable dt = DataHelper.Select(sql);
            foreach (DataRow item in dt.Rows)
            {
                Ayakkabi ayakkabi = new Ayakkabi();
                ayakkabi.Cins = (Cins)item["Cins"];
                ayakkabi.Cinsiyet = (Cinsiyet)item["Cinsiyet"];
                ayakkabi.Model = item["Model"].ToString();
                ayakkabi.Id = (int)item["id"];
                ayakkabi.MarkaId = (int)item["MarkaId"];

                ayakkabis.Add(ayakkabi);
            }
            return ayakkabis;
        }
        public List<Ayakkabi> GetAyakkabis()
        {
            List<Ayakkabi> ayakkabis = new List<Ayakkabi>();
            string sql = "Select a.*,m.MarkaAdi from Ayakkabilar a inner join Markalar m on a.MarkaId=m.id";
            DataTable dt= DataHelper.Select(sql);
            foreach (DataRow item in dt.Rows)
            {
                Ayakkabi ayakkabi = new Ayakkabi();
                ayakkabi.Cins =(Cins)item["Cins"];
                ayakkabi.Cinsiyet =(Cinsiyet) item["Cinsiyet"];
                ayakkabi.Model = item["Model"].ToString();
                ayakkabi.Id = (int)item["id"];
                ayakkabi.MarkaId = (int)item["MarkaId"];
                
                ayakkabi.Marka = new Marka();
                ayakkabi.Marka.MarkaAdi = item["MarkaAdi"].ToString();
                ayakkabis.Add(ayakkabi);
            }
            return ayakkabis;
        }
        public bool Insert(Ayakkabi a)
        {
            string sql = "insert into Ayakkabilar (Model,Cinsiyet,Cins,MarkaId) values (@Model,@Cinsiyet,@Cins,@MarkaId)";
            SqlParameter p1 = new SqlParameter("Model",a.Model);
            SqlParameter p2 = new SqlParameter("Cinsiyet", a.Cinsiyet);
            SqlParameter p3 = new SqlParameter("Cins", a.Cins);
            SqlParameter p4 = new SqlParameter("MarkaId", a.MarkaId);

            return  DataHelper.ExecuteCommand(sql, p1, p2, p3, p4);
        }
        public bool Delete(int id)
        {
            string sql = "Delete from Ayakkabilar where id=@Id";
            SqlParameter p1 = new SqlParameter("Id", id);
            return  DataHelper.ExecuteCommand(sql, p1);

        }
        public bool Update(Ayakkabi a)
        {
            string sql = "Update Ayakkabilar set Model=@Model,Cinsiyet=@Cinsiyet,Cins=@Cins,MarkaId=@MarkaId  where id=@Id ";
            SqlParameter p1 = new SqlParameter("Model", a.Model);
            SqlParameter p2 = new SqlParameter("Cinsiyet", a.Cinsiyet);
            SqlParameter p3 = new SqlParameter("Cins", a.Cins);
            SqlParameter p4 = new SqlParameter("MarkaId", a.MarkaId);
            SqlParameter p5 = new SqlParameter("Id",a.Id);

            return DataHelper.ExecuteCommand(sql, p1, p2, p3, p4,p5);
        }
    }
}
