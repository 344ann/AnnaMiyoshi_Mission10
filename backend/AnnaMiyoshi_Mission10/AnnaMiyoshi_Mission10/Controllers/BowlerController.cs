using AnnaMiyoshi_Mission10.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace AnnaMiyoshi_Mission10.Controllers;

[Route("[controller]")]
[ApiController]
public class BowlerController : Controller
{

    private BowlerDbContext _bowlerContext; // Private field to hold the database context
    
    public BowlerController(BowlerDbContext temp) //Constructor
    {
        _bowlerContext = temp;
    }
    
    //display a list
    [HttpGet(Name = "GetBowler")]
    public IEnumerable<Bowler> Get()
    {
        IEnumerable<Bowler> bowlerList = _bowlerContext.Bowlers
            .Include(b => b.Team) // Ensure Team data is included
            .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks") // Filter by team name
            .OrderBy(b => b.BowlerFirstName)
            .ToList();
        
        return (bowlerList);
    }
}