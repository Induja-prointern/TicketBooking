using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ticket.Repositories.Entities
{
   public  class Booking
    {
        [Key]
        [Required]
        public Guid bookingid { get; set; }
        public int  bookingdate {   get ; set;}
        public int tickets { get; set; }
        [ForeignKey("User")]
        public Guid uid { get; set; }  // This is the foreign key column

        // Navigation property

        public User User { get; set; }

    }
}
