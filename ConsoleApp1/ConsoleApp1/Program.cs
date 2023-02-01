using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please enter line: ");
                var lines = int.Parse(Console.ReadLine());
            // tạo 1 list person
                var persons = new List<Person>();
                for(int i =0; i<lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                    persons.Add(person);
                }
                persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}