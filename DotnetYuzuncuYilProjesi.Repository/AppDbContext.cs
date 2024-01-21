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
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<MusicDetail> MusicDetails { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReferance)
                {
                    switch (item.State)
                    {
                        case EntityState.Modified:
                            {
                                entityReferance.UpdatedDate = DateTime.Now;
                                break;
                            }

                        case EntityState.Added:
                            {
                                entityReferance.CreatedDate = DateTime.Now;
                                //entityReferance.UpdatedDate= null;
                                break;
                            }
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReferance)
                {
                    switch (item.State)
                    {
                        case EntityState.Modified:
                            {
                                entityReferance.UpdatedDate = DateTime.Now;
                                break;
                            }

                        case EntityState.Added:
                            {
                                entityReferance.CreatedDate = DateTime.Now;
                                entityReferance.UpdatedDate = null;
                                break;
                            }

                        case EntityState.Deleted:
                            {
                                entityReferance.UpdatedDate = DateTime.Now;
                                break;
                            }

                    }
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
