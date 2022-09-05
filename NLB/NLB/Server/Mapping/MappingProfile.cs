using AutoMapper;
using NLB.Server.Models.Database;
using NLB.Shared.Resources.CustomerResources;
using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.ReportResources;
using NLB.Shared.Resources.TransactionResources;
using NLB.Shared.Resources.UserResources;

namespace NLB.Server.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UpdateCustomerResource, Customer>();
        CreateMap<UpdateTransactionResource, Transaction>();
        CreateMap<CreateUserResource, User>();

        CreateMap<Customer, SelectCustomerResource>()
            .ForMember(x=> x.Balance,
            x=> x.MapFrom(i=> i.Transactions.Where(s=> !s.MoneyInOrOut).Sum(s=> s.Amount + s.DiscountAmount)
                - i.Transactions.Where(s => s.MoneyInOrOut).Sum(s => s.Amount + s.DiscountAmount)));
        CreateMap<Transaction, SelectTransactionResource>();
        CreateMap<Transaction, CustomerSummaryDetail>();
        CreateMap<User, SelectUserResource>();
    }
}
