using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicketSysteem.Models
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public IEnumerable<string> RoleNames { get; set; }
    }
}