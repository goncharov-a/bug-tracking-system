using System;
using System.Windows.Forms;
using System.IO;



namespace BugTrackingSystem
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log("Run Programm");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            Log("Exit Programm");
            
        }
        public static void Log(string message)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToString()+"  " + message + Environment.NewLine);
        }
    }
}
