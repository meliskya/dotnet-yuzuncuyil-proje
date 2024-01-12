using DotnetYuzuncuYilProjesi.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Repository.Configurations
{
    public class MusicDetailConfiguration : IEntityTypeConfiguration<MusicDetail>
    {
        public void Configure(EntityTypeBuilder<MusicDetail> builder)
        {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id)
                    .UseIdentityColumn();

                builder.Property(x => x.Lyrics).HasMaxLength(2000);

                builder.Property(x => x.ReleaseYear)
                    .HasColumnType("int")
                    .HasMaxLength(4);

                builder.Property(x => x.NumberOfLikes)
                     .HasColumnType("int");
               
        }
    }
}
