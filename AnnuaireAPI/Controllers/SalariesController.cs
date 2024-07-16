﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnnuaireModel.Context;
using AnnuaireModel.Dao;

namespace AnnuaireAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalariesController : ControllerBase
    {
        private readonly AnnuaireContext _context;

        public SalariesController(AnnuaireContext context)
        {
            _context = context;
        }

        // GET: api/Salaries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Salarie>>> GetSalaries()
        {
            return await _context.Salaries.Include(s => s.Service)
                                          .Include(s => s.Site).ToListAsync();
        }

        // GET: api/Salaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Salarie>> GetSalarie(int id)
        {
            var salarie = await _context.Salaries.Include(s => s.Service)
                                                 .Include(s => s.Site)
                                                 .Where(v => v.Id == id)
                                                 .FirstOrDefaultAsync();

            if (salarie == null)
            {
                return NotFound();
            }

            return salarie;
        }

        // PUT: api/Salaries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalarie(int id, Salarie salarie)
        {
            if (id != salarie.Id)
            {
                return BadRequest();
            }

            _context.Entry(salarie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalarieExists(id))
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

        // POST: api/Salaries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Salarie>> PostSalarie(Salarie salarie)
        {
            _context.Salaries.Add(salarie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalarie", new { id = salarie.Id }, salarie);
        }

        // DELETE: api/Salaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalarie(int id)
        {
            var salarie = await _context.Salaries.FindAsync(id);
            if (salarie == null)
            {
                return NotFound();
            }

            _context.Salaries.Remove(salarie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalarieExists(int id)
        {
            return _context.Salaries.Any(e => e.Id == id);
        }
    }
}
