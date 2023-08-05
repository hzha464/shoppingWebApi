using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingWebApi.Services.ProductService
{
  public class ProductService : IProductService
  {
    private static List<Product> product = new List<Product>{
            new Product()
        };
    private readonly IMapper _mapper;
    private readonly DataContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public ProductService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
    {
      _mapper = mapper;
      _httpContextAccessor = httpContextAccessor;
      _context = context;
    }
    public async Task<ServiceResponse<List<GetProductDto>>> GetProducts()
    {
      var response = new ServiceResponse<List<GetProductDto>>();
      var product = await _context.Products.ToListAsync();
      response.Data = product.Select(c => _mapper.Map<GetProductDto>(c)).ToList();
      return  response;
    }
  }
}