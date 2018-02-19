using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegate
            //----OPcion para trabajar con asignacino de metodo
            //Func<int, int> f = Square;

            //---OPcion para trabajar lambda expressions
            Func<int, int> square = x => x * x;
            Console.WriteLine($"Delegate Example {square(4)}");

            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine($"Delegate Example with two parameters {add(5, 8)}");

            //ACtion 
            Action<int> write = x => Console.WriteLine(x);
            write(square(add(3, 5)));


            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee{ Id = 1, Name = "Ana"},
                new Employee{ Id = 2, Name = "Cris"},
                new Employee{ Id = 2, Name = "Luiss"},
                new Employee{ Id = 2, Name = "Leonardo"},
                new Employee{ Id = 2, Name = "Cindy"},

            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{ Id = 1, Name = "Alex"},
            };

            //LAMBDA EXPRESSIONS

            //---First Way
            foreach (var empl in developers.Where(NameStartsWithA))
            {
                Console.WriteLine(empl.Name);
            }

            //---Second Way
            foreach (var empl in developers.Where(delegate(Employee employee)
                {
                    return employee.Name.StartsWith("C");
                }))
            {
                Console.WriteLine(empl.Name);
            }

            //Third Way the best 
            Console.WriteLine("-------------------");
            foreach (var empl in developers.Where( e => e.Name.StartsWith("L")))
            {
                Console.WriteLine(empl.Name);
            }

            //Last example where we filter the employees with their names length are equals 5
            Console.WriteLine("-------------------");
            foreach (var empl in developers.Where(e => e.Name.Length == 5)
                .OrderBy(e => e.Name))
            {
                Console.WriteLine($"Names 5: {empl.Name}");
            }
        }

        private static int Square(int arg)
        {
            throw new NotImplementedException();
        }

        private static bool NameStartsWithA(Employee employee)
        {
            return employee.Name.StartsWith("A");
        }
    }

    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
