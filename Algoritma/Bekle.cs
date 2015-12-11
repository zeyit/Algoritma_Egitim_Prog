using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Algoritma
{
    class Bekle:myPanel
    {
        public Bekle(String Name): base(50, 50)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(myPaint);
            this.Name = Name;
            base.YapilacakIslemGosterilecekMi = false;
            base.CbDegiskenGosterilecekMi = false;
            base.MetinGoruntulensinMi = false;
            base.WHGosterilecekMi = false;
            base.GosterilecekMetin = "Bekle";
        }

        public override void myPaint(object sender, PaintEventArgs e)
        {
           Graphics g = e.Graphics;
           String panelAdi = base.GosterilecekMetin;
           Brush brush = System.Drawing.Brushes.LightSlateGray;
           g.FillEllipse(brush, 0, 0, Width - 3, Height - 3);
           brush = System.Drawing.Brushes.White;
           g.DrawString(panelAdi, new Font("Arial", 10), brush, new Point(this.Width / 2 - 8 * panelAdi.Length / 2, this.Height / 2 - 10));
        }

        public override void islemYap(frmConsole p)
        {
           // Thread.Sleep(1000);
            try
            {
               Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception)
            {
            }
        }
    }
}
