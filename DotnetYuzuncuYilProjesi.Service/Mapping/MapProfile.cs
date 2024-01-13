using AutoMapper;
using DotnetYuzuncuYilProjesi.Core;
using DotnetYuzuncuYilProjesi.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<PlayList, PlayListDto>().ReverseMap();
            CreateMap<Song, SongDto>().ReverseMap();
            CreateMap<MusicDetail, MusicDetailDto>().ReverseMap();

            CreateMap<PlayListDto, PlayList>();
        }
    }
}
