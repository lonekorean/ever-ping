using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace CodersBlock.EverPing
{
    public static class EverPinger
    {
        public static void Start(string url, int interval)
        {
            Task.Factory.StartNew(() => RunPingLoop(url, interval), TaskCreationOptions.LongRunning);
        }

        private static void RunPingLoop(string url, int interval)
        {
            while (true)
            {
                Thread.Sleep(interval);
                using (WebClient client = new WebClient())
                {
                    // why not use System.Net.NetworkInformation.Ping, you ask?
                    // because I want to actually hit the page, not just check if the server is responding
                    client.DownloadString(url);
                }
            }
        }
    }
}
