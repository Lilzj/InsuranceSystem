using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Dtos.Response.Policy
{
    public class PolicyResponseDto
    {
        public int Id { get; set; }
        public string NationalID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DOB { get; set; }

        public string PolicyNumber { get; set; }
    }
}
