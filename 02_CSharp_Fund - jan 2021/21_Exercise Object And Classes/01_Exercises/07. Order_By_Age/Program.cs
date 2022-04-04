using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_By_Age
{
    class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] orderByAge = line.Split();

                string name = orderByAge[0];
                string id = orderByAge[1];
                int age = int.Parse(orderByAge[2]);

                Person people = new Person()
                {
                    Name = name,
                    ID = id,
                    Age = age
                };
                listOfPersons.Add(people);
            }

            foreach (var person in listOfPersons.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age } years old.");
            }
        }
    }
}