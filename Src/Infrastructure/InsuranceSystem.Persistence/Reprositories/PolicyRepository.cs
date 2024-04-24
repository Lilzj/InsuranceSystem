using InsuranceSystem.Application.Dtos.Request.Policy;
using InsuranceSystem.Application.Dtos.Response.Policy;
using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Domain;
using InsuranceSystem.Persistence.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Persistence.Reprositories
{
    public class PolicyRepository : GenericRepository<Policy>, IPolicyRepository
    {
        public PolicyRepository(InsuranceDbContext ctx) : base(ctx)
        {

        }

        public void AddPolicy(Policy policyRequest) => Insert(policyRequest);


        public async Task<IEnumerable<Policy>> GetPolicies()
        {
            return await GetAllAsync();
        }

        public async Task<IEnumerable<Policy>> GetPoliciesByNationalID(string nationalId)
        {
           return await GetWhere(_ => _.NationalID == nationalId);
        }

        public Task<Policy> GetPolicyById(string id)
        {
            return GetSingleAsync(_ => _.PolicyNumber == id || _.Id == id);  
        }
    }
}
