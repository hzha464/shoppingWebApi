using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shoppingWebApi.Dtos.ProudctItem;

namespace shoppingWebApi.Dtos.Order
{
    public class GetOrderDto
    {
        public int Id { get; set; }
        public  List<GetProductItemDto>? item { get; set; }
        public OrderStatus status { get; set; } = OrderStatus.Cart;
    }
}