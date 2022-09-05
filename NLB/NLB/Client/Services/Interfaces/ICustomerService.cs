using NLB.Shared.Resources.CustomerResources;

namespace NLB.Client.Services
{
    public interface ICustomerService
    {
        Task<List<SelectCustomerResource>> GetCustomersAsync(string s);
        Task<SelectCustomerResource> AddCustomerAsync(UpdateCustomerResource customer);
        Task<SelectCustomerResource> UpdateCustomerAsync(int customerId, UpdateCustomerResource customer);
        Task<bool> RemoveCustomerAsync(int customerId);
        Task<SelectCustomerResource> GetCustomerAsync(int customerId);
    }
}