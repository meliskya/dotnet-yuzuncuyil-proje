using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Core
{
    public class Song:BaseEntity
    {
        public string SongName { get; set; }
        public string Singer { get; set; }
        public string Duration { get; set; }


        //Foreign Key
        public int PlayListId { get; set; }
        public PlayList PlayList { get; set; }
    }
}
