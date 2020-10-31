// Chad Weirick
// GCU & TPS
// IIS Mover
// Overall use:  supports the ability to manipulate app pools
// Methods: FetchAppPools() returns a list of app pools
// StartAppPool(String sAppPoolName, int iWait) // starts a specified app pool and waits a set amount of time
// StopAppPool(String sAppPoolName, int iWait) // stops a specified app pool and waits a set amount of time

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Web.Administration;

namespace IIS_Mover
{
    class AppPoolService
    {
        public List<string> FetchAppPools()
        {
            List<string> lAppPoolNames = new List<string>();
            foreach (var vAppPool in new ServerManager().ApplicationPools)
            {
                lAppPoolNames.Add(vAppPool.Name);                
            }
            return lAppPoolNames;
        }

        public void StartAppPool(String sAppPoolName, int iWait) // starts a specified app pool and waits a set amount of time
        {
            foreach (var vAppPool in new ServerManager().ApplicationPools)
            {
                if (vAppPool.Name.Equals(sAppPoolName))
                {
                    vAppPool.Start();
                }                
            }
            Thread.Sleep(iWait * 1000);
        }
        public void StopAppPool(String sAppPoolName, int iWait) // stops a specified app pool and waits a set amount of time
        {
            foreach (var vAppPool in new ServerManager().ApplicationPools)
            {
                if (vAppPool.Name.Equals(sAppPoolName))
                {
                    vAppPool.Stop();
                }
            }
            Thread.Sleep(iWait * 1000);
        }
    }
}
