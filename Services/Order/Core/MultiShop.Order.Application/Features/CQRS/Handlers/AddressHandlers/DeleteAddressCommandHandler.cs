using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class DeleteAddressCommandHandler
{
    private readonly IRepository<Address> _repository;
    
    public DeleteAddressCommandHandler(IRepository<Address> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteAddressCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.DeleteAsync(value);
    }
}