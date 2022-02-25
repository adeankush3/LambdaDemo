using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataMangement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Person Data Management");
            List<Person> list = new List<Person>();
            AddRecords(list);
            RetrivingTopTwoRecord(list);
            TeeanAgePerson(list);
            AvgAge(list);
            SpecificName(list);
            SkipRecord(list);
        }
        private static void AddRecords(List<Person> list)
        {
            list.Add(new Person("01", "Ankush", "Nanded", 27));
            list.Add(new Person("02", "Hariprasad", "Pune", 10));
            list.Add(new Person("03", "Santosh", "Parbhani", 13));
            list.Add(new Person("04", "Suresh", "Yavtmal", 50));
            list.Add(new Person("05", "Ade", "Mumbai", 12));
            list.Add(new Person("06", "Sachin", "Haidrabad", 19));
            list.Add(new Person("07", "Ananta", "Latur", 18));
            list.Add(new Person("08", "Mahesh", "Hingoli", 85));
            list.Add(new Person("09", "Swapnil", "Nagpur", 25));
            list.Add(new Person("10", "Chaitnya", "Solapur", 65));
            foreach(Person person in list)
            {
                Console.WriteLine(person.SSN + " " + person.Name + " " + person.Address + "-" + person.Age);
            }
        }
        
        private static void RetrivingTopTwoRecord(List<Person> list)
        {
            foreach(Person person in list.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name "+person.Name+"\t\tAge"+person.Age);
            }
        }
        
        private static void TeeanAgePerson(List<Person> list)
        {
            if(list.Any(e=>(e.Age>=13 && e.Age <= 19))) 
            {
                Console.WriteLine("\nYes,We Have Some Teen Agerss in the List");
            }
            else
            {
                Console.WriteLine("\nNo,We Don't Have Teen Agerss in the List");
            }
        }
       
        private static void AvgAge(List<Person> list)
        {
            Console.WriteLine("\nGetting Average of all the person's age...");
            double avgAge = list.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is: " + avgAge);
        }
       
        private static void SpecificName(List<Person> list)
        {
            Console.WriteLine("\nChecking whether a person having name 'Santosh' exists or not...");
            if (list.Exists(e => e.Name == "Santosh"))
            {
                Console.WriteLine("Yes, A person having name  'Santosh' exists in our list");
            }
            else
            {
                Console.WriteLine("No,We Don't Have Name in list");
            }
        }
        
        private static void SkipRecord(List<Person> list)
        {
            Console.WriteLine("\nSkipping every person whose age is less than 60 years...");
            foreach (Person person in list.SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        } 
    }
}
