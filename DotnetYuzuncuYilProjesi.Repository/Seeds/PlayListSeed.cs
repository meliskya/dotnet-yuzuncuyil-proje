using DotnetYuzuncuYilProjesi.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Repository.Seeds
{
    public class PlayListSeed : IEntityTypeConfiguration<PlayList>
    {
        public void Configure(EntityTypeBuilder<PlayList> builder)
        {
            builder.HasData(
                new PlayList { Id = 1, PlaylistName = "Classical", CreatedDate = DateTime.Now },
                new PlayList { Id = 2, PlaylistName = "Jazz", CreatedDate = DateTime.Now },
                new PlayList { Id = 3, PlaylistName = "Rock", CreatedDate = DateTime.Now },
                new PlayList { Id = 4, PlaylistName = "Blues", CreatedDate = DateTime.Now }
            );
        }
    }
}
