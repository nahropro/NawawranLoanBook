using NLB.Shared.Resources.CustomerResources;

namespace NLB.Client.Services;

public class CustomerService : ICustomerService
{
    private readonly IHttpService httpService;

    public CustomerService(IHttpService httpService)
    {
        this.httpService = httpService;
    }

    public async Task<List<SelectCustomerResource>> GetCustomersAsync(string s)
    {
        return await httpService.
            GetAsync<List<SelectCustomerResource>>("api/customers", new {s=s});
    }

    public async Task<SelectCustomerResource> GetCustomerAsync(int customerId)
    {
        return await httpService.
            GetAsync<SelectCustomerResource>($"api/customers/{customerId}");
    }

    public async Task<SelectCustomerResource> AddCustomerAsync(UpdateCustomerResource customer)
    {
        return await httpService.PostAsync<SelectCustomerResource,UpdateCustomerResource>("api/customers",customer);
    }

    public async Task<SelectCustomerResource> UpdateCustomerAsync(int customerId,UpdateCustomerResource customer)
    {
        return await httpService.PutAsync<SelectCustomerResource,UpdateCustomerResource>
            ($"api/customers/{customerId}", customer);
    }

    public async Task<bool> RemoveCustomerAsync(int customerId)
    {
        return await httpService.DeleteAsync($"api/customers/{customerId}");
    }
}
