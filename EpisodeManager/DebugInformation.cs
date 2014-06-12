using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace EpisodeManager
{
    class DebugInformation
    {
        /// <summary>
        /// Generated on [date] at [time]
        /// 
        /// SMBXEpisodeManager.exe Information
        /// Version: 
        /// 
        /// Computer Information
        /// Windows Version: 
        /// 64-Bit: 
        /// Processor: 
        /// RAM: 
        /// 
        /// </summary>
        public string generateDebugInformation()
        {
            string debugText;
            string currentDate = DateTime.Today.ToString();
            //
            var thisApp = Assembly.GetExecutingAssembly();
            AssemblyName name = new AssemblyName(thisApp.FullName);
            string version = name.Version.ToString();
            //OS Junk
            string OSVer = Environment.OSVersion.ToString();
            string bbit;
            if (Environment.Is64BitOperatingSystem == true)
            {
                bbit = "true";
            }
            else
            {
                bbit = "false";
            }
            //Processor
            string clockspeed = "null";
            string datawidth = "null";
            string nameOf = "null";
            string manufacturer = "null";
            ManagementObjectSearcher mosProcessor = new ManagementObjectSearcher("SELECT*FROM Win32_Processor");
            foreach(ManagementObject moProcessor in mosProcessor.Get())
            {
                if (moProcessor["maxclockspeed"] != null)
                    clockspeed = moProcessor["maxclockspeed"].ToString();
                if (moProcessor["datawidth"] != null)
                    datawidth = moProcessor["datawidth"].ToString();
                if (moProcessor["name"] != null)
                    nameOf = moProcessor["name"].ToString();
                if (moProcessor["manufacturer"] != null)
                    manufacturer = moProcessor["manufacturer"].ToString();
            }
            //RAM
            string totalRam;
            ComputerInfo CI = new ComputerInfo();
            ulong mem = ulong.Parse(CI.TotalPhysicalMemory.ToString());
            totalRam = (mem / (1024 * 1024) + " MB").ToString();
            //

            debugText = "Generated on " + currentDate + 
                "\n\nSMBXEpisodeManager.exe Information\nVersion: " 
                + version + "\n\nComputer Information\nWindows Version: " 
                + OSVer + "64-Bit: " + bbit + 
                "\nProcessor: " + manufacturer + " " + nameOf + " " + clockspeed + " " + datawidth
                + "\nRAM: " + totalRam;

            return debugText;
        }
    }
}
