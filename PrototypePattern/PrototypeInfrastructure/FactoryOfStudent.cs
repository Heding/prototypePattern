using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypePattern.Models;

namespace PrototypePattern.PrototypeInfrastructure
{
    static class StudentFactory
    {
        private static Student studentPrototype = new Student{UniversityAddress = new Address { City = "London", Street = "Baker St" }};

        public static Student getNewStudentInstance(string StudentName, int Campus) {
            Student result = studentPrototype.getPrototype();
            result.StudentName = StudentName;
            result.UniversityAddress.Campus = Campus;
            return result;
        }

    }
}
