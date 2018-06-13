using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CorePhoneBook.Models;

namespace CorePhoneBook.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PhoneRecordsController : ControllerBase
    {
        private readonly CorePhoneBookDBContext _context;

        public PhoneRecordsController(CorePhoneBookDBContext context)
        {
            _context = context;
        }

        // GET: api/PhoneRecords
        [Route("~/api/GetAllPhoneRecords")]
        [HttpGet]
        public IEnumerable<PhoneRecord> GetPhoneRecord()
        {
            return _context.PhoneRecord;
        }

        // GET: api/PhoneRecords/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhoneRecord([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var phoneRecord = await _context.PhoneRecord.FindAsync(id);

            if (phoneRecord == null)
            {
                return NotFound();
            }

            return Ok(phoneRecord);
        }

        // PUT: api/PhoneRecords/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPhoneRecord([FromRoute] int id, [FromBody] PhoneRecord phoneRecord)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != phoneRecord.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(phoneRecord).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PhoneRecordExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/PhoneRecords
        //[HttpPost]
        //public async Task<IActionResult> PostPhoneRecord([FromBody] PhoneRecord phoneRecord)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.PhoneRecord.Add(phoneRecord);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPhoneRecord", new { id = phoneRecord.Id }, phoneRecord);
        //}

        //// DELETE: api/PhoneRecords/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePhoneRecord([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var phoneRecord = await _context.PhoneRecord.FindAsync(id);
        //    if (phoneRecord == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.PhoneRecord.Remove(phoneRecord);
        //    await _context.SaveChangesAsync();

        //    return Ok(phoneRecord);
        //}

        //private bool PhoneRecordExists(int id)
        //{
        //    return _context.PhoneRecord.Any(e => e.Id == id);
        //}
    }
}