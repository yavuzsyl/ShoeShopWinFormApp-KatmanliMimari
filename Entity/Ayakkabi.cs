using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ayakkabi
    {

        public int Id { get; set; }
        public string Model { get; set; }
        public Cins Cins { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public int MarkaId { get; set; }
        public Marka Marka { get; set; }
        public string Gosterim { get { return Model + " " + Marka.MarkaAdi; } }
    }
    public enum Cins
    {
        sport,
        classic,
        outdoor,
        casual
    }
    public enum Cinsiyet
    {
        erkek,
        kadın,
        uni
    }
}
