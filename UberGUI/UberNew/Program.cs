using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drivo;

namespace UberNew
{
    //isi pr krna h kaam!!!!!!!!!
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            string con = "Data Source=DESKTOP-13N6TJM;Database=Uber;Trusted_Connection=True";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(folderPath, "textFile.txt");
            Utils.SetConnectionString(con);
            Utils.SetRiderFilePath(filePath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
