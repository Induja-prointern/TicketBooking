using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Repositories.Entities
{
     public class User
    {
        [Key]
        [Required]
        public Guid uid { get; set; }
        public string uname { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public int  age { get; set; }
        public string email { get; set; }

    }
}
