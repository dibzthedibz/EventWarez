﻿using EventWarez.Models.Ticket;
using EventWarez.Services;
using System.Web.Http;

namespace EventWarez.WebAPI.Controllers
{
    /// <summary>
    /// Uncommented this whole page
    /// </summary>
    //This Class Probably does not need to exist either.
    //public class TicketController : ApiController
    //{
    //    private TicketService _ticketService = new TicketService();
    //    public IHttpActionResult PostTicket(TicketCreate model, int showId)
    //    {
    //        if (!ModelState.IsValid)
    //            return BadRequest(ModelState);

    //        if (!_ticketService.CreateTicket(model, showId))
    //            return InternalServerError();

    //        return Ok("Ticket(s) properly added.");
    //    }

    //    public IHttpActionResult GetAllTickets()
    //    {
    //        var tickets = _ticketService.GetTickets();
    //        return Ok(tickets);
    //    }
    //}
}