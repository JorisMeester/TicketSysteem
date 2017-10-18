using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSysteem.Models
{
    public class TicketReply
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Reply { get; set; }
        public int Ticket { get; set; }
        public ApplicationUser User { get; set; }
    }
}