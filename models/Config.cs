using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DependencyTraining.models
{
    public class Config
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Config()
        {
         
        }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
