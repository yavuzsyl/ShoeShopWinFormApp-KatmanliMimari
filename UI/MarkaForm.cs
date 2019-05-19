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
    public partial class MarkaForm : Form
    {
        Marka secilimarka = new Marka();
        MarkaLabel seciliLabel;
        MarkaRepository mrep = new MarkaRepository();
        public MarkaForm()
        {
            InitializeComponent();
        }
        public void LabelEkleFlowa(Marka marka)
        {
            MarkaLabel label = new MarkaLabel();
            label.Text = marka.MarkaAdi;
            label.MarkaId = marka.Id;
            label.Click += MarkalabelKıllik_Click;
            flowLayoutPanel1.Controls.Add(label);
        }

        private void MarkalabelKıllik_Click(object sender, EventArgs e)
        {
            foreach (MarkaLabel item in flowLayoutPanel1.Controls)
                item.Secilimi = false;

            MarkaLabel lbl = (MarkaLabel)sender;
            seciliLabel = lbl;
            lbl.Secilimi = true;
            secilimarka.Id = lbl.MarkaId;
            secilimarka.MarkaAdi = lbl.Text;

        }

        private void MarkaForm_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            List<Marka> markalar = mrep.GetMarkas();
            foreach (Marka item in markalar)
            {
                LabelEkleFlowa(item);

            }
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (seciliLabel != null)
            {
                groupBox2.Visible = true;
                textBox1.Text = seciliLabel.Text;

            }
            else
            {
                MessageBox.Show("Marka Seçiniz");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secilimarka.MarkaAdi = textBox1.Text;
            if (mrep.Update(secilimarka))
            {
                seciliLabel.Text = textBox1.Text;
            }
            else
            {
                MessageBox.Show("ERROR OCCURED");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (mrep.Delete(secilimarka.Id))
            {
                flowLayoutPanel1.Controls.Remove(seciliLabel);
            }
            else
            {
                MessageBox.Show("ERROR OCCURED");

            }
            groupBox2.Visible = false;
        }
    }
}
