using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingWebApi.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<GetProductDto>>> GetProducts();
    }
}