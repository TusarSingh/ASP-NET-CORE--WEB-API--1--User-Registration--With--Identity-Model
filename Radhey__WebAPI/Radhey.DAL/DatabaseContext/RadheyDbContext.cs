using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Radhey.DAL.IdentityTables;
using Microsoft.EntityFrameworkCore;      //   : IdentityDbContext < TblApplicationUser >

namespace Radhey.DAL.DatabaseContext
{
    public class RadheyDbContext : IdentityDbContext<TblApplicationUser>
    {
        
        public RadheyDbContext(DbContextOptions<RadheyDbContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        public DbSet<TblApplicationUser> AspNetUser {  get; set; }


    }
}
