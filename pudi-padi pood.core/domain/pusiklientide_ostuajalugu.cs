using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pudi_padi.core.domain
{
   public class pusiklientide_ostuajalugu
   {
        [Key]
        public int toode{ get; set; }
        public DateTime kuupaev {  get; set; }
        public int toote_ID { get; set; }
        public string toote_info { get; set; }
        public int hind {  get; set; }
        public int toote_kogus { get; set; }


   }
}
