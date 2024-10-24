using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pudi_padi.core.domain
{
    public class tootaja
    {
        [Key]
        public int totaja_ID { get; set; }
        public string eesnimi  { get; set; }
        public string perenimi { get; set; }
        public int tel_nr { get; set; }
        public string email { get; set; } 
        public string aadress { get; set; }
    }
}
