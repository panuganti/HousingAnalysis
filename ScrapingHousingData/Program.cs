﻿using System;
using System.IO;
using System.Net;
using System.Threading;
using System.IO.Compression;

namespace ScrapingHousingData
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
                Console.WriteLine("Scraping {0}",i);
                string fileFullPath = Path.Combine(outputPath, String.Format("{0}.json.txt", i));
                if (File.Exists(fileFullPath))
                {
                    continue;
                }
                DateTime startTime = DateTime.Now;
                var writer = new StreamWriter(fileFullPath);
                string uriFormat =
                    "https://housing.com/api/v2/buy/{0}?key=MCwwDQYJKoZIhvcNAQEBBQADGwAwGAIRANqn%2FGhdm5m6QaktXd7nhp8CAwEAAQ%3D%3D";
                string uri = String.Format(uriFormat, i);
                var client = new WebClient();

                // Add a user agent header in case the  
                // requested URI contains a query.

                client.Headers.Add("Host", "housing.com");
                client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
                client.Headers.Add("X-Requested-With", "XMLHttpRequest");
                client.Headers.Add("User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36");
                client.Headers.Add("Referer",
                    "https://housing.com/in/buy/search/21000?f=eyJsb2N0IjoicG9seSIsInBvbHkiOnsiaWQiOiIxZmNmOGViZDUzYzZjN2QzMWE1YiIsImJ1ZmZlciI6ZmFsc2V9LCJlc3QiOnsiaWQiOm51bGwsInJhZGl1cyI6NTAwfSwiYXBhcnRtZW50X3R5cGVzIjpbNF0sIm1pbl9wcmljZSI6MjUwMDAwMH0%3D");
                client.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
                client.Headers.Add("Accept-Language", "en-US,en;q=0.8");
                client.Headers.Add("Cookie", "_ga=GA1.2.320883955.1431382222;");

                Stream data = client.OpenRead(uri);
                var responseStream = new GZipStream(data, CompressionMode.Decompress);
                var reader = new StreamReader(responseStream);
                string s = reader.ReadToEnd();
                DateTime endTime = DateTime.Now;

                writer.WriteLine(s);
                data.Close();
                reader.Close();
                writer.Close();
                Console.WriteLine("Scraping {0} Successful in {1} ms",i, (endTime-startTime).Milliseconds);
                Thread.Sleep(interval);
            }

        }
    }
}
