using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GorevTakipApi.Models;

namespace GorevTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GorevTakipDetayController : ControllerBase
    {
        private readonly GorevTakipDetayContext _context;

        public GorevTakipDetayController(GorevTakipDetayContext context)
        {
            _context = context;
        }

        // GET: api/GorevTakipDetay
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GorevTakipDetay>>> GetGorevTakipDetays()
        {
            return await _context.GorevTakipDetays.ToListAsync();
        }

        // GET: api/GorevTakipDetay/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GorevTakipDetay>> GetGorevTakipDetay(int id)
        {
            var gorevTakipDetay = await _context.GorevTakipDetays.FindAsync(id);

            if (gorevTakipDetay == null)
            {
                return NotFound();
            }

            return gorevTakipDetay;
        }

        // PUT: api/GorevTakipDetay/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGorevTakipDetay(int id, GorevTakipDetay gorevTakipDetay)
        {
            if (id != gorevTakipDetay.RecId)
            {
                return BadRequest();
            }

            _context.Entry(gorevTakipDetay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GorevTakipDetayExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool GorevTakipIcerikKontrol(ref GorevTakipDetay gorevTakipDetay)
        {
            if (String.IsNullOrWhiteSpace(gorevTakipDetay.GorevBasligi)) throw new System.Exception("Görev başlığı boş olmaz!");
            if (String.IsNullOrWhiteSpace(gorevTakipDetay.Gorev)) throw new System.Exception("Görev içeriği boş olmaz!");
            gorevTakipDetay.KayitTarihi = DateTime.Now.ToString("dd.MM.yyyy");
            return true;
        }

        // POST: api/GorevTakipDetay
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("GorevTakipDetay2")]
        public IActionResult PostGorevTakipDetay2(GorevTakipDetay gorevTakipDetay)
        {
            var apiResponse1 = new apiResponse<GorevTakipDetay>();
            try
            {
                GorevTakipIcerikKontrol(ref gorevTakipDetay);
                _context.GorevTakipDetays.Add(gorevTakipDetay);
                _context.SaveChanges();
                apiResponse1.success = true;
                apiResponse1.message = "Herşey yolunda..";
                apiResponse1.data.items = new List<GorevTakipDetay> { gorevTakipDetay };
            }
            catch (Exception Ex1)
            {
                apiResponse1.success = false;
                apiResponse1.httpCode = StatusCodes.Status200OK;
                apiResponse1.code = StatusCodes.Status400BadRequest;
                if (string.IsNullOrEmpty(apiResponse1.message)) apiResponse1.message = Ex1.Message;
                apiResponse1.internalMessage = Ex1.Message;
                if (Ex1.InnerException.Message != null) apiResponse1.internalMessage = Ex1.InnerException.Message;
            }
            return Ok(apiResponse1);
        }

        // POST: api/GorevTakipDetay
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GorevTakipDetay>> PostGorevTakipDetay(GorevTakipDetay gorevTakipDetay)
        {
            _context.GorevTakipDetays.Add(gorevTakipDetay);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGorevTakipDetay", new { id = gorevTakipDetay.RecId }, gorevTakipDetay);
        }

        // DELETE: api/GorevTakipDetay/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGorevTakipDetay(int id)
        {
            var gorevTakipDetay = await _context.GorevTakipDetays.FindAsync(id);
            if (gorevTakipDetay == null)
            {
                return NotFound();
            }

            _context.GorevTakipDetays.Remove(gorevTakipDetay);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GorevTakipDetayExists(int id)
        {
            return _context.GorevTakipDetays.Any(e => e.RecId == id);
        }
    }
}
