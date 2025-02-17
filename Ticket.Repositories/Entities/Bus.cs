using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Repositories.Entities
{
    public class Bus
    {
        [Key]
        [Required]
        public Guid busid { get; set; }
        public string bname { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public string busdrivername { get; set; }


    }
}
