using Microsoft.Win32;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Algoritma
{
    public class Program
    {
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
            Application.SetCompatibleTextRenderingDefault(true);
            if (args.Length > 0)
            {
                Application.Run(new Form1(args[0]));
            }
            else
            {
                Application.Run(new Form1());
            }
        }

    }
}
