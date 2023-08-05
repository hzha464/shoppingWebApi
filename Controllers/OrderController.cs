using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using shoppingWebApi.Dtos.Order;
using shoppingWebApi.Dtos.ProudctItem;
using shoppingWebApi.Services.OrderService;

namespace shoppingWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderservice;

        public OrderController(IOrderService orderservice)
        {
        _orderservice = orderservice;
        }


        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetOrderDto>>>> Get()
        {   
            // int id = int.Parse(User.Claims.FirstOrDefault(c=> c.Type == ClaimTypes.NameIdentifier)!.Value)
            return Ok(await _orderservice.GetAllOrders());
        }


        [HttpPost("item")]
        public async Task<ActionResult<ServiceResponse<GetProductItemDto>>> AddItem(
            AddProductItemDto newItem)
        {
            return Ok(await _orderservice.AddItem(newItem));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetOrderDto>>> GetOneOrder(int id)
        {
            return Ok(await _orderservice.GetOneOrder(id));
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetOrderDto>>> DeleteCharacter(int id)
        {
            var response = await _orderservice.DeleteItem(id);
            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetOrderDto>>>>PayOrder()
        {
            var response = await _orderservice.PayOrder();
            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    
    }
}