using AutoMapper;
using DotnetYuzuncuYilProjesi.Core;
using DotnetYuzuncuYilProjesi.Core.DTOs;
using DotnetYuzuncuYilProjesi.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYilProjesi.API.Controllers
{
    public class SongController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ISongService _songService;
        public SongController(IMapper mapper, ISongService songService)
        {
            _mapper = mapper;
            _songService = songService;
        }

        [HttpGet]

        public async Task<IActionResult> All()
        {
            var song = await _songService.GetAllAsync();
            var songDto = _mapper.Map<List<SongDto>>(song.ToList());
            return CreateActionResult(GlobalResultDto<List<SongDto>>.Success(200, songDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            //throw new InvalidOperationException("Test");
            var song = await _songService.GetById(id);
            var songDto = _mapper.Map<SongDto>(song);
            return CreateActionResult(GlobalResultDto<SongDto>.Success(200, songDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(SongDto songDto)
        {
            var song = await _songService.AddAsync(_mapper.Map<Song>(songDto));
            var songDtos = _mapper.Map<SongDto>(song);
            return CreateActionResult(GlobalResultDto<SongDto>.Success(201, songDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(SongDto songDto)
        {
            await _songService.UpdateAsync(_mapper.Map<Song>(songDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var song = await _songService.GetById(id);
            await _songService.RemoveAsync(song);
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}
