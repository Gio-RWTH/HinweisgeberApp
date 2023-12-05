using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinweisgeberApp.Data
{
    public class Filiale
    {
        public int Id { get; set; }
        public int FilialNr { get; set; }
        public string AnsichtName { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(Partner))]
        public int PartnerId { get; set; }
        public virtual Partner Partner { get; set; }
    }
}
