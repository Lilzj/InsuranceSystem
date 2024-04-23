using InsuranceSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Dtos.Response.Claims
{
    public class ClaimsResponseDto
    {
        public string Id { get; set; }
        public string NationalID { get; set; }
        public List<Expense> Expenses { get; set; }
        public string ClaimsStatus { get; set; }
        public decimal TotalAmountToClaim { get; set; }
    }
}
