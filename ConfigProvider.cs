using DependencyTraining.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyTraining
{
    internal class ConfigProvider : IConfigProvider
    {
        private readonly IRawConfigProvider _rawConfigProvider;
        private readonly IConfigSerializer _configSerializer;

        public ConfigProvider(IRawConfigProvider rawConfigProvider, IConfigSerializer configSerializer)
        {
            _rawConfigProvider = rawConfigProvider;
            _configSerializer = configSerializer;
        }
        public Config GetConfig()
        {
            var configString = _rawConfigProvider.GetRawConfig();
            return _configSerializer.Serialize(configString);
        }
    }
}
