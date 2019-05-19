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
    public partial class AyakkabiEkleForm : Form
    {
        AyakkabiRepository ayRep = new AyakkabiRepository();
        MarkaRepository mrep = new MarkaRepository();

        public AyakkabiEkleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Ayakkabi ayk = new Ayakkabi()
            {
                Cins = (Cins)comboBoxCins.SelectedIndex,
                Cinsiyet = radioButtonKadın.Checked ? Cinsiyet.kadın : radioButtonErkek.Checked ? Cinsiyet.erkek : Cinsiyet.uni,
                Model = textBoxModel.Text,
                MarkaId = (int)comboBoxMarka.SelectedValue
            };
            ayk.Marka = new Marka();
            ayk.Marka.Id =(int)comboBoxMarka.SelectedValue;
            if (ayRep.Insert(ayk))
            {
               AyakkabiForm af =(AyakkabiForm)FormHelper.GenerateForm(typeof(AyakkabiForm));
                af.GuncelAyakkabilar();
            }
            else
            {
                MessageBox.Show("ERROR OCCURED");
            }
            
        }

        private void AyakkabiEkleForm_Load(object sender, EventArgs e)
        {
            comboBoxMarka.DataSource = mrep.GetMarkas();
            comboBoxMarka.DisplayMember = "MarkaAdi";
            comboBoxMarka.ValueMember = "Id";

            comboBoxCins.Items.AddRange(Enum.GetNames(typeof(Cins)));

        }
    }
}
