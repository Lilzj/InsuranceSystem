using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Domain
{
    public class PolicyHolder : BaseEntity
    {
        public string NationalID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DOB { get; set; }

        public string PolicyNumber { get; set; }
    }
}
