using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleList
{
    class Program
    {
        //enum PeopleList
        //{
        //    amdr = 1989,
        //    lda = 1995,
        //    oldman = 1955
        //}
        static void Main(string[] args)
        {
            List <Person> personsList = new List<Person>();
            bool decision = true;
            while (decision == true)
            {
                Console.WriteLine("Would you like to proceed? (Y/N)");
                var yn = Console.ReadLine();
                switch (yn)
                {
                    case "Y":
                    case "y":

                        Person chelovek = new Person();
                        if (chelovek.Age > 18)
                        {
                            int age = chelovek.Age;
                            string name = chelovek.Name;
                            personsList.Add(new Person() { Name = name, Age = age });
                            //personsList.AddRange(chelovek.Name, chelovek.Age);
                        }

                        break;
                    case "N":
                    case "n":
                        decision = false;
                        for(int i =0; i < personsList.Count; i++)
                        {
                            Console.WriteLine(personsList[i].Name + " is " + personsList[i].Age);
                        }
                        Console.ReadLine();
                        break;
                }
            } 
        }
    }
}
