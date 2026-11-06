using System.ComponentModel.DataAnnotations;
using TournamentOrganizer.Infrastructure.Data.Enums;

namespace TournamentOrganizer.Infrastructure.Data.Models;

public class Followable
{
    public Followable()
    {
        Id = Guid.NewGuid().ToString();
    }
    
    [Key]
    public string Id { get; set; } = string.Empty;

    [Required]
    public FollowableType FollowableType {get; set;}
}
