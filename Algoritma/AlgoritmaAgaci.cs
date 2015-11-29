using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Algoritma
{
    class AlgoritmaAgaci
    {
        //kurucu da baslat nesnesini al while gez son a veya null gelene kadar gez son gelmeden null geliyorsahata ver
        myPanel baslat;
        public AlgoritmaAgaci(Baslat baslat)
        {
            this.baslat = baslat;
        }
        
        public void Calistir()
        {
            myPanel aktif = baslat;
            DegiskenListesi degiskenler = new DegiskenListesi();
            // Start console
            String[] prams = { "console" };
            Program p = new Program(prams);
            

            while (aktif.GetType() != typeof(Dur) && (aktif.Next1 != null || aktif.Next2 != null))
            {
                  //  aktif.BorderStyle = BorderStyle.FixedSingle;
                 // Thread.Sleep(1000);
               
                if (aktif.GetType() == typeof(Eger))
                {
                    Eger eger = (Eger)aktif;
                    Karar karar = new Karar();
                    if (karar.mantiksalKarar(eger.YapilacakIslem))
                    {
                        aktif = aktif.Next1;
                    }
                    else
                    {
                        aktif = aktif.Next2;
                    }
                    //  aktif.BorderStyle = BorderStyle.None;
                    continue;
                }
                aktif.islemYap(p);
               // aktif.BorderStyle = BorderStyle.None;
                aktif = aktif.Next1;
            }
            p.WriteLine("Program Bitti.");
        }
    }
}
