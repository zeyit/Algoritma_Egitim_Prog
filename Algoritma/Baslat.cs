using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Algoritma
{
    class Baslat : myPanel
    {
        public Baslat(String Name): base(120, 40)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(myPaint);
            this.Name = Name;
            base.YapilacakIslemGosterilecekMi = false;
            base.CbDegiskenGosterilecekMi = false;
            base.MetinGoruntulensinMi = false;
            base.WHGosterilecekMi = false;
            base.GosterilecekMetin = "Başlat";
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
    }
}
