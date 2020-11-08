using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace completed1.Controllers
{
    
    [ApiController]
    [Route("api/items")]
    public class HomeController:ControllerBase
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Home()
        {
            
            return Ok(_context.StringItems.ToList());
        }

        public StringItem AddItem()
        {
            var item = new StringItem(){Name="test"};

            _context.StringItems.Add(item);
            _context.SaveChanges();

            return item;
        }
    }
}