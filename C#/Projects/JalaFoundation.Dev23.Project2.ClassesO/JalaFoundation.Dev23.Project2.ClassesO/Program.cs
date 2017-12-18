using JalaFoundation.Dev23.Project2.ClassesO.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Project2.ClassesO
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpenseBook book = new ExpenseBook();
            book.AddExpense(15);
            book.AddExpense(10);
            NonStatic  classe = new NonStatic(15);
            Console.WriteLine(NonStatic.GetProperty());

            NonStatic class2 = new NonStatic(25);
            Console.WriteLine(NonStatic.GetProperty());
            

        }
    }
}
