using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Domain;
using InsuranceSystem.Persistence.DBContext;

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
            return await IncludeAsync(_ => _.Id == id || _.NationalID == id, "Expense");
        }

        public async Task<IEnumerable<Claim>> GetClaimsByNationalId(string Id)
        {
            return await AllIncludeAsync(_ => _.NationalID == Id, "Expense");
        }
    }
}
