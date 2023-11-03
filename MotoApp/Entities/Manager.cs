using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Entities
{
    internal class Manager : Employee
    {
        public Manager(string name) : base(name) { }

        public override string ToString()
        {
            return base.ToString()+"(Manager)";
        }

    }
}
