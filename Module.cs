using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_practice
{
    internal class Module
    {
        string moduleCode, name, description, links;

        public Module(string moduleCode, string name, string description, string links)
        {
            this.moduleCode = moduleCode;
            this.name = name;
            this.description = description;
            this.links = links;
        }

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Links { get => links; set => links = value; }

        public override string ToString()
        {
            return $"{moduleCode}\n{name}\n{description}\n{links}";
        }
    }
}
