using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;

namespace UI
{
    public partial class EnvanterForm : Form
    {
        StokManager sm = new StokManager();
        public EnvanterForm()
        {
            InitializeComponent();
        }

        private void EnvanterForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sm.EnvanterGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string veriler = JsonConvert.SerializeObject(sm.EnvanterGetir());

            //Directory.CreateDirectory(@"c:\JSON");
            //File.WriteAllText(@"c:\JSON\ayakkabilar.json", veriler);


            XDocument dokuman = new XDocument(
                new XDeclaration("1.1", "UTF-16", "yes"), 
                new XElement("StokRapor", 
                sm.EnvanterGetir().Select(x => new XElement("Stok", 
                new XElement("Stokid", x.stId), 
                new XElement("Ayakkabıid", x.AyakkabıId),
                new XElement("MarkaAdı", x.MarkaAdi), 
                new XElement("Model", x.Model), 
                new XElement("Numara", x.Numara),
                new XElement("Adet", x.Adet)))));

            dokuman.Save(@"c:\XML\ayakkabi.xml");

            MessageBox.Show("xml OLDU");


        }
    }
}
