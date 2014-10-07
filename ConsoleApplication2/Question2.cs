using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class Question2
    {
        public enum Occupation
        {
            Programmer,
            Doctor,
            Lawyer,
            Teacher,
            Overlord
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Occupation Occupation { get; set; }
        }

        public void PrintAllPeopleByOccupation(IList<Person> people, Occupation occupation)
        {
            //Implement a method which will print the first and last name of all people with a particular occupation to the console.
            //Bonus #1: Use Linq!
            //Bonus #2: Reimagine this method as an extension method on an IList of people.
        }
    }
}
