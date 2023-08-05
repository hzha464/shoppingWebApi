using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingWebApi.models
{
    public class Order
    {
        public int Id { get; set; }
        public  List<ProductItem>? item { get; set; }
        public OrderStatus status { get; set; } = OrderStatus.Cart;
        public User? user { get; set; }
    }
}