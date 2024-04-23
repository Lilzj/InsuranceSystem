using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSyatem.Application.Dtos.Request.Clams
{
    public class ExpenseDto
    {
        public string ExpenseType { get; set; }
        public string ExpenseDescription { get; set; }
        public decimal Amount { get; set; }
    }
}
