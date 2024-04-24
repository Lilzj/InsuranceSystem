namespace InsuranceSyatem.Application.Dtos.Request.Clams
{
    public class CreateClaimsRequestDto
    {
        public string NationalId { get; set; }
        public List<ExpenseDto> Expenses { get; set; }
    }
}
