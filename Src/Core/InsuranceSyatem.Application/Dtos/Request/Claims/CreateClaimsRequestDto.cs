using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSyatem.Application.Dtos.Request.Clams
{
    public class CreateClaimsRequestDto
    {
        public string NationalId { get; set; }
        public List<ExpenseDto> Expenses { get; set; }
    }
}
