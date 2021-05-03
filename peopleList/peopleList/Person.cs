using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleList
{
    class Person
    {

        
        private string name;
        private DateTime birthDate;

        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        

        public Person()
        {
            
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter DOB");
            string targetDateFormat = "dd/MM/yyyy";                    
            string dateOfBirth = Console.ReadLine();
            BirthDate = DateTime.ParseExact(dateOfBirth, targetDateFormat, CultureInfo.InvariantCulture);

            Age = GetAge();
            Console.WriteLine("{0} is {1} y.o.", Name, Age);
        }


        private int GetAge()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - BirthDate.Year;
            return age;
        }


    }
}
