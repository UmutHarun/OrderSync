using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSync.BusinessLayer.Abstract;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCasesController : ControllerBase
    {
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCasesController(IMoneyCaseService moneyCaseService)
        {
            _moneyCaseService = moneyCaseService;
        }

        [HttpGet("TotalMoneyCaseAmount")]
        public IActionResult TotalMoneyCaseAmount()
        {
            var value = _moneyCaseService.TTotalMoneyCaseAmount();
            return Ok(value);
        }
    }
}
