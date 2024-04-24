using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Application.Dtos.Response.Policy;
using InsuranceSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Persistence
{
    public interface IPolicyRepository
    {
        Task<IEnumerable<Policy>> GetPolicies();
        Task<IEnumerable<Policy>> GetPoliciesByNationalID(string nationalId);
        Task<Policy> GetPolicyById(string id);
        void AddPolicy(Policy policyRequest);
    }
}
