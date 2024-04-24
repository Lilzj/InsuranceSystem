using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Dtos.Request.Policy
{
    public class UpdateClaimsRequestDto
    {
        public string Id { get; set; }
        public string ClaimsStatus { get; set; }
    }
}
