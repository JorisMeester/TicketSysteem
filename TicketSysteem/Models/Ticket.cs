using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSysteem.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public ApplicationUser Klant { get; set; }
        public string Applicatie { get; set; }
        public string Onderwerp { get; set; }
        public string Omschrijving { get; set; }
        public DateTime Datum { get; set; }
        public StatusEnum Status { get; set; }
    }

    public enum StatusEnum
    {
        Nieuw,
        InBehandeling,
        Afgehandeld
    }
}