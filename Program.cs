using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Calculadoras
{
    public static class Aux
    {
        public static SelectCalc scalc;
        public static string file = Directory.GetCurrentDirectory() + @"\Database\Usuarios_Registrados.xlsx";


        public static string BTC;
        public static string DOP;
        public static string USD;
        public static string Eur;
        public static string Venz;

        // public static 
    }
    public static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new Ahorro());
            //Application.Run(new SelectCalc());
        }



    }
    
}
