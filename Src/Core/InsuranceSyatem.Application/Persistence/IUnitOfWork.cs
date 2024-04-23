using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Persistence
{
    public interface IUnitOfWork
    {
        IAdminRepository Admin { get; }
        IClaimsRepository Claims { get; }
        IPolicyRepository Policy { get; }
    }
}
