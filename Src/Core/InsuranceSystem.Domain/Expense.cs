using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Domain
{
    public class Expense
    {
        public ExpenseType ExpenseType { get; set; } 
        public string Description { get; set; }
        public decimal Amount { get; set;}
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
