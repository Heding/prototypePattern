using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    [Serializable]
    class Student
    {
        public string StudentName { get; set; }
        public Address UniversityAddress { get; set; }

        public override string ToString()
        {
            return String.Format("StudentName: {0}, Address: {1}", StudentName, UniversityAddress.ToString());
        }

    }


}
