using Application.Bases.Implements.Services;
using Application.Dtos.Tickets;
using Application.IServices;
using Domain.Entities;
using Domain.Interfaces.Repositories;
namespace Application.Services;

public class TicketService : BaseService<Ticket>, ITicketService
{
    private readonly ITicketRepository _repository;

    public TicketService(ITicketRepository repository) : base(repository)
    {
        _repository = repository;
    }


}
