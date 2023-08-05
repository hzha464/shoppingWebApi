using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shoppingWebApi.Dtos.Order;
using shoppingWebApi.Dtos.ProudctItem;

namespace shoppingWebApi.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<List<GetOrderDto>>> GetAllOrders();
        Task<ServiceResponse<GetOrderDto>> AddItem(AddProductItemDto item);
        Task<ServiceResponse<GetOrderDto>> GetOneOrder(int id);
        Task<ServiceResponse<GetOrderDto>> DeleteItem(int id);
        Task<ServiceResponse<List<GetOrderDto>>> PayOrder();

    }
}