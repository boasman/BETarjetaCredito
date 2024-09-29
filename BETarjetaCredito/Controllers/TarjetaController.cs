using BETarjetaCredito.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace BETarjetaCredito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public TarjetaController(AplicationDbContext dbContext)
        {
            _context = dbContext;    
        }
        // GET: api/<TarjetaCreditoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listTarjeta = await _context.tarjetaCreditos.ToListAsync();
                return Ok(listTarjeta);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
        }

        // GET api/<TarjetaCreditoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            try
            {
                var tarjetaCredito = _context.tarjetaCreditos.FirstOrDefault(x => x.Id == id);

                if (tarjetaCredito == null)
                {
                    return NotFound("Not Found");
                }

                return Ok(tarjetaCredito);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
           
            
        }

        // POST api/<TarjetaCreditoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TarjetaCredito tarjetaCredito)
        {
            try
            {
                _context.tarjetaCreditos.Add(tarjetaCredito);
                await _context.SaveChangesAsync();
                return Ok(tarjetaCredito);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);                
            }
        }

        // PUT api/<TarjetaCreditoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TarjetaCredito tarjetaCredito)
        {

        }

        // DELETE api/<TarjetaCreditoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
