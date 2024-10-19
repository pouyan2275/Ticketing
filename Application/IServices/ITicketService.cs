using Application.Bases.Interfaces.IServices;
using Application.Dtos.Tickets;
using Domain.Entities;

namespace Application.IServices
{
    public interface ITicketService : IBaseService<Ticket>
    {
    }
}
