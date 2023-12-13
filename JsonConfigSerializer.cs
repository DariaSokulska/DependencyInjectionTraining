using DependencyTraining.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DependencyTraining
{
    internal class JsonConfigSerializer : IConfigSerializer
    {
        public Config Serialize(string path)
        {
            path = @"C:\Users\DSOKULSKA\source\repos\StoreTech\DependencyTraining\configs\configJson.txt";
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Config>(json)!;
        }
    }
}
