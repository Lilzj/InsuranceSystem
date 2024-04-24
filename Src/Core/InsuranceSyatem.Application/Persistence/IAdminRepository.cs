using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Persistence
{
    public interface IAdminRepository
    {
        void UpdateClaim(Claim request);
    }
}
