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
    public class AdminRepository : GenericRepository<Claim>, IAdminRepository
    {
        public AdminRepository(InsuranceDbContext ctx) : base(ctx)
        {
                
        }
        public void UpdateClaim(Claim request) => Update(request);
    }
}
