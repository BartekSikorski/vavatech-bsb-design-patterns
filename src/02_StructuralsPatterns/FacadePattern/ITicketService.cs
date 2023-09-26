using FacadePattern.Models;
using FacadePattern.Repositories;
using FacadePattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    //public class TicketParameters
    //{
    //    public Route Route { get;  }
    //    public DateTime When { get;  }
    //    public byte NumberOfPlaces { get; }

    //    public TicketParameters(Route route, DateTime when, byte numberOfPlaces) : this()
    //    {
    //        this.Route = route;
    //        this.When = when;
    //        this.NumberOfPlaces = numberOfPlaces;           
    //    }
    //}

    public record TicketParameters(Route Route, DateTime When, byte NumberOfPlaces);

    public class Route
    {
        public string From { get; set; }
        public string To { get; set; }

        public Route(string from, string to)
        {
            From = from;
            To = to;
        }

        public bool Validate()
        {
            return From != To;
        }
    }

    // Abstract Fasade
    public interface ITicketService
    {
        Ticket Buy(TicketParameters parameters);
        void Cancel(Ticket ticket);
    }

    // Concrete Fasade
    public class RailwayTicketService : ITicketService
    {
        private readonly IRailwayConnectionRepository railwayConnectionRepository;
        private readonly TicketCalculator ticketCalculator;
        private readonly ReservationService reservationService;
        private readonly IPaymentService paymentService;
        private readonly ITicketSenderService ticketSenderService;

        public RailwayTicketService(IRailwayConnectionRepository railwayConnectionRepository, TicketCalculator ticketCalculator, ReservationService reservationService, IPaymentService paymentService, ITicketSenderService ticketSenderService)
        {
            this.railwayConnectionRepository = railwayConnectionRepository;
            this.ticketCalculator = ticketCalculator;
            this.reservationService = reservationService;
            this.paymentService = paymentService;
            this.ticketSenderService = ticketSenderService;
        }

        public Ticket Buy(TicketParameters parameters)
        {
            RailwayConnection railwayConnection = railwayConnectionRepository.Find(parameters.Route.From, parameters.Route.To, parameters.When);
            decimal price = ticketCalculator.Calculate(railwayConnection, parameters.NumberOfPlaces);
            Reservation reservation = reservationService.MakeReservation(railwayConnection, parameters.NumberOfPlaces);
            Ticket ticket = new Ticket { RailwayConnection = reservation.RailwayConnection, NumberOfPlaces = reservation.NumberOfPlaces, Price = price };
            Payment payment = paymentService.CreateActivePayment(ticket);

            if (payment.IsPaid)
            {
                ticketSenderService.Send(ticket);
            }

            return ticket;
        }

        public void Cancel(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
