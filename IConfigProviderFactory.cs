using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyTraining
{
    public interface IConfigProviderFactory
    {
        IConfigProvider Create(string configType);
    }
}
