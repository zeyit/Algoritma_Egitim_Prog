using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Algoritma
{
    public abstract class myPanel : Panel
    {
       private myPanel next1, next2;

       private bool txtYapilacakIslemGosterilecekMi;
       private bool txtMetinGoruntulensinMi;
       private bool cbDegiskenGosterilecekMi;
       private bool whGosterilecekMi;

       private String yapilacakIslem, gosterilecekMetin;

       public myPanel Next2
       {
           get { return next2; }
           set { next2 = value; }
       }

       public myPanel Next1
       {
           get { return next1; }
           set { next1 = value; }
       }

       public bool WHGosterilecekMi
      {
          get { return whGosterilecekMi; }
          set { whGosterilecekMi = value; }
      }

       public myPanel(int width, int height)
      {
          this.Width = width;
          this.Height = height;
          base.Size = new Size(width, height);
      }

       public bool CbDegiskenGosterilecekMi
      {
          get { return cbDegiskenGosterilecekMi; }
          set { cbDegiskenGosterilecekMi = value; }
      }
   
       public bool YapilacakIslemGosterilecekMi
      {
          get { return txtYapilacakIslemGosterilecekMi; }
          set { txtYapilacakIslemGosterilecekMi = value; }
      }
 
       public bool MetinGoruntulensinMi
       {
           get { return txtMetinGoruntulensinMi; }
           set { txtMetinGoruntulensinMi = value; }
       }

       public abstract void myPaint(object sender, PaintEventArgs e);

       public void GosterilecekDegiskenListesi(ComboBox cb, DegiskenListesi dl)
       {
            dl.degiskenleriListele(cb);
       }

       public  String GosterilecekMetin
       {
           get { return gosterilecekMetin; }
           set { gosterilecekMetin = value; }
       }

       public  String YapilacakIslem
       {
           get { return yapilacakIslem; }
           set { yapilacakIslem = value; }
       }

       public  void NesneBagla(myPanel nesne)
       {
           if (Next1 == null)
           {
               Next1 = nesne;
           }
           else if (this.GetType() ==typeof(Eger))
           {
               Next2 = nesne;
           }
           else
           {
               MessageBox.Show("Bu nesne den tek bir çizgi bağlanır");
           }
       }

       public void CizgileriSil()
       {
           this.next1 = null;
           this.next2 = null;
       }

       public virtual void islemYap(Program p)
       {
          
       }
    }
}
