using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern.Models
{
    [Serializable]
    class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Campus { get; set; }

        public override string ToString()
        {
            return String.Format("City: {0}, Street:{1}, Campus: {2}", City, Street, Campus);
        }
    }
}
