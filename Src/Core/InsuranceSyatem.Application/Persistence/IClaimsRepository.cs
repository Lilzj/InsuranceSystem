using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSystem.Application.Dtos.Request.Claims;
using InsuranceSystem.Application.Dtos.Response.Claims;
using InsuranceSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Persistence
{
    public interface IClaimsRepository
    {
        Task<IEnumerable<Claim>> GetClaimsByNationalId(string Id);
        Task<IEnumerable<Claim>> GetAllClaims();
        Task<Claim> GetClaimById(string id);
        void AddClaim(Claim claimRequest);
    }
}
