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
        }
        private static void AddRecords(List<Person> list)
        {
            list.Add(new Person("01", "Ankush", "Nanded", 27));
            list.Add(new Person("02", "Hariprasad", "Pune", 10));
            list.Add(new Person("03", "Santosh", "Parbhani", 13));
            list.Add(new Person("04", "Suresh", "Yavtmal", 21));
            list.Add(new Person("05", "Ade", "Mumbai", 12));
            list.Add(new Person("06", "Sachin", "Haidrabad", 19));
            list.Add(new Person("07", "Ananta", "Latur", 18));
            list.Add(new Person("08", "Mahesh", "Hingoli", 23));
            list.Add(new Person("09", "Swapnil", "Nagpur", 25));
            list.Add(new Person("10", "Chaitnya", "Solapur", 24));
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
                Console.WriteLine("Yes,We Have Some Teen Agerss in the List");
            }
            else
            {
                Console.WriteLine("No,We Don't Have Teen Agerss in the List");
            }
        }
        private static void AvgAge(List<Person> list)
        {
            Console.WriteLine("Getting Average of all the person's age...");
            double avgAge = list.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is: " + avgAge);
        }
    }
}
