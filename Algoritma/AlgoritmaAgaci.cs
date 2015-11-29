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

            while (aktif.GetType() != typeof(Dur) && (aktif.Next1 != null || aktif.Next2 != null))
            {
               
                
                aktif.BorderStyle = BorderStyle.FixedSingle;
             
                
               // Thread.Sleep(1000);
                if (aktif.GetType() == typeof(Baslat))
                {}
                else if (aktif.GetType() == typeof(Bekle))
                {
                    //bekleme yaptır
                }
                else if (aktif.GetType() == typeof(Cikis))
                {
                    Cikis output = (Cikis)aktif;
                    if (output.DegiskenAdi != "")
                    {
                        Double deger = 0.0;
                        try
                        {
                             deger = degiskenler.Deger(output.DegiskenAdi);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Değişken Tanımlanmamış");
                        }
                      
                        MessageBox.Show(aktif.GosterilecekMetin +" ,"+deger);
                    }
                    else
                    {
                         MessageBox.Show(aktif.GosterilecekMetin);
                    }
                }
                else if (aktif.GetType() == typeof(Dur))
                {
                    break;
                }
                else if (aktif.GetType() == typeof(Giris))
                {
                    Giris giris = (Giris)aktif; // girişte konsoldan değer okuması yap
                    string deger = Microsoft.VisualBasic.Interaction.InputBox(giris.DegiskenAdi, giris.GosterilecekMetin);
                    double sayi = 0.0;
                    try
                    {
                        sayi = Convert.ToDouble(deger);
                        degiskenler.DegiskenDeger(giris.DegiskenAdi, sayi);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Metinsel ifade girildi");
                    }
                    
                }
                else if (aktif.GetType() == typeof(Eger))
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
                    aktif.BorderStyle = BorderStyle.None;
                    continue;
                }
                else if (aktif.GetType() == typeof(Islem))
                {
                    //eşitliğe böl kesaplamayı ya ve atama yap
                    try
                    {
                        Islem islem =(Islem)aktif;
                        String islem_ifadesi = islem.YapilacakIslem;
                        String[] array = islem_ifadesi.Split('=');
                        Karar islem_yap = new Karar();
                        Double sonuc=  islem_yap.islemYap(array[1]);
                        String degisken = array[0];
                        degisken = degisken.Trim();
                        degiskenler.DegiskenDeger(degisken, sonuc);
                    }
                    catch (Exception){}
                }
                aktif.BorderStyle = BorderStyle.None;
                aktif = aktif.Next1;
            }
            MessageBox.Show("bitti");
        }
    }
}
