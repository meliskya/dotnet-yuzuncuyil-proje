using DotnetYuzuncuYilProjesi.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Repository
{
    public class AppDbContext:DbContext
    {
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<MusicDetail> MusicDetails { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
