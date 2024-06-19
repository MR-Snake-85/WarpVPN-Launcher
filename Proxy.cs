using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace Warp
{
    
    internal class Proxy
    {

        public void SetProxy(string Address)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true))
            {
                key.SetValue("ProxyEnable", 1);
                key.SetValue("ProxyServer", Address);
            }
        }
        public void UnSetProxy() 
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true))
            {
                key.SetValue("ProxyEnable", 0);

            }
            
        }
        public string GetStats_Address() 
        {
            
           RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
           var value = key.GetValue("ProxyServer");
           return value.ToString();
        }
        public string GetStats() {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            var value = key.GetValue("ProxyEnable");
            if (value.ToString() == "0")
            {
                return "Disabled";
            }
            else {
                return "Enabled";
            }
            

        }

    }
}

