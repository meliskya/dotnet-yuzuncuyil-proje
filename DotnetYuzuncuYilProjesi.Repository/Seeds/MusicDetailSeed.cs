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
    public class MusicDetailSeed : IEntityTypeConfiguration<MusicDetail>
    {
        public void Configure(EntityTypeBuilder<MusicDetail> builder)
        {
            builder.HasData(
                new MusicDetail { Id = 1, Lyrics = "klasikmüziksöz", ReleaseYear = 1996, NumberOfLikes = 5464654, SongId = 1},
                new MusicDetail { Id = 2, Lyrics = "cazmüziksöz", ReleaseYear = 1896, NumberOfLikes = 46565, SongId = 2 },
                new MusicDetail { Id = 3, Lyrics = "rockmüziksöz", ReleaseYear = 1976, NumberOfLikes = 98798, SongId = 3 },
                new MusicDetail { Id = 4, Lyrics = "bluesmüziksöz", ReleaseYear = 1953, NumberOfLikes = 1531, SongId = 4 }
                );
        }
    }
}



