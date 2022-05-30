using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TicketBookingSystem
{
    internal class mainclass
    {
        static void Main(string[] args)
        {
            BookingId bookingId = new BookingId();
            CreateId booking = new CreateId();
            Movies movies = new Movies();
            Program program = new Program();
            program.loginAs();
        }
    }
}
