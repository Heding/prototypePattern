using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypePattern.Models;
using PrototypePattern.PrototypeInfrastructure;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //bad way(all of instance have the same address but campus is different)
                //Student jack = new Student { StudentName = "Jack", UniversityAddress = new Address { City = "London", Street = "Baker St", Campus = 10 } };
                //Student stan = new Student { StudentName = "Jack", UniversityAddress = new Address { City = "London", Street = "Baker St", Campus = 100 } };

            Student jack = StudentFactory.getNewStudentInstance("jack", 10);
            Student stan = StudentFactory.getNewStudentInstance("stan", 1000);

            Console.WriteLine(jack);
            Console.WriteLine(stan);

            Console.ReadKey();

        }
    }
}
