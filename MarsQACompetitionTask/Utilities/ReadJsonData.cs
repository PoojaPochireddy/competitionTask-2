using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQACompetitionTask.Utilities
{
   public class ReadJsonData
    {
        public static string GetData(string key)
        {
            string text = File.ReadAllText(@"../../Data/data.json");
            var myJObject = JObject.Parse(text);
            
            return (String)myJObject.SelectToken(key);
        }
        public static String GetDataObject1(string key)
        {
            string text = File.ReadAllText(@"../../Data/data.json");
            JObject myJObject = JObject.Parse(text);
            return (String)myJObject.SelectToken(key);
            
        }
        public static IList GetDataObject2(string key)
        {
            string text = File.ReadAllText(@"../../Data/data.json");
            JObject myJObject = JObject.Parse(text);
             IEnumerable < JToken > jk= myJObject.SelectTokens(key);
            //return (JToken) jk;
            IList items = myJObject.SelectTokens(key).ToList();
            return  items;

        }
    }
}
