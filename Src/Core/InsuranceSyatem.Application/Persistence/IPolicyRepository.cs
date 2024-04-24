using InsuranceSystem.Domain;

namespace InsuranceSystem.Application.Persistence
{
    public interface IPolicyRepository
    {
        Task<IEnumerable<Policy>> GetPolicies();
        Task<IEnumerable<Policy>> GetPoliciesByNationalID(string nationalId);
        Task<Policy> GetPolicyById(string id);
        void AddPolicy(Policy policyRequest);
    }
}
