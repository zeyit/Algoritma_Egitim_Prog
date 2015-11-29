using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Algoritma
{
    class Dugum : myPanel
    {
       
         public Dugum(String Name): base(50, 50)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(myPaint);
            this.Name = Name;
            base.YapilacakIslemGosterilecekMi = false;
            base.CbDegiskenGosterilecekMi = false;
            base.MetinGoruntulensinMi = false;
            base.WHGosterilecekMi = false;
            base.GosterilecekMetin = "Düğüm";
        }


        public override void myPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
              Brush brush = System.Drawing.Brushes.LightSlateGray;
              String panelAdi = base.GosterilecekMetin;
              g.FillEllipse(brush, 0, 0, Width-3, Height-3);
              brush = System.Drawing.Brushes.White;
              g.DrawString(panelAdi, new Font("Arial", 10), brush, new Point(this.Width / 2 - 10 * panelAdi.Length / 2, this.Height/2-10));

            //Bitmap bitmap = new Bitmap(Algoritma.Properties.Resources.dugum);
           // e.Graphics.DrawImage(bitmap, new Point(0, 0));

        }
   
    }
}
