using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webApi.Models.DTO;
using webApi.Repositories;

namespace webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllAsync();

            var regionDtos = mapper.Map<List<RegionDto>>(regions);
            return Ok(regionDtos);
        }
    }
}
