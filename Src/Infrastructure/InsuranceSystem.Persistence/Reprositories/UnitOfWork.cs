using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Persistence.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Persistence.Reprositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private IAdminRepository _admins;

        private IClaimsRepository _claims;

        private IPolicyRepository _policies;


        public UnitOfWork()
        {
        }

        public IAdminRepository Admin => _admins ??= new AdminRepository();

        public IClaimsRepository Claims => _claims ??= new ClaimsRepository();

        public IPolicyRepository Policy => _policies ??= new PolicyRepository();
    }
}
