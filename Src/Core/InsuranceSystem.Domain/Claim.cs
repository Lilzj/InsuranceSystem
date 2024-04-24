using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceSystem.Domain.Enum;

namespace InsuranceSystem.Domain
{
    public class Claim : BaseEntity
    {

        public Claim()
        {
            Expenses = [];
        }
        public string NationalID { get; set; }
        public List<Expense> Expenses { get; set; }
        public ClaimStatus ClaimsStatus { get; set; } = ClaimStatus.Submitted;

    }
}
