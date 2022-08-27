using EcommerceWebAPPService.Model;
using EcommerceWebAPPService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebAPPService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IECOMService<Product> _productService;
        public ProductController(IECOMService<Product> service)
        {
            _productService = service;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllProducts()
        {
            try
            {
                var employees = _productService.GetAllList();
                if (employees == null) return NotFound();
                return Ok(employees);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetAllProductsId(int id)
        {
            try
            {
                var employees = _productService.GetDetailsById(id);
                if (employees == null) return NotFound();
                return Ok(employees);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult AddProducts(Product productModel)
        {
            try
            {
                var model = _productService.SaveItem(productModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var model = _productService.DeleteItem(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
