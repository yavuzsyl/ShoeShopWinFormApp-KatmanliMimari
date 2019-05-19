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
    public partial class AyakkabiForm : Form
    {
        AyakkabiRepository ayRep = new AyakkabiRepository();
        public AyakkabiForm()
        {
            InitializeComponent();
        }


        public void AyakkabiForm_Load(object sender, EventArgs e)
        {
            GuncelAyakkabilar();

        }

        public void GuncelAyakkabilar()
        {

            listAyakkabilar.DisplayMember = "Gosterim";
            listAyakkabilar.ValueMember = "Id";
            listAyakkabilar.DataSource = ayRep.GetAyakkabis();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listAyakkabilar.SelectedItem != null)
            {
                bool x = ayRep.Delete((int)listAyakkabilar.SelectedValue);
                if (x)
                {
                    GuncelAyakkabilar();
                }
                else
                {
                    MessageBox.Show("error ocured");
                }
            }
        }

        private void listAyakkabilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAyakkabilar.SelectedItem != null)
            {
                Ayakkabi ayk = (Ayakkabi)listAyakkabilar.SelectedItem;
                lbl_Cins.Text = ayk.Cins.ToString();
                lbl_Cinsiyet.Text = ayk.Cinsiyet.ToString();
                lbl_Marka.Text = ayk.Marka.MarkaAdi;
                lbl_Model.Text = ayk.Model;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listAyakkabilar.SelectedItem!=null)
            {
                AyakkabiDuzenleForm adf = (AyakkabiDuzenleForm)FormHelper.GenerateForm(typeof(AyakkabiDuzenleForm));
                adf.ayakkabi =(Ayakkabi)listAyakkabilar.SelectedItem;
                adf.Show();

            }

        }
    }
}
