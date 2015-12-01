using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Algoritma
{
    class Karar
    {
       private String karar_metni,ifade1,ifade2;
       private bool sonuc;
       private int karar_operant;
        public Karar()
        {
            sonuc = false;
            karar_metni = "";
            karar_operant = -1;
        }

        public bool mantiksalKarar(String mantiksal_ifade)
        {
            karar_metni = ifade_temizle(mantiksal_ifade);
          
            if (karar_metni.IndexOf("<")!=-1)
            {
                ifade1 = karar_metni.Substring(0, karar_metni.IndexOf("<"));
                if (karar_metni.IndexOf("=")!=-1)
                {
                 int start = karar_metni.IndexOf("=");
                 ifade2 =karar_metni.Substring(start+1, karar_metni.Length-start-1);
                 karar_operant = 0;
                }
                else
                {
                    int start=karar_metni.IndexOf("<");
                    ifade2 =karar_metni.Substring(start+1, karar_metni.Length-start-1);
                    karar_operant = 1;
                }
            }
            else if (karar_metni.IndexOf(">")!=-1)
            {
                ifade1 = karar_metni.Substring(0, karar_metni.IndexOf(">"));
                if (karar_metni.IndexOf("=") != -1)
                {
                    int start = karar_metni.IndexOf("=");
                    ifade2 = karar_metni.Substring(start + 1, karar_metni.Length - start-1);
                    karar_operant = 2;
                }
                else
                {
                    int start = karar_metni.IndexOf(">");
                    ifade2 = karar_metni.Substring(start + 1, karar_metni.Length - start-1);
                    karar_operant = 3;
                }
            }
            else if (karar_metni.IndexOf("=") !=-1)
            {
                ifade1 = karar_metni.Substring(0, karar_metni.IndexOf("=")); 
                if (karar_metni.IndexOf("!") != -1)
                {
                    int start = karar_metni.IndexOf("!");
                    ifade1 = karar_metni.Substring(0, start);
                    ifade2 = karar_metni.Substring(start + 2, karar_metni.Length - start-2);
                    karar_operant = 4;
                }
                else
                {
                    int start = karar_metni.LastIndexOf("=");
                    ifade2 = karar_metni.Substring(start + 1, karar_metni.Length - start-1);
                    karar_operant = 5;
                }
            }
            double sayi1 = matematikIslemi(ifade1);
            double sayi2 = matematikIslemi(ifade2);
            if (karar_operant ==0)
            {
                sonuc = sayi1 <= sayi2 ? true : false;
            } else if (karar_operant ==1)
            {
                sonuc = sayi1 < sayi2 ? true : false;
            }else if(karar_operant ==2)
            {
                sonuc = sayi1 >= sayi2 ? true : false;
            }else if (karar_operant == 3)
            {
                sonuc = sayi1 > sayi2 ? true : false;
            }else if (karar_operant == 4)
            {
                sonuc = sayi1 != sayi2 ? true : false;
            }
            else if (karar_operant == 5)
            {
                sonuc = sayi1 == sayi2 ? true : false;
            }
            else
            {
                MessageBox.Show("ifade hatalı");
                sonuc = false;
            }
            return sonuc;
        }

        public double matematikIslemi(String s)
        {
            String ifade = degiskenleriKoy(s);
            try
            {
                return Convert.ToDouble(s);
            }
            catch (Exception) {}
            return islemYap(ifade);
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
           /* for (int i = 0; i < d_name.Length; i++)
            {
                 MessageBox.Show(d_name[i]);
            }*/
            for (int i = 0; i < d_name.Length; i++)
            {
              islem_ifadesi=  islem_ifadesi.Replace(d_name[i],Convert.ToString(dl.Deger(d_name[i])));
            }
           
            return islem_ifadesi;
        }

        string ifade_temizle(String str)
        {
            karar_metni = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ToCharArray()[i] == ' ')
                {
                    continue;
                }
                karar_metni += str.ToCharArray()[i];
            }
            return karar_metni;
        }

        public double islemYap(String s)
        {
            return new MatematikIslem(degiskenleriKoy(ifade_temizle(s))).hesapla();
        }

    }

 class MatematikIslem {
	   private Stack charStack;
	   private Stack_islem islem;
	   private char[] input;
	   private String output = "";
       private ArrayList math_ifadeler;

       public MatematikIslem(String input)
       {
	      this.input = input.ToCharArray();
          int stackSize = input.Length;
          charStack = new Stack(stackSize);
	      islem =new Stack_islem(stackSize);
          math_ifadeler = new ArrayList();
          postFix();
	   }
	   public void postFix() {
		   char onceki_karakter =' ';
            
	      for (int j = 0; j < input.Length; j++) {
	    	  int onceki_indis=j;
	    	  onceki_indis--;
	    	  onceki_karakter = j!=0 ? input[onceki_indis] : ' ';
	         char ch = input[j];
	         switch (ch) {
	            case '+': 
	            case '-':
	            gotOper(ch, 1); 
	            break; 
	            case '*':
                case '%':
	            case '/':
	            gotOper(ch, 2); 
	            break; 
	            case '(':
                charStack.push(ch);
	            break;
	            case ')': 
	            gotParen(ch); 
	            break;
	            default: 
	            output = output + ch;

                if (!islem.isEmpty() && onceki_karakter != ' ' && (Char.IsDigit(onceki_karakter) || onceki_karakter == '.'))
                {
	            	String s =islem.pop();
                    islem.push(s + Char.ToString(ch));
				}else {
                    islem.push(Char.ToString(ch));
				}
	            break;
	         }
	      }
          while (!charStack.isEmpty())
          {
              char ch = charStack.pop();
	         output = output +ch;
             islem.push(Char.ToString(ch));
	      }
          while (!islem.isEmpty())
          {
              math_ifadeler.Add(islem.pop());
          }
          math_ifadeler.Reverse();
 }

      public double hesapla()
       {
           String str = "";
           for (int i = 0; i < math_ifadeler.Count; i++)
           {
               str += math_ifadeler[i]+",";
           }
        
           double sonuc = 0.0;
           while (true)
           {
               if (math_ifadeler.Count < 2)
               {
                   sonuc = Convert.ToDouble(math_ifadeler[0]);
                   break;
               }
               double operant1 = 0.0, operant2 = 0.0;
               char myoperator=' ';
               for (int i = 2; i < math_ifadeler.Count; i++)
               {
                   bool isOperant1 = false, isOperant2 = false, isOperator = false;
                   int index =i-2;
                   try
                   {
                       operant1 = Convert.ToDouble(math_ifadeler[index]);
                       isOperant1 = true;
                   }
                   catch (Exception){ }
                   try
                   {
                       operant2 = Convert.ToDouble(math_ifadeler[++index]);
                       isOperant2 = true;
                   }
                   catch (Exception) { continue; }
                   try
                   {
                       myoperator = Convert.ToChar(math_ifadeler[i]);
                       isOperator = !(Char.IsDigit(Convert.ToChar(math_ifadeler[i])));
                   }
                   catch (Exception) { continue; }
            
                   if (isOperant1 && isOperant2 && isOperator)
                   {
                       switch (myoperator)
                       {
                           case '+':
                               sonuc = operant1 + operant2;
                               break;
                           case '-':
                                sonuc = operant1 - operant2;
                               break;
                           case '*':
                                sonuc = operant1 * operant2;
                               break;
                           case '/':
                             sonuc = operant1 / operant2;
                               break;
                           case '%':
                               sonuc = operant1 % operant2;
                               break;
                           default: /*MessageBox.Show("işlem hatası");*/ break;
                       }
                       math_ifadeler[i] = Convert.ToString(sonuc);
                       index--;
                       math_ifadeler.RemoveAt(index);
                       math_ifadeler.RemoveAt(index);
                   
                       break;
                   }
               }
           }
          
           return sonuc;
       }
    void gotOper(char opThis, int prec1) {
        while (!charStack.isEmpty())
        {
            char opTop = charStack.pop();
	         if (opTop == '(') {
                 charStack.push(opTop);
	            break;
	         }
	         else {
	            int prec2;
	            if (opTop == '+' || opTop == '-')
	            prec2 = 1;
	            else
	            prec2 = 2;
	            if (prec2 < prec1) {
                    charStack.push(opTop);
	               break;
	            }
			    else
	            output = output + opTop;
                islem.push(Char.ToString(opTop));
	         }
	      }
        charStack.push(opThis);
	   }
	   
    void gotParen(char ch)
        {
            while (!charStack.isEmpty())
            {
                char chx = charStack.pop();
	         if (chx == '(') 
	         break; 
	         else
	         output = output + chx;
             islem.push(Char.ToString(chx));
              
	      }
	   }
 }

class Stack {
	 private int maxSize;
	 private char[] stackArray;
	 private int top;
	 public Stack(int max) {
	     maxSize = max;
	     stackArray = new char[maxSize];
	     top = -1;
	   }
	   public void push(char j) {
	     stackArray[++top] = j;
	   }
	   public char pop() {
	         return stackArray[top--];
	      }
	      public char peek() {
	         return stackArray[top];
	      }
	      public bool isEmpty() {
	         return (top == -1);
	     }
}

 class Stack_islem {
     private int maxSize;
     private String[] stackArray;
     private int top;
     public Stack_islem(int max) {
        maxSize = max;
        stackArray = new String[1000];
        top = -1;
     }

     public void push(String j) {
        stackArray[++top] = j;
     }
     public String pop() {
        return stackArray[top--];
     }
     public String peek() {
        return stackArray[top];
     }
     public bool isEmpty() {
        return (top == -1);
    }
  }
}