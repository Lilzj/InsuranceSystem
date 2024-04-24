namespace InsuranceSystem.Domain
{
    public class Policy : BaseEntity
    {
        public string NationalID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DOB { get; set; }

        public string PolicyNumber { get; set; }


        public Policy()
        {
            Random rdm = new Random();
            PolicyNumber = "POL" + rdm.Next(0000, 9999).ToString();
        }
    }
}
