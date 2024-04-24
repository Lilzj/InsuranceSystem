using InsuranceSystem.Domain;

namespace InsuranceSystem.Application.Persistence
{
    public interface IClaimsRepository
    {
        Task<IEnumerable<Claim>> GetClaimsByNationalId(string Id);
        Task<IEnumerable<Claim>> GetAllClaims();
        Task<Claim> GetClaimById(string id);
        void AddClaim(Claim claimRequest);
    }
}
