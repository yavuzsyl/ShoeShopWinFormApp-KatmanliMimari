using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class StokHareket : Form
    {
        AyakkabiRepository arep = new AyakkabiRepository();
        MarkaRepository mrep = new MarkaRepository();
        StokManager sm = new StokManager();
        public StokHareket()
        {
            InitializeComponent();
        }

        private void StokHareket_Load(object sender, EventArgs e)
        {
            cb_Marka.DisplayMember = "MarkaAdi";
            cb_Marka.ValueMember = "Id";
            cb_Marka.DataSource= mrep.GetMarkas();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokViewModel svm = new StokViewModel();
            svm.Adet = (int)nm_adet.Value;
            svm.islemTipi = rb_cikis.Checked ? StokHareketTipi.Cikis : StokHareketTipi.Giris;
            svm.AyakkabiId =(int)cb_Ayakkabi.SelectedValue;
            svm.Numara =(int)nm_no.Value;
            if(sm.StokHareket(svm))
            {
                MessageBox.Show("Stok GÜNCEL");
            }
            else
            {
                MessageBox.Show("Stok güncellenemedi");
            }
            
        }

        private void cb_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Marka.SelectedItem!=null)
            {
      
                cb_Ayakkabi.DisplayMember = "Model";
                cb_Ayakkabi.ValueMember = "Id";
                cb_Ayakkabi.DataSource = arep.MarkayaGoreGetir((int)cb_Marka.SelectedValue);
               
            }

        }
    }
}
