using System;
using System.Collections.Generic;
using System.IO;
using HousingDataLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace ProcessHousingData
{
    class Program
    {
        static void Main(string[] args)
        {
            string datapath = File.ReadAllLines("./Config.ini")[0];
            var houseListings = new List<HouseListing>();
            for (int i = (20000-1); i > 10000; i--)
            {
                Console.WriteLine("Loading data for {0}",i);
                string filename = Path.Combine(datapath, String.Format("{0}.json.txt", i));
                if (!File.Exists(filename))
                {
                    Console.WriteLine("File {0} does not exist",i);
                    continue;
                }
                string jsonResponse = File.ReadAllText(filename);
                try
                {
                    var response = JsonConvert.DeserializeObject<HouseListingResponse>(jsonResponse, new StringEnumConverter());
                    if (response == null)
                    {
                        Console.WriteLine("Error in file {0}", i); continue;
                    }
                    if (response.status == "OK" && response.message == "success")
                    {
                        houseListings.Add(response.result);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error in file {0}",i); continue;
                }

                if (i % 10000 == 0)
                {
                    var houses = JsonConvert.SerializeObject(houseListings);
                    File.WriteAllText(String.Format("./AllHouses_{0}.txt",i), houses);
                    houseListings = new List<HouseListing>();
                    GC.Collect();
                }
            }

            var housesLast = JsonConvert.SerializeObject(houseListings);
            File.WriteAllText(String.Format("./AllHouses_10000.txt"), housesLast);

            Console.WriteLine("{0} house listings loaded", houseListings.Count);
            Console.ReadKey();
        }
    }
}
