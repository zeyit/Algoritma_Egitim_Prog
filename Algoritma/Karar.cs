using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Algoritma
{
    class Karar
    {
        ScriptEngine engine = Python.CreateEngine();
        public bool mantiksalKarar(String mantiksal_ifade)
        {
            string karar_metni = ifade_temizle(mantiksal_ifade);
            MessageBox.Show(karar_metni);
            dynamic result = engine.Execute(karar_metni);     
            return result;
        }

        public double matematikIslemi(String mantiksal_ifade)
        {
            string karar_metni = ifade_temizle(mantiksal_ifade);
            dynamic result = engine.Execute(karar_metni);
            return result;
        }

        string degiskenleriKoy(String s)
        {
            DegiskenListesi dl = new DegiskenListesi();
            String islem_ifadesi = s;
            String[] d_name = dl.degiskenArray();
            for (int i = 0; i < d_name.Length; i++)
            {
                for (int j = 0; j < d_name.Length; j++)
                {
                    if (d_name[i].Length > d_name[j].Length)
                    {
                        String tmp = d_name[i];
                        d_name[i] = d_name[j];
                        d_name[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < d_name.Length; i++)
            {
                islem_ifadesi = islem_ifadesi.Replace(d_name[i], Convert.ToString(dl.Deger(d_name[i])));
            }
            return islem_ifadesi;
        }

        string ifade_temizle(String str)
        {
            string karar_metni = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ToCharArray()[i] == ' ')
                { continue; }
                karar_metni += str.ToCharArray()[i];
            }
            return degiskenleriKoy(karar_metni);
        }
    }
}
