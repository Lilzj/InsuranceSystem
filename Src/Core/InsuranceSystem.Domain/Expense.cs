using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using InsuranceSystem.Domain.Enum;

namespace InsuranceSystem.Domain
{
    public class Expense : BaseEntity
    {
        public ExpenseType ExpenseType { get; set; } 
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set;}
    }
}
