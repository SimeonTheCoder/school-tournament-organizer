using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TournamentOrganizer.Infrastructure.Data.Enums;

namespace TournamentOrganizer.Infrastructure.Data.Models;

public class Sport
{
    public Sport()
    {
        this.Id = Guid.NewGuid().ToString();
    }

    [Key]
    public string Id {get; set;} = string.Empty;

    [Required]
    public string Name {get; set;} = string.Empty;

    [Required]
    public ScoringType ScoringType {get; set;}

    public string? FollowableId = null!;
    [ForeignKey(nameof(FollowableId))]
    public virtual Followable? Followable {get; set;}
}