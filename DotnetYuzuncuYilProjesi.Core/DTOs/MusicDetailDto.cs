using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Core.DTOs
{
    public class MusicDetailDto:BaseDto
    {
        //public int Id { get; set; }
        public string Lyrics { get; set; }
        public int ReleaseYear { get; set; }
        public int NumberOfLikes { get; set; }
    }
}
