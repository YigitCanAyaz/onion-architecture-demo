using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.Application.Dto;
using OnionArchitectureDemo.Application.Interfaces.Repository;

namespace OnionArchitectureDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allList = await _productRepository.GetAllAsync();

            var result = allList.Select(i => new ProductViewDto()
            {
                Id = i.Id,
                Name = i.Name,
            }).ToList();

            return Ok(result);
        }
    }
}
