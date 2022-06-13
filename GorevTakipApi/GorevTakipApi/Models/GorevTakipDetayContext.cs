using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GorevTakipApi.Models
{
    public class GorevTakipDetayContext:DbContext
    {
        public GorevTakipDetayContext(DbContextOptions<GorevTakipDetayContext> options):base(options)
        {

        }
           
        public DbSet<GorevTakipDetay> GorevTakipDetays { get; set; }



    }
}
