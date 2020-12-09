using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Olx_Proj.Models;
using Olx_Proj.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olx_Proj.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Tovar> Tovars { get; set; }
        public DbSet<Tovar_Image> Tovar_Images { get; set; }

    }
}
