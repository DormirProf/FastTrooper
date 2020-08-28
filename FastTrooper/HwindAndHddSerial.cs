using System.Linq;
using System.Management;

namespace FastTrooper
{
    class HwindAndHddSerial
    {
        public static string GetHwind() =>
            (from x in new ManagementObjectSearcher("SELECT * FROM win32_processor").Get().OfType<ManagementObject>()
                select x.GetPropertyValue("ProcessorId")).First().ToString();
        public static string GetHddSerial() =>
            (from x in new ManagementObjectSearcher("SELECT * FROM win32_PhysicalMemory").Get().OfType<ManagementObject>()
                select x.GetPropertyValue("Serialnumber")).First().ToString();
    }
}
