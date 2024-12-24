using BasicEfCoreDemo.Data;
using BasicEfCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicEfCoreDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController(InvoiceDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
    {
        if (context.Contacts is null)
        {
            return NotFound();
        }

        return await context.Contacts
            .Include(contact => contact.Address)
            .ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Contact>> GetContact(Guid id)
    {
        if (context.Contacts is null)
        {
            return NotFound();
        }

        var contact = await context.Contacts.FindAsync(id);

        if (contact is null)
        {
            return NotFound();
        }

        return contact;
    }

    [HttpPost]
    public async Task<ActionResult<Contact>> PostContact(Contact contact)
    {
        if (context.Contacts is null)
        {
            return Problem("Entity set 'InvoiceContextDb.Contacts' is null.");
        }

        context.Contacts.Add(contact);
        await context.SaveChangesAsync();

        return CreatedAtAction("GetContact", new { id = contact.Id }, contact);
    }
}