using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proiect_Backend.Data;
using Proiect_Backend.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public OrdersController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Orders
    [HttpGet]
    public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders(Order order)
    {
        var orders = await _context.Orders
            .Include(order => order.UserOrders)
            .ThenInclude(userOrder => userOrder.User)
            .Select(order => new OrderDto
            {
                UserIds = order.UserOrders.Select(uo => uo.UserId).ToList()
            })
            .ToListAsync();

        return Ok(orders);
    }

    // POST: api/Orders
    [HttpPost]
    public async Task<ActionResult<OrderDto>> CreateOrder(CreateOrderDto createOrderDto)
    {
        var order = new Order
        {
            
        };

       
        

        // Crează relația many-to-many între User și Order
        var userOrder = new UserOrder { UserId = createOrderDto.UserId, Order = order };
        _context.UserOrders.Add(userOrder);

        await _context.SaveChangesAsync();

        return CreatedAtAction("GetOrder", new { id = order.OrderId }, new OrderDto { });
    }

    // GET: api/Orders/5
    [HttpGet("{id}")]
    public async Task<ActionResult<OrderDto>> GetOrder(int id)
    {
        var order = await _context.Orders
            .Include(o => o.UserOrders)
            .ThenInclude(uo => uo.User)
            .FirstOrDefaultAsync(o => o.OrderId == id);

        if (order == null)
        {
            return NotFound();
        }

        return new OrderDto
        {
            
        };
    }

    
}
