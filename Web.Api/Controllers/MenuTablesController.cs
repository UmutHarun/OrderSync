using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSync.BusinessLayer.Abstract;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTablesController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;

        public MenuTablesController(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }

        [HttpGet("MenuTablesCount")]
        public IActionResult MenuTablesCount()
        {
            var value = _menuTableService.TTotalMenuTableCount();
            return Ok(value);
        }
    }
}
