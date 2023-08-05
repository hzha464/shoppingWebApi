using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shoppingWebApi.Dtos.Order;
using shoppingWebApi.Dtos.ProudctItem;
using shoppingWebApi.Dtos.User;

namespace shoppingWebApi
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductDto>();
            CreateMap<Order, GetOrderDto>();
            CreateMap<User, UserResponseDto>();
            CreateMap<ProductItem, GetProductItemDto>();
        }
    }
}