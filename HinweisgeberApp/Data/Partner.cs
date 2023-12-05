using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinweisgeberApp.Data
{
    public class Partner
    {
        public Partner()
        {
            Filiale = new HashSet<Filiale>();
        }

        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        public byte[] ConStr { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Filiale> Filiale { get; set; }
    }
}
