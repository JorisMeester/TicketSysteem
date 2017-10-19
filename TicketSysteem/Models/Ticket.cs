using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSysteem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public ApplicationUser Customer { get; set; }
        public string Application { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TicketReply Replies { get; set; }
        public StatusEnum Status { get; set; }

        public Ticket()
        {
            Date = DateTime.Now;
            Status = StatusEnum.New;
        }
    }

    public enum StatusEnum
    {
        New,
        Processing,
        Resolved
    }
}