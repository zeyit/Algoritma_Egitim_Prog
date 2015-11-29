using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Algoritma
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       public  Program(String[] args)
         {
             AllocConsole();
             ConsoleMain(args);
         }

        [STAThread]
       public static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void ConsoleMain(string[] args)
        {
         //console app
        }

        public void Write(String txt)
        {
            Console.Write(txt);
        }
        public void WriteLine(String txt)
        {
            Console.WriteLine(txt);
        }

        public void ErrWrite(String txt)
        {
            Console.WriteLine(txt);//
            
        }

        public double Read()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
    }
}
