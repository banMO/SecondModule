using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Project2.ClassesO
{
    public class ExpenseBook
    {
        private List<int> expenses;
        public ExpenseBook()
        {
            expenses  = new List<int>();
        }
        public void AddExpense(int expense)
        {
            expenses.Add(expense);
        }

        //
        

    }
}
