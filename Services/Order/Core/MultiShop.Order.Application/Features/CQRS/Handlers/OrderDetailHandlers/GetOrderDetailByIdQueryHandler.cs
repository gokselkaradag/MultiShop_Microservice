using MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class GetOrderDetailByIdQueryHandler
{
    private readonly IRepository<OrderDetail> _repository;

    public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
    {
        _repository = repository;
    }

    public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetOrderDetailByIdQueryResult
        {
            OderDetailId =  values.OderDetailId,
            ProductAmount =  values.ProductAmount,
            ProductName = values.ProductName,
            ProductId = values.ProductId,
            ProductPrice = values.ProductPrice,
            OrderingId =  values.OrderingId,
            ProductTotalPrice =  values.ProductTotalPrice
        };
    }
}