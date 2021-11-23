using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace PrototypeCheckoutSystem
{
    class PrormaSC
    {
        static void Main()
        {
            RdWrJsonFile();
            Console.ReadLine();
            Console.WriteLine("Exiting program.");
            System.Environment.Exit(0);

        }

        public static void RdWrJsonFile()
        {
            string filepath = "../../SchemaList.json";
            string readResult = string.Empty;
            string writeResult = string.Empty;

            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);
                readResult = jobj.ToString();
                Console.WriteLine(readResult);

                foreach (var item in jobj.Properties())
                {
                    item.Value = item.Value.ToString().Replace("v2", "v1");
                }
                writeResult = jobj.ToString();
                Console.WriteLine(writeResult);
            }

            File.WriteAllText(filepath, writeResult);
        }
    }
}

// Output:
//
//{
//  "AuthenticateCmdlets": "toyota/v1",
//  "GetPowerState": "toyota/v1/Engine",
//  "PowerOff": "toyota/v1/Engine",
//  "PowerOn": "toyota/v1/Engine"
//}
//{
//  "AuthenticateCmdlets": "toyota/v2",
//  "GetPowerState": "toyota/v2/Engine",
//  "PowerOff": "toyota/v2/Engine",
//  "PowerOn": "toyota/v2/Engine"
//}