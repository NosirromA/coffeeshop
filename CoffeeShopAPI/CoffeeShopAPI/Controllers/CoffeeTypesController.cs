using CoffeeShopAPI.Data;
using CoffeeShopAPI.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CoffeeShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeTypesController : ControllerBase
    {
        private readonly DbCoffeeContext _dbCoffeeContext;
        public CoffeeTypesController(DbCoffeeContext dbCoffeeContext)
        {
            _dbCoffeeContext = dbCoffeeContext;
        }

        [HttpGet]
        public async Task<List<CoffeeType>> GetCoffeeTypesAsync()
        {
            return await _dbCoffeeContext.CoffeeTypes.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CoffeeType?>> GetCoffeeTypeByIdAsync(int id)
        {
            var coffee = await _dbCoffeeContext.CoffeeTypes.SingleOrDefaultAsync(x => x.Id == id);
            if (coffee is null)
            {
                return NotFound(null);
            }
            return Ok(coffee);
        }
    }
}