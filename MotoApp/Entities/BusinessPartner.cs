using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Entities
{
    public class BusinessPartner : Employee, IEntity
    {
        //public int Id { get; set; }
       // public string FirstName { get; set; }
        public BusinessPartner() { }
        public BusinessPartner(string name)
        {

            FirstName = name;
        }
        public override string ToString() => $"BusinessPartner Id: {Id}, FirstName: {FirstName}";
    }
}
