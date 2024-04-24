namespace InsuranceSystem.Application.Persistence
{
    public interface IUnitOfWork
    {
        IAdminRepository Admin { get; }
        IClaimsRepository Claims { get; }
        IPolicyRepository Policy { get; }

        Task SaveAsync();
    }
}
