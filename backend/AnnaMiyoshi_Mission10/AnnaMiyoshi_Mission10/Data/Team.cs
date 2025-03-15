using System.ComponentModel.DataAnnotations;

namespace AnnaMiyoshi_Mission10.Data;

public class Team //holding the information for one team (singular)
{
    [Key]
    public int TeamID { get; set; }
    
    public string TeamName { get; set; }
    
}

