using System;
using System.Collections;
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
            Hashtable ht = new Hashtable();
            foreach (String key in degiskenler.getHT().Keys)
            {
                ht[key] = degiskenler.Deger(key) ;
            }
            // Start console
            String[] prams = { "console" };
            Program p = new Program(prams);
            Action actionBorderNone = () => aktif.BorderStyle = BorderStyle.None;
            Action actionBorderFixed = () => aktif.BorderStyle = BorderStyle.FixedSingle;
            

            while (aktif != null && aktif.GetType() != typeof(Dur) && (aktif.Next1 != null || aktif.Next2 != null))
            {
                  //  aktif.BorderStyle = BorderStyle.FixedSingle;
                aktif.Invoke(actionBorderFixed);
                  Thread.Sleep(1000);
                if (aktif.GetType() == typeof(for_))
                {
                    for_ f = (for_)aktif;
                    Karar karar = new Karar();
                    String[] parca = f.YapilacakIslem.Split(',');
                    string[] donguDegisken = parca[0].Split('=');
                    if (!f.IlkKontrol)
                    {
                        //i artırma işlemi
                        try
                        {
                            double sonuc = karar.islemYap(donguDegisken[0] + "+" + parca[2]);
                            degiskenler.DegiskenDeger(donguDegisken[0], sonuc);
                        }
                        catch (Exception)
                        {
                           
                            p.ErrWrite("işlem hatası oluştu");
                        }

                    }
                    else
                    {
                        
                        f.IlkKontrol = false;
                        if (parca[0].IndexOf('=') != -1)
                        {
                            degiskenler.DegiskenDeger(donguDegisken[0], Convert.ToDouble(donguDegisken[1]));
                        }
                    }
                    MessageBox.Show("for kararr");
                    if (karar.mantiksalKarar(parca[1]))
                    {
                        aktif = aktif.Next1;
                    }
                    else
                    {
                        aktif = aktif.Next2;
                        f.IlkKontrol = true;
                    }
                    aktif.Invoke(actionBorderNone);
                    continue;
                } else if (aktif.GetType() == typeof(Eger))
                {
                    Eger eger = (Eger)aktif;
                    Karar karar = new Karar(); MessageBox.Show("eger kararr");
                    if (karar.mantiksalKarar(eger.YapilacakIslem))
                    {
                        aktif = aktif.Next1;
                    }
                    else
                    {
                        aktif = aktif.Next2;
                    }
                    //  aktif.BorderStyle = BorderStyle.None;
                    aktif.Invoke(actionBorderNone);
                    continue;
                }
                aktif.islemYap(p);
               // aktif.BorderStyle = BorderStyle.None;
                aktif.Invoke(actionBorderNone);
                aktif = aktif.Next1;
            }
            p.WriteLine("Program Bitti.");
           
           
        }
    }
}
