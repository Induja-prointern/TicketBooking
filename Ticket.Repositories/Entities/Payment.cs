using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Repositories.Entities
{
   public   class Payment
    {
        [Key]
        [Required]
        public int paymnetid { get; set; }
        public decimal amount { get; set; }

    }
}
