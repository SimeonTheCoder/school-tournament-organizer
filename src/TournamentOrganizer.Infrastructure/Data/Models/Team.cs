using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentOrganizer.Infrastructure.Data.Models;

public class Team
{
    public Team()
    {
        this.Id = Guid.NewGuid().ToString();
        this.CreatedOn = DateTime.UtcNow;
    }

    [Key]
    public string Id {get; set;} = string.Empty;

    [Required]
    public string Name {get; set;} = string.Empty;

    [Required]
    public bool Active {get; set;} = true;

    [Required]
    public DateTime CreatedOn {get; set;}

    [ForeignKey(nameof(CreatedByUserId))]
    public virtual User CreatedByUser {get; set;} = null!;
    [Required]
    public string CreatedByUserId {get; set;} = string.Empty;

    [ForeignKey(nameof(FollowableId))]
    public virtual Followable Followable {get; set;} = null!;
    [Required]
    public string FollowableId {get; set;} = string.Empty;
}