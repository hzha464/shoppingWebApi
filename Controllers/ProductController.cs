global using shoppingWebApi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shoppingWebApi.Services.ProductService;

namespace shoppingWebApi.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController :ControllerBase
    {
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetProductDto>>>> Get(){
            return Ok( await _productService.GetProducts());
        }
        
    }
}