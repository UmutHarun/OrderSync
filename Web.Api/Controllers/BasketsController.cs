using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSync.BusinessLayer.Abstract;
using OrderSync.DtoLayer.BasketDto;
using OrderSync.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;

        public BasketsController(IBasketService basketService, IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _basketService.TGetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetBasketByTableId(int id)
        {
            var values = _basketService.TGetBasketByTableNumber(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            _basketService.TAdd(_mapper.Map<Basket>(createBasketDto));
            return Ok("created");
        }
    }
}
