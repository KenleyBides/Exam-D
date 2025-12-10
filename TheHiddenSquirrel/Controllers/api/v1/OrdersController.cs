using Microsoft.AspNetCore.Mvc;
using TheHiddenSquirrel.Data;
using TheHiddenSquirrel.Models;
using Microsoft.EntityFrameworkCore;

namespace TheHiddenSquirrel.Controllers.api.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // hsared connection
        private readonly ApplicationDbContext _db;

        // constructor dependency
        public OrdersController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: api/v1/orders
        [HttpGet]
        public IActionResult Index()
        {
            var orders = _db.Order.ToList();

            return Ok(orders);
        }
    }
}