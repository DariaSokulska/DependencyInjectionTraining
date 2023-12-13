using DependencyTraining.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DependencyTraining
{
    internal class XmlConfigSerializer : IConfigSerializer
    {
        public Config Serialize(string config)
        {
            var serializer = new XmlSerializer(typeof(Config));
            using (var reader = new StringReader(config))
            {
                return (Config)serializer.Deserialize(reader)!;
            }
        }
    }
}
