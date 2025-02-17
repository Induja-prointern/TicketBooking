using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Repositories.Entities
{
   public  class Booking
    {
        [Key]
        [Required]
        public Guid bookingid { get; set; }
        public int  bookingdate {   get ; set;}
        public int tickets { get; set; }

    }
}
