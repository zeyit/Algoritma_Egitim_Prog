using Microsoft.Win32;
//using Microsoft.Win32;
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

            try
            {   
                Registry.ClassesRoot.CreateSubKey(".zyd").SetValue(null, "AlgoritmaDosyasi");
                RegistryKey rk = Registry.ClassesRoot.CreateSubKey(".zyd");
                rk.CreateSubKey("DefaultIcon").SetValue(null, (Application.StartupPath).ToLower() + "\\algoritma.ico");
                rk.CreateSubKey(@"Shell\Open\Command").SetValue(null, "\"" + Application.ExecutablePath + "\" \"%1\"");
                rk.Close();
            }
            catch (Exception)
            { }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                Application.Run(new Form1(args[0]));
            }
            else
            {
                Application.Run(new Form1());
            }
            
        }
        private static void ConsoleMain(string[] args)
        {
         //console app
        }

        public void Write(String txt)
        {
            Console.Write(txt +"  ");
        }
        public void WriteLine(String txt)
        {
            Console.WriteLine(txt);
        }

        public void ErrWrite(String txt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(txt);//
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public double Read()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
     
    }
}
