using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using shoppingWebApi.Dtos.Order;
using shoppingWebApi.Dtos.ProudctItem;

namespace shoppingWebApi.Services.OrderService
{
  public class OrderService : IOrderService
  {
    private readonly IMapper _mapper;
    private readonly DataContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public OrderService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
        _context = context;
        _mapper = mapper;
    }

    private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext!.User
    .FindFirstValue(ClaimTypes.NameIdentifier)!);

    public async Task<ServiceResponse<List<GetOrderDto>>> GetAllOrders()
    {
        var serviceResponse = new ServiceResponse<List<GetOrderDto>>();
        var orders = await _context.order
            .Include(c => c.item)
                .ThenInclude(i => i.product)
            .Where(c => c.user!.Id == GetUserId())
            .ToListAsync();
        serviceResponse.Data = orders.Select(c => _mapper.Map<GetOrderDto>(c)).ToList();
        return serviceResponse;    
    }

    public async Task<ServiceResponse<GetOrderDto>> AddItem(AddProductItemDto item)
    {
        var serviceResponse = new ServiceResponse<GetOrderDto>();
        try{
            var order = await _context.order
                .Include(c => c.item)
                .FirstOrDefaultAsync(c => c.status == OrderStatus.Cart && c.user!.Id == GetUserId());
            if (order is null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "order not found.";
                return serviceResponse;
            }
            var product = await _context.Products
                .FirstOrDefaultAsync(s => s.Id == item.ProductId);
            if (product is null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "product not found.";
                return serviceResponse;
            }
            var productItem = new ProductItem();
            productItem.number = item.number;
            productItem.order = order;
            productItem.product = product;
            order.item!.Add(productItem);
            await _context.SaveChangesAsync();
            serviceResponse.Data = _mapper.Map<GetOrderDto>(order);
        }
        catch(Exception ex){
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<GetOrderDto>> GetOneOrder(int id)
    {
        var serviceResponse = new ServiceResponse<GetOrderDto>();

        try
        {
            var order = await _context.order
                    .Include(c => c.item)
                        .ThenInclude(i => i.product)
                    .FirstOrDefaultAsync(c => c.Id == id && c.user!.Id == GetUserId());
            serviceResponse.Data = _mapper.Map<GetOrderDto>(order);
        }
        catch(Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }
        return serviceResponse;

    }

    public async Task<ServiceResponse<GetOrderDto>> DeleteItem(int id)
    {
        var serviceResponse = new ServiceResponse<GetOrderDto>();
        
        try
        {
            var item = await _context.ProductItems
                .Include(c => c.order)
                .FirstOrDefaultAsync(c => c.Id == id && c.order.user.Id == GetUserId());

            if(item is null){
                throw new Exception($"item with Id '{id}' not found");
            }
            var order = item.order;
            _context.ProductItems.Remove(item);
            await _context.SaveChangesAsync();

            if(order is null){
                throw new Exception("order now exist");
            }else{
                serviceResponse.Data = _mapper.Map<GetOrderDto>(order);
            }
            
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }
        return serviceResponse;

    }

    public async Task<ServiceResponse<List<GetOrderDto>>> PayOrder()
    {
        var serviceResponse = new ServiceResponse<List<GetOrderDto>>();
        try
        {
            var order = await _context.order
                        .FirstOrDefaultAsync(c=>c.status == OrderStatus.Cart && c.user.Id == GetUserId());
            if(order is null){
                throw new Exception($"order with Id  not found");
            }
            order.status = OrderStatus.Ordered;

            var user = await _context.Users
                .FirstOrDefaultAsync(c => c.Id == GetUserId());
            var newcart = new Order();
            newcart.user = user;
            
            _context.order.Add(newcart);
            await _context.SaveChangesAsync();

            var orders = await _context.order
                .Include(c => c.item)
                    .ThenInclude(i => i.product)
                .Where(c => c.user!.Id == GetUserId())
                .ToListAsync();
            serviceResponse.Data = orders.Select(c => _mapper.Map<GetOrderDto>(c)).ToList();
            
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }
        return serviceResponse;
    }
  }
}