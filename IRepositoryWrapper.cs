namespace LadysmithProperties.Data
{
    public interface IRepositoryWrapper
    {
        void Save();
        ITenantRepository Tenant { get; }
    }
}
