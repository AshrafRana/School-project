using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace School_Managment_System
{
    class LicenseKeyGenerate
    {
        private string privateKey = "dfd51a2b775f7982e5d2ef6db6a0a5ce5e290c48";


        public string getPrivateKey() {

            return privateKey;
        }

        //Get MAC Address 
        public  string GetMacAddress()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                macAddresses = nic.GetPhysicalAddress().ToString();
                break;
            }
            return macAddresses;
        }

        //Get CPU Serial Number
        public string getCpuId()
        {
            string cpuId = String.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                    "select * from " + "Win32_Processor");

            foreach (ManagementObject share in searcher.Get())
            {
                cpuId = share.Properties["ProcessorID"].Value.ToString();

                break;
            }
            return cpuId;
        }


        //Get Hard disk Serial Number
        public string getHdId()
        {
            string cpuId = String.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                    "select * from " + "Win32_DiskDrive");

            foreach (ManagementObject share in searcher.Get())
            {
                cpuId = share["SerialNumber"].ToString();

                break;
            }
            return cpuId;
        }


        //Generate Hash for CPU , MAC Address , Hard disk , public key 
        public  string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {

                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
