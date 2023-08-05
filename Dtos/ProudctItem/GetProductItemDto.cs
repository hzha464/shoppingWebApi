using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingWebApi.Dtos.ProudctItem
{
    public class GetProductItemDto
    {
        public int Id { get; set; }
        public GetProductDto? product { get; set; }
        public int number { get; set; } = 0;
    }
}