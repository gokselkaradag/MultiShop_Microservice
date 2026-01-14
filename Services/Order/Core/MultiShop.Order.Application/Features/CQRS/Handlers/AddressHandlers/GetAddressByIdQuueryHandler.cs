using MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class GetAddressByIdQuueryHandler
{
    private readonly IRepository<Address> _repository;

    public GetAddressByIdQuueryHandler(IRepository<Address> repository)
    {
        _repository = repository;
    }

    public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetAddressByIdQueryResult
        {
            City =  values.City,
            UserId =  values.UserId,
            AddressId =  values.AddressId,
            Detail =  values.Detail,
            District =   values.District
        };
    }
}