using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pudi_padi_pood.core
{
    public class DatabaseTaskDbContext : DbContext
    {
        
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
           : base(options) { }

        public DbSet<pudi_padi.core.domain.muugi_ajalugu> muugi_Ajalugus { get; set; }
        public DbSet<pudi_padi.core.domain.pudi_padi_pood> pudi_padi_poods { get; set; }
        public  DbSet<pudi_padi.core.domain.pusikliendid> pussikliendid { get; set; }
        public DbSet<pudi_padi.core.domain.pusiklientide_ostuajalugu> pusiklientide_Ostuajalugus{ get; set; }
        public DbSet<pudi_padi.core.domain.toode> toodes { get; set; }
        public DbSet<pudi_padi.core.domain.tootaja> tootajas { get; set; }



    }
    
        

       
    
}