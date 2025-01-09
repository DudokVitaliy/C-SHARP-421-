using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05_Class_HW
{
    internal class MyWebSite
    {
        private string siteName;
        private string siteUrl;
        private string siteDescription;
        private string siteIP;
        public string SiteName {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    siteName = value;
                else
                    siteName = "empty";
            }
            get => siteName;
        } 
        public string SiteUrl
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    siteUrl = value;
                else
                    siteUrl = "empty";
            }
            get => siteUrl;
        }
        public string SiteDescription
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    siteDescription = value;
                else
                    siteDescription = "empty";
            }
            get => siteDescription;
        }
        public string SiteIP
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    siteIP = value;
                else
                    siteIP = "empty";
            }
            get => siteIP;
        }
        public MyWebSite()
        {
            SiteName = "empty";
            SiteUrl = "empty";
            SiteDescription = "empty";
            SiteIP = "empty";
        }
        public MyWebSite(string Name, string URL, string Description, string IP)
        {
            SiteName = Name;
            SiteUrl = URL;
            SiteDescription = Description;
            SiteIP = IP;
        }
        public override string ToString() =>
            $"\tYour WebSite: \nName :: {SiteName}\nURL :: {SiteUrl}\nDescription :: {SiteDescription}\nIP :: {SiteIP}";
        public void FillInfo()
        {
            Console.WriteLine("\tEnter all site info: ");
            Console.Write("Name: \t\t"); SiteName = Console.ReadLine();
            Console.Write("URL: \t\t"); SiteUrl = Console.ReadLine();
            Console.Write("Description:\t"); SiteDescription = Console.ReadLine();
            Console.Write("IP: \t\t"); SiteIP = Console.ReadLine();
        }

    }
}
