using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingWebApi.Dtos.Product
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public string brand { get; set; } = "default";
        public string model { get; set; } = "";
        public string type { get; set; } ="";
        public int price { get; set; } = 0;
        public int rating { get; set; } = 4;
        public int stock { get; set; }=0;
        public bool waterproof { get; set; }
        public bool fastCharge { get; set; }
        public string? image { get; set; }
    }
}