using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineChat
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Services.FilePathManager.AddFilePath("users", $"{Environment.CurrentDirectory}\\Data\\users.json");
            Services.FilePathManager.AddFilePath("images", $"{Environment.CurrentDirectory}\\Images\\");
            Services.FilePathManager.AddFilePath("icons", $"{Environment.CurrentDirectory}\\Icons\\");
            Services.FilePathManager.AddFilePath("media", $"{Environment.CurrentDirectory}\\Media\\"); 
            Services.FilePathManager.AddFilePath("chatContent", $"{Environment.CurrentDirectory}\\ChatContent\\content.json");
            Application.Run(new LogInForm());
        }
    }
}
