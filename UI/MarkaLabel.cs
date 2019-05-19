using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class MarkaLabel :Label
    {
        private bool _secilimi;

        public bool Secilimi
        {
            get { return _secilimi; }

            set
            {
                if (value)
                {
                    this.BackColor = Color.Red;
    
                }
                else
                    this.BackColor = Color.Blue;

                _secilimi = value; }
        }

        public int MarkaId { get; set; }
        public MarkaLabel()
        {
           this.Width = 100;
           this.Height = 30;
           this.Margin = new Padding(10);
           this.BackColor = Color.Blue;
           this.ForeColor = Color.White;
           
        }
        protected override void OnClick(EventArgs e)
        {
            Secilimi = !Secilimi;
            base.OnClick(e);
        }
    }
}
