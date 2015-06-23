using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ScrapingHousingData
{
    class Program
    {
        static void Main(string[] args)
        {


            string uriFormat = "https://housing.com/api/v2/buy/{0}?key=MCwwDQYJKoZIhvcNAQEBBQADGwAwGAIRANqn%2FGhdm5m6QaktXd7nhp8CAwEAAQ%3D%3D";
            string uri = String.Format(uriFormat, 20000);
            WebClient client = new WebClient();

            // Add a user agent header in case the  
            // requested URI contains a query.

            client.Headers.Add("Host", "housing.com");
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36");
            client.Headers.Add("Referer", "https://housing.com/in/buy/search/21000?f=eyJsb2N0IjoicG9seSIsInBvbHkiOnsiaWQiOiIxZmNmOGViZDUzYzZjN2QzMWE1YiIsImJ1ZmZlciI6ZmFsc2V9LCJlc3QiOnsiaWQiOm51bGwsInJhZGl1cyI6NTAwfSwiYXBhcnRtZW50X3R5cGVzIjpbNF0sIm1pbl9wcmljZSI6MjUwMDAwMH0%3D");
            client.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
            client.Headers.Add("Accept-Language", "en-US,en;q=0.8");
            client.Headers.Add("Cookie", "_ga=GA1.2.320883955.1431382222;");

            Stream data = client.OpenRead(uri);

            var responseStream = new GZipStream(data, CompressionMode.Decompress);
            StreamReader reader = new StreamReader(responseStream);
            string s = reader.ReadToEnd();
            Console.WriteLine(s);
            data.Close();
            reader.Close();
        }
    }
}
