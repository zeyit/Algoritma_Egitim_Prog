using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Algoritma
{
    class Giris:myPanel
    {
        private  String panelName = ". . . Giriş . . .";
        private String degiskenAdi;
        DegiskenListesi degiskenler = new DegiskenListesi();
        public Giris(String Name) : base(220, 50)
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(myPaint);
            this.Name = Name;
            base.YapilacakIslemGosterilecekMi = false;
            base.CbDegiskenGosterilecekMi = true;
            base.MetinGoruntulensinMi = true;
            base.WHGosterilecekMi = true;
            base.GosterilecekMetin="Klavyeden bir sayi giriniz :";
            degiskenAdi = "";
        }

        public String DegiskenAdi
        {
            get { return   degiskenAdi; }
            set { degiskenAdi = value; }
        }


        public override void myPaint(object sender, PaintEventArgs e)
        {
            String mGosterilecekMetin = "";
            if (degiskenAdi != "")
            {
                mGosterilecekMetin = base.GosterilecekMetin +" , " + degiskenAdi;
            }
            else
            {
                mGosterilecekMetin = base.GosterilecekMetin;
            }
            Graphics g = e.Graphics;
            Brush brush = System.Drawing.Brushes.White;
            g.FillRectangle(brush, 1, 1, Width - 4, Height - 4);
            brush = System.Drawing.Brushes.LightSlateGray;    
            //sol kırpma
            g.FillRectangle(brush, 1, 1, this.Width - 4, this.Height - 4);

            int x = this.Height ;
            SolidBrush redBrush = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(-x-15, -15, 2*x+30, 2*x+30);

            float startAngle = -90.0F;
            float sweepAngle = 10.0F;
            e.Graphics.FillPie(redBrush, rect, startAngle, sweepAngle);
            //sağ kırpma
            rect = new Rectangle(this.Width-x - 75, -x-100, 2 * x + 150, 2 * x + 150);
            startAngle = -270.0F;
            sweepAngle = 10.0F;
            e.Graphics.FillPie(redBrush, rect, startAngle, sweepAngle);

            brush = System.Drawing.Brushes.White;
            g.DrawString(mGosterilecekMetin, new Font("Arial", 10), brush, new Point(this.Width / 2 - 6 * mGosterilecekMetin.Length / 2, this.Height / 2 - 8));
            brush = System.Drawing.Brushes.Black;
            g.DrawString(panelName, new Font("Arial", 10), brush, new Point(this.Width / 2 - 5 * panelName.Length / 2, 2));
        }
        public override void islemYap(Algoritma.Program p)
        {
            p.Write(this.GosterilecekMetin + " : ");

            try
            {
                double sayi = p.Read();
                degiskenler.DegiskenDeger(this.DegiskenAdi, sayi);
            }
            catch (Exception)
            {
                p.ErrWrite("Metinsel ifade girildi");
            }
        }
    }
}
