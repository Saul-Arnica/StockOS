using System;
using System.Windows.Forms;
using StockOS.UI.WinForms.Forms;

namespace StockOS.UI.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Para evitar conflictos con StockOS.Application:
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // Como el proyecto usa .NET 8 con soporte completo de WinForms:
            ApplicationConfiguration.Initialize();
            
        }
    }
}