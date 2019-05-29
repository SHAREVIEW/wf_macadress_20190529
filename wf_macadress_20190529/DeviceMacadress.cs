using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Management;
using System.Net;
using Microsoft.Win32;
using System.IO;

namespace wf_macadress_20190529
{
    public class GetMAC
    {
        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        public string GetNetMACAddress()
        {
            string netmac = "";
            foreach (NetworkInterface netInt in NetworkInterface.GetAllNetworkInterfaces())
            {
                netmac = netInt.GetPhysicalAddress().ToString();

            }
            return netmac;
        }
    }

 
}
