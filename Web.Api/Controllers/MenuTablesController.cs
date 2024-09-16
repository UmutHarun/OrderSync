using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSync.BusinessLayer.Abstract;
using OrderSync.DtoLayer.MenuTableDto;
using OrderSync.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTablesController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;
		private readonly IMapper _mapper;

		public MenuTablesController(IMenuTableService menuTableService, IMapper mapper)
		{
			_menuTableService = menuTableService;
			_mapper = mapper;
		}

		[HttpGet("MenuTablesCount")]
        public IActionResult MenuTablesCount()
        {
            var value = _menuTableService.TTotalMenuTableCount();
            return Ok(value);
        }

		[HttpGet]
		public IActionResult Index()
		{
			var values = _menuTableService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
		{
			var mappedValue = _mapper.Map<MenuTable>(createMenuTableDto);
			_menuTableService.TAdd(mappedValue);
			return Ok("Created");
		}

		[HttpDelete]
		public IActionResult DeleteMenuTable(int id)
		{
			var value = _menuTableService.TGetById(id);
			_menuTableService.TDelete(value);
			return Ok("Deleted");
		}

		[HttpPut]
		public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
		{
			var mappedValue = _mapper.Map<MenuTable>(updateMenuTableDto);
			_menuTableService.TUpdate(mappedValue);
			return Ok("Updated");
		}

		[HttpGet("{id}")]
		public IActionResult GetMenuTable(int id)
		{
			var value = _menuTableService.TGetById(id);
			return Ok(value);
		}
	}
}
