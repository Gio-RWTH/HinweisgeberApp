using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinweisgeberApp.Models
{
    public class AddPartnerDTO
    {
        [StringLength(25)]
        public string Name { get; set; }
        public byte[] ConStr { get; set; }
        public bool Active { get; set; }
    }
}
