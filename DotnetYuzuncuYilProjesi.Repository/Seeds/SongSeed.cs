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
    public class SongSeed : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasData(
                new Song { Id = 1, SongName = "La Follia", Singer = "Vivaldi", Duration = "9.30 dakika", PlayListId = 1, CreatedDate = DateTime.Now },
                new Song { Id = 2, SongName = "Everybody Loves Somebody", Singer = "Dean Martin", Duration = "2.47 dakika", PlayListId = 2, CreatedDate = DateTime.Now },
                new Song { Id = 3, SongName = "Surrender", Singer = "Cheap Trick", Duration = "4.15 dakika", PlayListId = 3, CreatedDate = DateTime.Now },
                new Song { Id = 4, SongName = "I'd Rather Go Blind", Singer = "Etta James", Duration = "2.35 dakika", PlayListId = 4, CreatedDate = DateTime.Now }
                );
        }
    }
}



