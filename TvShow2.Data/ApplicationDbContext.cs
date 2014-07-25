using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvShow2.Data.Models;

namespace TvShow2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> 
    {
        public DbSet<TvShow> TvShows { get; set; }
		public ApplicationDbContext() 
            : base("DefaultConnection") 
        {
        }
    }
    }

