using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Repositories.Entities
{
   public  class TravelTicket
    {
        [Key]
        [Required]
        public int ticketid { get; set; }
        public string seatnumber { get; set; }

    }
}
