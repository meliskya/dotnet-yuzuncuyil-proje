using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Core.DTOs
{
    public class SongDto:BaseDto
    {
        public string SongName { get; set; }
        public string Singer { get; set; }
        public string Duration { get; set; }
        public int PlayListId { get; set; }
    }
}
