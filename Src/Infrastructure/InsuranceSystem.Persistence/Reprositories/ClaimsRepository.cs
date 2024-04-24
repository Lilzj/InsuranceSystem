using InsuranceSyatem.Application.Dtos.Request.Clams;
using InsuranceSystem.Application.Dtos.Response.Claims;
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
    public class ClaimsRepository : GenericRepository<Claim>, IClaimsRepository
    {
        public ClaimsRepository(InsuranceDbContext ctx) : base(ctx)
        {

        }
        public void AddClaim(Claim claimRequest) => Insert(claimRequest);

        public async Task<IEnumerable<Claim>> GetAllClaims()
        {
            return await GetAllAsync();
        }

        public async Task<Claim> GetClaimById(string id)
        {
            return await IncludeAsync(_ => _.Id == id, "Expense");
        }

        public async Task<IEnumerable<Claim>> GetClaimsByNationalId(string Id)
        {
            return await AllIncludeAsync(_ => _.NationalID == Id, "Expense");
        }
    }
}
