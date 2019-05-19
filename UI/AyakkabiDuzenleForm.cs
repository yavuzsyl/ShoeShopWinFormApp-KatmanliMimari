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
    public partial class AyakkabiDuzenleForm : Form
    {
        MarkaRepository mrep = new MarkaRepository();
        AyakkabiRepository arep = new AyakkabiRepository();
        public Ayakkabi ayakkabi;

        public AyakkabiDuzenleForm()
        {
            InitializeComponent();
        }

        private void AyakkabiDuzenleForm_Load(object sender, EventArgs e)
        {
            comboBoxMarka.DataSource = mrep.GetMarkas();
            comboBoxMarka.DisplayMember = "MarkaAdi";
            comboBoxMarka.ValueMember = "Id";
            comboBoxCins.Items.AddRange(Enum.GetNames(typeof(Cins)));
            /////////////////////////////////////////////////////////
            comboBoxMarka.SelectedItem = ayakkabi.Marka;
            textBoxModel.Text = ayakkabi.Model;
            comboBoxCins.SelectedItem = ayakkabi.Cins;
            radioButtonErkek.AutoCheck = ayakkabi.Cinsiyet == Cinsiyet.erkek ? true : false;
            radioButtonKadın.AutoCheck = ayakkabi.Cinsiyet == Cinsiyet.kadın ? true : false;
            radioButtonUni.AutoCheck = ayakkabi.Cinsiyet == Cinsiyet.uni ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ayakkabi.Cins =(Cins)comboBoxCins.SelectedIndex;
            ayakkabi.Cinsiyet = radioButtonErkek.Checked ? Cinsiyet.erkek : radioButtonKadın.Checked ? Cinsiyet.kadın : Cinsiyet.uni;
            ayakkabi.MarkaId =(int)comboBoxMarka.SelectedValue;
            ayakkabi.Model = textBoxModel.Text;

            if (arep.Update(ayakkabi))
            {
                AyakkabiForm af =(AyakkabiForm)Application.OpenForms["AyakkabiForm"];
                if (af == null)
                    af = new AyakkabiForm();
                af.GuncelAyakkabilar();
            }
            else
            {
                MessageBox.Show("Bir yerde bir bokluk var");
            }
            

        }
    }
}
