using FacadePattern.Models;

namespace FacadePattern.Services
{
    public interface ITicketSenderService
    {
        void Send(Ticket ticket);
    }

    public class EmailTicketSenderService : ITicketSenderService
    {
        public void Send(Ticket ticket)
        {
            System.Console.WriteLine($"Send {ticket}");
        }
    }



}
