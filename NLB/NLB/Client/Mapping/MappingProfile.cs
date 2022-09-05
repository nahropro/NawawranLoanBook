using AutoMapper;
using NLB.Shared.Resources.CustomerResources;
using NLB.Shared.Resources.ReportResources;
using NLB.Shared.Resources.TransactionResources;

namespace NLB.Client.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UpdateCustomerResource, SelectCustomerResource>();
        CreateMap<UpdateTransactionResource, SelectTransactionResource>();

        CreateMap<SelectCustomerResource, UpdateCustomerResource>();
        CreateMap<SelectTransactionResource, UpdateTransactionResource>();

        CreateMap<SelectCustomerResource, SelectCustomerResource>();
        CreateMap<SelectTransactionResource, SelectTransactionResource>();


        CreateMap<CustomerSummaryDetail, UpdateTransactionResource>();
    }
}
