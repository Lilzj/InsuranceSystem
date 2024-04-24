using InsuranceSystem.Domain;

namespace InsuranceSystem.Application.Persistence
{
    public interface IAdminRepository
    {
        void UpdateClaim(Claim request);
    }
}
