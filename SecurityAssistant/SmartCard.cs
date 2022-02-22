using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityAssistant
{
    public class SmartCard
    {
        private static string Getdevice()
        {
            StringBuilder sbDevHst = new StringBuilder();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
            foreach (ManagementObject mgt in searcher.Get())
            {
                sbDevHst.AppendLine(Convert.ToString(mgt["Name"]));
                sbDevHst.AppendLine("");
            }
            return sbDevHst.ToString();
        }

        private static bool HaveSmartCard()
        {
            var res = Getdevice();
            return res.Contains("CardOS");
        }

        public static async void SmartCardMonitorAsync(int time_sencond)
        {
            await Task.Run(()=>
            {
                var count = 0;
                while (true)
                {
                    var res = HaveSmartCard();
                    if (res)
                    {
                        count++;
                        if (count > time_sencond/2)
                        {
                            MessageBox.Show("Please take away Smart Card if don't use it anymore", "SmartCard",MessageBoxButtons.OK, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                            count = 0;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                    Thread.Sleep(2000);
                }
            });
        }
    }
}
