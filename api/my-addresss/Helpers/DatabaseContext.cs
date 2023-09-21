using System.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using my_addresss.Business.Services.Interfaces;
using my_addresss.Domain.Models;
using Npgsql;

namespace my_addresss.Helpers
{
	public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("POSTGRES"));
        }*/

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}

