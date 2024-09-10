using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderSync.BusinessLayer.Abstract;
using OrderSync.DataAccessLayer.Concrete;
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

        [HttpGet("GetBasketListByTableNumberWithProductName")]
        public IActionResult GetBasketListByTableNumberWithProductName(int id)
        {
            using var context = new OrderSyncDbContext();
            var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableID == id).Select(z => new ResultBasketListWithProductDto
            {
                BasketID = z.BasketID,
                Count = z.Count,
                MenuTableID = id,
                Price = z.Price,
                ProductID = z.ProductID,
                ProductName = z.Product.ProductName,
                TotalPrice = z.TotalPrice,
            }).ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new OrderSyncDbContext();
            _basketService.TAdd(new Basket
            {
                ProductID = createBasketDto.ProductID,
                Count=1,
                MenuTableID=1,
                Price = context.Products.Where(x => x.ProductID == createBasketDto.ProductID).Select(y => y.Price).FirstOrDefault(),
                TotalPrice=0
            });
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetById(id);
            _basketService.TDelete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }
    }
}
