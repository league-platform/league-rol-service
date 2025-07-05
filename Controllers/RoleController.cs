using Microsoft.AspNetCore.Mvc;
using RolService.Models;
using RolService.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RolService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoleController : ControllerBase
{
    private readonly AppDbContext _context;

    public RoleController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Role>>> Get() =>
        await _context.Roles.ToListAsync();

    [HttpPost]
    public async Task<ActionResult<Role>> Create(Role role)
    {
        _context.Roles.Add(role);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = role.Id }, role);
    }
}
