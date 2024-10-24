using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pudi_padi.core.domain
{
    public class toode
    {
        [Key]
        public int toote_ID {  get; set; }
        public string toote_info { get; set; }
        public  int kuupaev {  get; set; }
        public int kogus {  get; set; }
        public string ostuajalugu { get; set; }
        public int hind {  get; set; }
    }
}
