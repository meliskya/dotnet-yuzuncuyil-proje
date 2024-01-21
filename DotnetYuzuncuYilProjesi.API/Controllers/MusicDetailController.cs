using AutoMapper;
using DotnetYuzuncuYilProjesi.Core;
using DotnetYuzuncuYilProjesi.Core.DTOs;
using DotnetYuzuncuYilProjesi.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYilProjesi.API.Controllers
{
    public class MusicDetailController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IMusicDetailService _musicDetailService;
        public MusicDetailController(IMapper mapper, IMusicDetailService musicDetailService)
        {
            _mapper = mapper;
            _musicDetailService = musicDetailService;
        }

        [HttpGet]

        public async Task<IActionResult> All()
        {
            var musicDetail = await _musicDetailService.GetAllAsync();
            var musicDetailDto = _mapper.Map<List<MusicDetailDto>>(musicDetail.ToList());
            return CreateActionResult(GlobalResultDto<List<MusicDetailDto>>.Success(200, musicDetailDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            //throw new InvalidOperationException("Test");
            var musicDetail = await _musicDetailService.GetById(id);
            var musicDetailDto = _mapper.Map<MusicDetailDto>(musicDetail);
            return CreateActionResult(GlobalResultDto<MusicDetailDto>.Success(200, musicDetailDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(MusicDetailDto musicDetailDto)
        {
            var musicDetail = await _musicDetailService.AddAsync(_mapper.Map<MusicDetail>(musicDetailDto));
            var musicDetailDtos = _mapper.Map<MusicDetailDto>(musicDetail);
            return CreateActionResult(GlobalResultDto<MusicDetailDto>.Success(201, musicDetailDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(MusicDetailDto musicDetailDto)
        {
            await _musicDetailService.UpdateAsync(_mapper.Map<MusicDetail>(musicDetailDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var musicDetail = await _musicDetailService.GetById(id);
            await _musicDetailService.RemoveAsync(musicDetail);
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}
