using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shoppingWebApi.Dtos.Order;

namespace shoppingWebApi.Dtos.User
{
    public class UserResponseDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<GetOrderDto>? order { get; set; }

    }
}