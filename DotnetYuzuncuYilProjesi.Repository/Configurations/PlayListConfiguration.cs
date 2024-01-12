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
    public class PlayListConfiguration : IEntityTypeConfiguration<PlayList>
    {
        public void Configure(EntityTypeBuilder<PlayList> builder)
        {
            //Fluent API ayarlamaları

            //Primary Key 
            builder.HasKey(x => x.Id);

            //Pimary Key Otomatik olarak artsın
            builder.Property(p => p.Id)
                .UseIdentityColumn();

            //PlayListName (uzunluk belirleme, zorunlu hale getirme)
            builder.Property(p => p.PlaylistName)
                .HasMaxLength(50)
                .IsRequired();


        }
    }
}
