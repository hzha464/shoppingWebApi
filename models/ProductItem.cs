using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingWebApi.models
{
    public class ProductItem
    {
        public int Id { get; set; }
        public Product? product { get; set; }
        public int number { get; set; } = 0;
        public Order? order { get; set; }
    }
}