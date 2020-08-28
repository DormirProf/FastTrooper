using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTrooper
{
    class Prov
    {
        public async static void Proverka() {
            var pList = Process.GetProcesses();
            if (pList.Count() != 0)
            {
                foreach(var process in pList)
                {
                    if(process.ProcessName == "putty")
                    {
                        process.Kill();
                    }
                }
            }
            await Task.Delay(100);
        }
    }
}
