namespace InsuranceSystem.Application.Dtos.Request.Policy
{
    public class CreatePolicyRequestDto
    {
        public string NationalID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DOB { get; set; }

        public string PolicyNumber { get; set; }
    }
}
