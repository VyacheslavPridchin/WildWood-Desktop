using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace WildWood_Desktop
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        public static OMTP_C.Client client = new OMTP_C.Client(ClientExtensions.serverPackets);

        [STAThread]
        static void Main()
        {
            Painter.Fonts.LoadFonts();

            client.Connect(GetUniqueKey(), "62.33.231.152", 44444);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists("token"))
                Application.Run(new Main());
            else
                Application.Run(new Login());
        }

        public static string GetUniqueKey()
        {
            string uniqueKey = String.Empty;
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                uniqueKey += queryObj["Architecture"];
                uniqueKey += queryObj["Caption"];
                uniqueKey += queryObj["Family"];
                uniqueKey += queryObj["ProcessorId"];
                ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
                foreach (ManagementObject mo in mbs.Get())
                {
                    uniqueKey += mo["SerialNumber"].ToString();
                }
            }

            return uniqueKey;
        }
    }
}
