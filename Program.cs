using DependencyTraining.models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IRawConfigProvider rawConfigProvider = new XmlRawConfigProvider();
            //IConfigSerializer configSerializer = new XmlConfigSerializer();

            //ConfigProvider configProvider = new(rawConfigProvider, configSerializer);
            //var config = configProvider.GetConfig();

            //IRawConfigProvider rawConfigProviderJson = new JsonRawConfigProvider();
            //IConfigSerializer configSerializerJson = new JsonConfigSerializer();

            //ConfigProvider configProviderJson = new(rawConfigProviderJson, configSerializerJson);
            //var config1 = configProviderJson.GetConfig();
            //Console.WriteLine(config1.ToString());

            var builder = Host.CreateApplicationBuilder(args);
            //builder.Services.AddSingleton<IRawConfigProvider, JsonRawConfigProvider>();
            //builder.Services.AddSingleton<IConfigSerializer, JsonConfigSerializer>();
            //builder.Services.AddSingleton<IRawConfigProvider, XmlRawConfigProvider>();
            //builder.Services.AddSingleton<IConfigSerializer, XmlConfigSerializer>();
            //builder.Services.AddSingleton<IConfigProvider, ConfigProvider>();
            builder.Services.AddSingleton<IConfigProviderFactory, ConfigProviderFactory>();
            var app = builder.Build();
            var configProviderFactory = app.Services.GetService<IConfigProviderFactory>();
            var provider = configProviderFactory.Create("json");
            var config = provider.GetConfig();
            provider = configProviderFactory.Create("xml");
            config = provider.GetConfig();
        }
    }
}