using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnnaMiyoshi_Mission10.Data;

public class Bowler //holding the information for one bowler (singular)
{
    [Key]
    public int BowlerID { get; set; }
    
    public string BowlerLastName { get; set; }
    
    public string BowlerFirstName { get; set; }
    
    public string? BowlerMiddleInit { get; set; } // ? to handle null values
    
    [ForeignKey("TeamID")]
    public int TeamID { get; set; } 
    public Team Team { get; set; }  // Navigation property for EF Core to establish a relationship with the Teams table
    
    public string BowlerAddress { get; set; }
    
    public string BowlerCity { get; set; }
    
    public string BowlerState { get; set; }
    
    public string BowlerZip { get; set; }
    
    public string BowlerPhoneNumber { get; set; }
    
}
// what rows look like