using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Models
{
    internal class Courier
    {

        private static int _idCounter = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Courier(string Name)
        {
            Id = _idCounter++;
            this.Name = Name;
        }
    }
}
