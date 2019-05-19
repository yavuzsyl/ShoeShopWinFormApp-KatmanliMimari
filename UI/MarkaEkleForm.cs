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
    public partial class MarkaEkleForm : Form
    {
        MarkaRepository mrep = new MarkaRepository();
        public MarkaEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Marka newMarka = new Marka();
            newMarka.MarkaAdi = txtMarkaAdi.Text;
            int mid = 0;
            if (mrep.Insert(newMarka,out mid))
            {
                MarkaForm mf=(MarkaForm)FormHelper.GenerateForm(typeof(MarkaForm));
                mf.LabelEkleFlowa(newMarka);
   
            }
            else
            {
                MessageBox.Show("error occured");
            }
        }
    }
}
