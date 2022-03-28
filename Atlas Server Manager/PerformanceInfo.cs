using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace AtlasServerManager
{
    class PerformanceInfo
    {
        public event PerformanceUpdate UpdateEvent;
        System.Threading.Timer timer;

        public delegate void PerformanceUpdate(string memory, string cpu);

        public PerformanceInfo()
        {
            timer = new System.Threading.Timer(new TimerCallback(TickTimer), null, 1000, 1000);            
        }

        private void TickTimer(object? state)
        {
            UpdateEvent?.Invoke(GetCurrentMemoryUsage().ToString() + "%", GetCurrentCpuUsage().ToString() + "%");
        }

        public static int GetCurrentMemoryUsage()
        {
            var wmiObject = new ManagementObjectSearcher("SELECT FreePhysicalMemory, TotalVisibleMemorySize from Win32_OperatingSystem");
            var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new {
                FreePhysicalMemory = double.TryParse(mo["FreePhysicalMemory"].ToString(), out double temp) ? temp : -1,
                TotalVisibleMemorySize = double.TryParse(mo["TotalVisibleMemorySize"].ToString(), out temp) ? temp : -1
            }).FirstOrDefault();

            if (memoryValues != null)
                return (int)(((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100);

            return 0;
        }

        public static int GetCurrentCpuUsage()
        {
            return Convert.ToInt32(new ManagementObjectSearcher("SELECT PercentProcessorTime FROM Win32_PerfFormattedData_PerfOS_Processor WHERE Name='_Total'").Get().Cast<ManagementObject>().First().Properties["PercentProcessorTime"].Value);
        }
    }
}
