using System;
using System.IO;
using System.Net;
using System.Threading;
using System.IO.Compression;

namespace ScrapeMagicBricks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] configStrings = File.ReadAllLines("./Config.ini");
            int start = Int32.Parse(configStrings[0]);
            int end = Int32.Parse(configStrings[1]);
            int interval = Int32.Parse(configStrings[2]);
            string outputPath = configStrings[3];

            for (int i = start; i > end; i--)
            {
                Console.WriteLine("Scraping {0}", i);
                string fileFullPath = Path.Combine(outputPath, String.Format("{0}.html", i));
                if (File.Exists(fileFullPath))
                {
                    continue;
                }
                DateTime startTime = DateTime.Now;
                var writer = new StreamWriter(fileFullPath);
                string uriFormat = "http://www.magicbricks.com/propertyDetails/propertyDetailsMapSearch.html?id={0}";
                string uri = String.Format(uriFormat, i);
                var client = new WebClient();

                // Add a user agent header in case the  
                // requested URI contains a query.

                client.Headers.Add("Host", "www.magicbricks.com");
                client.Headers.Add("Accept", "*/*");
                client.Headers.Add("X-Requested-With", "XMLHttpRequest");
                client.Headers.Add("User-Agent","Mozilla/5.0 AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36");
                client.Headers.Add("Referer","");
                client.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
                client.Headers.Add("Accept-Language", "en-US,en;q=0.8");
                client.Headers.Add("Cookie", "");

                try
                {
                    Stream data = client.OpenRead(uri);
                    var responseStream = new GZipStream(data, CompressionMode.Decompress);
                    var reader = new StreamReader(responseStream);
                    string s = reader.ReadToEnd();
                    writer.WriteLine(s);
                    data.Close();
                    reader.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    continue;
                }
                DateTime endTime = DateTime.Now;
                writer.Close();
                Console.WriteLine("Scraping {0} Successful in {1} ms", i, (endTime - startTime).Milliseconds);
                Thread.Sleep(interval);
            }
        }
    }
}
