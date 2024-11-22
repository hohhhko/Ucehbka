using System;
using System.Windows.Forms;

namespace TEACHOR
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }

        public static class DAB
        {
            public static string ConnectionString = @"Data Source=Tehnic.db; Integrated Security=False; MultipleActiveResultSets=True";
        }

        public static class Table_Kabinet
        {
            public static string main = "Kabinet";
            public static string ID = "ID";
            public static string NumberKab = "NumberKab";
            public static string NameMain = "NameMain";
            public static string Tecnik = "Tecnik";
            public static string Status = "Status";
            public static string Date = "Date";
        }
        public static class Table_Storage
        {
            public static string main = "Storage";
            public static string ID = "ID";
            public static string NameTechn = "NameTechn";
            public static string Cost = "Cost";
            public static string Status = "Status";
            public static string Date = "Date";
        }
        public class DataCase
        {
            public static string NumberKab { get; set; }
        }
    }
}
