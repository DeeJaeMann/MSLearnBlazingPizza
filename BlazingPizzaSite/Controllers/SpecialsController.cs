using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingPizzaSite.Data;

namespace BlazingPizzaSite.Controllers;

/// <summary>
/// Controller that allows us to query the database for pizza specials and return them as JSON at http://localhost:port/specials
/// </summary>
[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.Specials.ToListAsync()).OrderByDescending(special => special.BasePrice).ToList();
    }
}