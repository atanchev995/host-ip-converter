using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace HostIpConverter
{
    class ConvertAddress
    {
        public async Task HostToIp(string hostname, Windows.UI.Xaml.Controls.ListView output)
        {
            HostName host = new HostName(hostname);
            var eps = await DatagramSocket.GetEndpointPairsAsync(host, "80");
            foreach (EndpointPair ep in eps)
            {
                string result = ep.RemoteHostName.ToString();
                //output.Items.Clear();
                output.Items.Add(result);
            }
        }
    }
}
