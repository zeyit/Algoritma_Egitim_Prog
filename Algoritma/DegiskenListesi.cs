using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Algoritma
{
  public  class DegiskenListesi
    {
      private static Hashtable ht = new Hashtable();
      private String degiskenler;

      public DegiskenListesi() { }
      public DegiskenListesi(String degiskenler)
        {
            this.degiskenler = degiskenler;
            str_split();
        }

      private void str_split()
       {
           if (degiskenler.LastIndexOf(',') ==0)
           {
               degiskenler = degiskenler.Substring(0, degiskenler.Length - 1);
           }
           string[] degisken_deger = degiskenler.Split(',');

           for (int i = 0; i < degisken_deger.Length; i++)
           {
               try
               {
                   if (degisken_deger[i].IndexOf('=') !=-1)
                   {
                        String[] dv = degisken_deger[i].Split('=');
                        if (ht.ContainsKey(dv[0]) == true)
                        {
                            ht[dv[0]] = dv[1];
                        }
                        else
                        {
                            try
                            {
                                 ht.Add(dv[0], Convert.ToDouble(dv[1]));
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("lütfen sayısal veri tipi giriniz");
                            }
                        }
                   }
                   else
                   {
                       ht.Add(degisken_deger[i], 0.0);
                   }
               }
               catch (Exception){}
           }
       }

      public void clear()
       {
             ht.Clear();
       }
      
      public void degiskenleriListele(ComboBox liste) 
       {
           liste.Items.Clear();
           foreach (String item in ht.Keys)
           {
               liste.Items.Add(item);
           }
       }

      public void SetDegisken(String degiskenler)
       {
           this.degiskenler = degiskenler;
           str_split();
       }

      public Double Deger(String degiskenName)
       {
           if (ht.ContainsKey(degiskenName) == true)
           {
               return (Double)ht[degiskenName];
           }
           else
           {
               MessageBox.Show(degiskenName + " Değişkeni tanımlanmamış");
               return 0;
           }
       }

      public  void DegiskenDeger(String degiskenName, Double deger)
       {
           ht[degiskenName] = deger;
       }
     
      public String[] degiskenArray()
       {
           String[] d_name = new String[ht.Count];
           int i = 0;
           foreach (String item in ht.Keys)
           {
               d_name[i] = item; i++;
           }
           return d_name;
       }

      public void DegiskenYazdir(DataGridView dgv)
       {
           dgv.Rows.Clear();
           int i = 0;
           foreach (String key in ht.Keys)
           {
               dgv.Rows.Add();
               dgv.Rows[i].Cells[0].Value = key;
               dgv.Rows[i].Cells[1].Value = ht[key];
               i++;
           }
       }

      public void DegiskenSil(DataGridView dgv,String degiskenler)
       {
           if (degiskenler.LastIndexOf(',') == 0)
           {
               degiskenler = degiskenler.Substring(0, degiskenler.Length - 1);
           }
           string[] degisken_deger = degiskenler.Split(',');

           for (int i = 0; i < degisken_deger.Length; i++)
           {
               try
               {
                   if (degisken_deger[i].IndexOf('=') != -1)
                   {
                       String[] dv = degisken_deger[i].Split('=');
                       ht.Remove(dv[0]);
                   }
                   else
                   {
                       ht.Remove(degisken_deger[i]);
                   }
               }
               catch (Exception) { }
           }
           DegiskenYazdir(dgv);
       }
    }
}
