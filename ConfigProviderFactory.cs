using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyTraining
{
    internal class ConfigProviderFactory : IConfigProviderFactory
    {
        public IConfigProvider Create(string configType)
        {
            IRawConfigProvider configProvider = null;
            IConfigSerializer configSerializer = null;
            switch (configType)
            {
                case "json":
                    configProvider = new JsonRawConfigProvider();
                    configSerializer = new JsonConfigSerializer();
                    return new ConfigProvider(configProvider, configSerializer);
                case "xml":
                    configProvider = new XmlRawConfigProvider();
                    configSerializer = new XmlConfigSerializer();
                    return new ConfigProvider(configProvider, configSerializer);
                default:
                    throw new ArgumentException("Not supported type");
            };
        }
    }
}
