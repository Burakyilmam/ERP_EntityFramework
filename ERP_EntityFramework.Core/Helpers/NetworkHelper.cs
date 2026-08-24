using System.Net;
using System.Net.Sockets;

namespace ERP_EntityFramework.DataAccess.Helpers
{
    public static class NetworkHelper
    {
        public static string GetIPAddress()
        {
            string hostName = Dns.GetHostName();

            IPAddress[] addresses = Dns.GetHostAddresses(hostName);

            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    return address.ToString();
                }
            }

            return null;
        }
    }
}