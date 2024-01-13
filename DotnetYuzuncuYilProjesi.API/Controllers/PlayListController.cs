using AutoMapper;
using DotnetYuzuncuYilProjesi.Core;
using DotnetYuzuncuYilProjesi.Core.DTOs;
using DotnetYuzuncuYilProjesi.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYilProjesi.API.Controllers
{  
  
    public class PlayListController :CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IPlayListService _playListService;
        public PlayListController(IMapper mapper, IPlayListService playListService)
        {
            _mapper = mapper;
            _playListService = playListService;
        }

        [HttpGet]

        public async Task<IActionResult> All()
        {
            var playLists = await _playListService.GetAllAsync();
            var playListsDto = _mapper.Map<List<PlayListDto>>(playLists.ToList());
            return CreateActionResult(GlobalResultDto<List<PlayListDto>>.Success(200, playListsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            //throw new InvalidOperationException("Test");
            var playList = await _playListService.GetById(id);
            var playListDto = _mapper.Map<PlayListDto>(playList);
            return CreateActionResult(GlobalResultDto<PlayListDto>.Success(200, playListDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PlayListDto playListDto)
        {
            var playList = await _playListService.AddAsync(_mapper.Map<PlayList>(playListDto));
            var playListDtos = _mapper.Map<PlayListDto>(playList);
            return CreateActionResult(GlobalResultDto<PlayListDto>.Success(201, playListDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(PlayListDto playListDto)
        {
            await _playListService.UpdateAsync(_mapper.Map<PlayList>(playListDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var playList = await _playListService.GetById(id);
            await _playListService.RemoveAsync(playList);
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}
