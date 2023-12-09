using AndroidNative = Android.App;
using Android.Net;
using Android.Net.Wifi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;

namespace SandboxApp.Services
{
    public partial class WifiManagerService
    {
        public partial string GetActiveSSID()
        {
            WifiManager wifiManager = (WifiManager)AndroidNative.Application.Context.GetSystemService(Service.WifiService);
            return wifiManager.ConnectionInfo.SSID;
        }
    }
}
