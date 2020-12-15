using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Entities
{
    public class Expense
    {
        public Month Month { get; set; }
        public Expensetype Expensetype { get; set; }
        public int Value { get; set; }
        public string MonthString
        {
            get
            {
                return Month.ToString();
            }
        }
        public string ExpenseTypeString
        {
            get
            {
                return Expensetype.ToString();
            }
        }
    }
}
