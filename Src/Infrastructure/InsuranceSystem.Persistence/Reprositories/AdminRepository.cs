using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Domain;
using InsuranceSystem.Persistence.DBContext;

namespace InsuranceSystem.Persistence.Reprositories
{
    public class AdminRepository : GenericRepository<Claim>, IAdminRepository
    {
        public AdminRepository(InsuranceDbContext ctx) : base(ctx)
        {
                
        }
        public void UpdateClaim(Claim request) => Update(request);
    }
}
