using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vialsur.prefectura.uc
{
    using System.Windows.Forms;
    using System.Drawing;

    public class uc_NumericUpDown : NumericUpDown
    {
        public uc_NumericUpDown()
        {
            this.Minimum = (decimal)1930;
            this.Maximum = (decimal)System.DateTime.Now.Year;
            this.Value = (decimal)(System.DateTime.Now.Year - 10);
            this.TextAlign = HorizontalAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

      



    }
}
