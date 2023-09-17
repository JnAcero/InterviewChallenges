using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace src.Services
{
    public class ChallengeService
    {
        public static JArray DeserealizeJson(string json){
            var JsonDeserealized = JArray.Parse(json);
            return JsonDeserealized;
        }  
        public static JArray ReadAndLoadDataFromFile(string path){
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                var data = ChallengeService.DeserealizeJson(json);
                return data;
            }
        }
    }
}