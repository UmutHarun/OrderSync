using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSync.BusinessLayer.Abstract;
using OrderSync.DtoLayer.AboutDto;
using OrderSync.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _aboutService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var mappedValue = _mapper.Map<About>(createAboutDto);
            _aboutService.TAdd(mappedValue);
            return Ok("Created");
        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id) 
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok("Deleted");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var mappedValue = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(mappedValue);
            return Ok("Updated");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}
