using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Persistence.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Persistence.Reprositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InsuranceDbContext _ctx;

        private IAdminRepository _admins;

        private IClaimsRepository _claims;

        private IPolicyRepository _policies;


        public UnitOfWork(InsuranceDbContext ctx)
        {
            _ctx = ctx;
        }

        public IAdminRepository Admin => _admins ??= new AdminRepository();

        public IClaimsRepository Claims => _claims ??= new ClaimsRepository();

        public IPolicyRepository Policy => _policies ??= new PolicyRepository();


        public async Task Save() => await _ctx.SaveChangesAsync();
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
