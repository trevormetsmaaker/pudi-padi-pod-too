using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pudi_padi.core.domain
{
   public class pudi_padi_pood
   {
        [Key]
        public int poe_ID {  get; set; }
         public string aadress { get; set; }
         public string tel_nr {  get; set; }
         public string tootaja { get; set; }
         public string tooted { get; set; }
         public string email { get; set; }


   }
}
