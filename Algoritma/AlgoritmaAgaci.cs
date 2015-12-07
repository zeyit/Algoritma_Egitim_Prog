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

        public void Calistir(int hiz,bool isDegiskenIzle,DegiskenPenceresi dp)
        {
            myPanel aktif = baslat;
            DegiskenListesi degiskenler = new DegiskenListesi();
            Hashtable ht = new Hashtable();
            foreach (String key in degiskenler.getHT().Keys)
            {
                ht[key] = degiskenler.Deger(key) ;
            }
            //degisken izle
            int degisken_satir = 0;

            // Start console
            String[] prams = { "console" };
        
            Program p = new Program(prams);
            Action actionBorderNone = () => aktif.BorderStyle = BorderStyle.None;
            Action actionBorderFixed = () => aktif.BorderStyle = BorderStyle.FixedSingle;

            while (aktif != null && aktif.GetType() != typeof(Dur) && (aktif.Next1 != null || aktif.Next2 != null))
            {
                aktif.Invoke(actionBorderFixed);
                Thread.Sleep(hiz);
                aktif.Invoke(actionBorderNone);
                if (aktif.GetType() == typeof(for_))
                {
                    for_ f = (for_)aktif;
                    Karar karar = new Karar();
                    String[] parca = f.YapilacakIslem.Split(',');
                    string[] donguDegisken = parca[0].Split('=');
                    if (!f.IlkKontrol)
                    { //i artırma işlemi
                        try
                        {
                            double sonuc = karar.matematikIslemi(donguDegisken[0] + "+" + parca[2]);
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
                    if (karar.mantiksalKarar(parca[1]))
                    {
                        aktif = aktif.Next1;
                    }
                    else
                    {
                        aktif = aktif.Next2;
                        f.IlkKontrol = true;
                    }
                    continue;
                } else if (aktif.GetType() == typeof(Eger))
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
                    continue;
                }
                else if (aktif.GetType() == typeof(DegiskenIzle))
                {
                    DegiskenIzle di = (DegiskenIzle)aktif;
                    String degisken = di.YapilacakIslem;
                    string[] degisken_deger;
                    if (degisken.LastIndexOf(',') == 0)
                    {
                        degisken = degisken.Substring(0, degisken.Length - 1);
                    }
                    degisken_deger = degisken.Split(',');
                    Action satirEkle = () => { dp.PencereSatirEkle(); };
                    if (di.IlkKontrol)
                    {  
                       for (int i = 0; i < degisken_deger.Length; i++)
                       {
                           Action ekle = () => { dp.ColumsAdd(degisken_deger[i]); };

                           dp.Invoke(ekle);
                       }
                       di.IlkKontrol = false;
                    }
                    
                    dp.Invoke(satirEkle);
                    for (int i = 0; i < degisken_deger.Length; i++)
                    {
                        try
                        {
                            Action degerEkle = () =>dp.PencereDegerEkle(degisken_satir, i, degiskenler.Deger(degisken_deger[i]).ToString());
                            dp.Invoke(degerEkle);
                        }
                        catch (Exception) { }
                    }
                    degisken_satir++;
                }
                else
                {
                    aktif.Invoke(actionBorderFixed);
                }

                aktif.islemYap(p);
                aktif.Invoke(actionBorderNone);
                aktif = aktif.Next1;
            }
            p.WriteLine("Program Bitti.");
            Form1.SetThread();
        }

    }
}
