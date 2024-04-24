using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Persistence.DBContext;

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

        public IAdminRepository Admin => _admins ??= new AdminRepository(_ctx);

        public IClaimsRepository Claims => _claims ??= new ClaimsRepository(_ctx);

        public IPolicyRepository Policy => _policies ??= new PolicyRepository(_ctx);


        public async Task SaveAsync() => await _ctx.SaveChangesAsync();
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
