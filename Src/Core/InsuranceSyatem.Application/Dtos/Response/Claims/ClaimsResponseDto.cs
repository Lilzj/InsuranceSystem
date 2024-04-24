using InsuranceSyatem.Application.Dtos.Request.Clams;

namespace InsuranceSystem.Application.Dtos.Response.Claims
{
    public class ClaimsResponseDto
    {
        public string Id { get; set; }
        public string NationalID { get; set; }
        public List<ExpenseDto> Expenses { get; set; }
        public string ClaimsStatus { get; set; }
        public decimal TotalAmountToClaim { get; set; }
    }
}
