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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaForm mf=(MarkaForm)FormHelper.GenerateForm(typeof(MarkaForm));
            mf.MdiParent = this;
            mf.Show();
        }

        private void toolStripButtonMarka_Click(object sender, EventArgs e)
        {
            MarkaEkleForm mef = (MarkaEkleForm)FormHelper.GenerateForm(typeof(MarkaEkleForm));
            mef.MdiParent = this;
            mef.Show();
        }

        private void toolStripButtonAyak_Click(object sender, EventArgs e)
        {
            AyakkabiEkleForm af=(AyakkabiEkleForm)FormHelper.GenerateForm(typeof(AyakkabiEkleForm));
            af.MdiParent = this;
            af.Show();
        }

        private void ayakkabılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyakkabiForm af = (AyakkabiForm)FormHelper.GenerateForm(typeof(AyakkabiForm));
            af.MdiParent = this;
            af.Show();
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokHareket sh = (StokHareket)FormHelper.GenerateForm(typeof(StokHareket));
            sh.MdiParent = this;
            sh.Show();
        }

        private void toolStripButtonSTOK_Click(object sender, EventArgs e)
        {
            StokHareket sh = (StokHareket)FormHelper.GenerateForm(typeof(StokHareket));
            sh.MdiParent = this;
            sh.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            EnvanterForm sh = (EnvanterForm)FormHelper.GenerateForm(typeof(EnvanterForm));
            sh.MdiParent = this;
            sh.Show();
        }
    }
}
