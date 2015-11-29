using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Algoritma
{
    class Eger:myPanel
    {
        public Eger(String Name): base(100, 100)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(myPaint);
            this.Name = Name;
            base.YapilacakIslemGosterilecekMi = true;
            base.CbDegiskenGosterilecekMi = false;
            base.MetinGoruntulensinMi = false;
            base.WHGosterilecekMi = true;
            base.GosterilecekMetin = "Eger";
            base.YapilacakIslem= "ort > 50";
        }


        public override void myPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            String kararMetni = base.YapilacakIslem;

            Brush brush = System.Drawing.Brushes.White;
            g.FillRectangle(brush, 1, 1, Width - 4, Height - 4);
            //giriş simgesini benzetmek için köşelere 10 dereceli açı ile pie çizdir

            int x = this.Width + 40 + (this.Width - 100) / 50 * 20;
            int y = this.Height / 2;

            SolidBrush sBrush = new SolidBrush(Color.LightSlateGray);
            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(-x / 2, -x / 2 + y, x, x);
            // Create start and sweep angles.
            float startAngle = -45.0F;
            float sweepAngle = 90.0F;

            // Fill pie to screen.
            e.Graphics.FillPie(sBrush, rect, startAngle, sweepAngle);

            rect = new Rectangle(this.Width - x / 2, -x / 2 + y, x, x);
            startAngle = -225.0F;
            sweepAngle = 90.0F;
            e.Graphics.FillPie(sBrush, rect, startAngle, sweepAngle);
            g.DrawString(kararMetni, new Font("Arial", 10), brush, new Point(this.Width / 2 - 7 * kararMetni.Length / 2, this.Height / 2 - 8));
        }


    }
}
