using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Core
{
    public class PlayList:BaseEntity
    {
        public string PlaylistName { get; set; }

        //bire çok ilişki
        public ICollection<Song> Song { get; set; }
    }
}
