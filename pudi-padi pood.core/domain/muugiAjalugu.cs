using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pudi_padi.core.domain
{
   public class muugi_ajalugu
   {
        [Key]
        public int muugi_ID {  get; set; }
        public int tootaja_ID { get; set; }
        public DateTime kuupaev { get; set; }
        public string toode {  get; set; }    
   }
}
