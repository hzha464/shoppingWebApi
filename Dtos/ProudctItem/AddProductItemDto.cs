using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingWebApi.Dtos.ProudctItem
{
    public class AddProductItemDto
    {
        public int ProductId { get; set; }
        public int number { get; set; } = 0;
    }
}