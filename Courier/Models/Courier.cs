sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Models
{


    public class Customer
    {
        private static int _idCounter = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(string Name , string City)
        {
            Id = _idCounter++;
            this.Name = Name;
            this.City = City;
        }
    }
}