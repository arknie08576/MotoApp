using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public Employee(string name)
        {

            FirstName = name;
        }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";


    }
}
