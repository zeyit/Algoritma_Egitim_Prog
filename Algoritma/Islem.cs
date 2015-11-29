using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Algoritma
{
    class Islem:myPanel
    {
        public Islem(String Name): base(150, 45)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(myPaint);
            this.Name = Name;
            base.YapilacakIslemGosterilecekMi = true;
            base.CbDegiskenGosterilecekMi = false;
            base.MetinGoruntulensinMi = false;
            base.WHGosterilecekMi = true;
            base.YapilacakIslem = "ort =(vize + final)/2";
            base.GosterilecekMetin = "İşlem";
        }

        public override void myPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            String islem = base.YapilacakIslem;
            Brush brush = System.Drawing.Brushes.LightSlateGray;
            g.FillRectangle(brush, 1, 1, Width-4, Height-4);
            brush = System.Drawing.Brushes.White;
            g.DrawString(islem, new Font("Arial", 10), brush, new Point(this.Width/2-7*islem.Length/2, this.Height/2-8));
        }

    }
}
