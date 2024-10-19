using Application.Dtos.Tickets;
using Application.IServices;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.DynamicLinq;
using Personal.Server.Bases.Controllers;

namespace Personal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : BaseController<Ticket>
    {
        private readonly ITicketService _service;
        private readonly ITicketRepository _repository;

        public TicketController(ITicketService ticketService, ITicketRepository repository) : base(ticketService)
        {
            _service = ticketService;
            _repository = repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> SubmitTicket(TicketDto ticketDto)
        {
            var ticket = new Ticket()
            {
                Id = Guid.NewGuid()
            };

            if (ticketDto.Id != null)
                ticket = _repository.TableNoTracking.FirstOrDefault(x => x.Id == ticketDto.Id)
                         ?? throw new Exception("تیکت مورد نظر یافت شد");
      

            ticketDto.Adapt(ticket);

            var note = new Note()
            {
                Id = Guid.NewGuid(),
                Title = ticketDto.NoteTitle,
                Description = ticketDto.NoteDescription,
                TicketId = ticket.Id,
            };

            ticket.Note.Add(note);

            await _repository.AddAsync(ticket);

            return Ok();
        }
    }
}
