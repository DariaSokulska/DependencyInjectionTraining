using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyTraining
{
    internal class JsonRawConfigProvider : IRawConfigProvider
    {
        public string GetRawConfig()
        {
            return File.ReadAllText(@"C:\Users\DSOKULSKA\source\repos\StoreTech\DependencyTraining\configs\configJson.txt");
        }
    }
}
