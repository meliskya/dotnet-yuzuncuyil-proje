using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Core
{
    public class MusicDetail
    {
        public string Id { get; set; }
        public string Lyrics { get; set; }
        public int ReleaseYear { get; set; }
        public int NumberOfLikes { get; set; }

        //Foreign Key
        public int SongId { get; set; }

        //Birebir İlişki
        public Song Song { get; set; }
        public PlayList PlayList { get; set; }
    }
}
