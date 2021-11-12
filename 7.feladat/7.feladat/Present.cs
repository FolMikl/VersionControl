using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.feladat
{
    public class Present : Toy
    {
        public SolidBrush PrColor1 { get; set; }
        public SolidBrush PrColor2 { get; set; }

        public Present(Color Color1, Color Color2)
        {
            PrColor1 = new SolidBrush(Color1);
            PrColor2 = new SolidBrush(Color2);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PrColor1, 0, 0, this.Width, this.Height);
            g.FillRectangle(PrColor2, 0, (this.Height / 5) * 2, this.Width, this.Height / 5);
            g.FillRectangle(PrColor2, (this.Width / 5) * 2, 0, this.Width/5, this.Height);
        }
    }
}
