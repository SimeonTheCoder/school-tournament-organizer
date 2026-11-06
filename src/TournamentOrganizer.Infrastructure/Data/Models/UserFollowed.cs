using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentOrganizer.Infrastructure.Data.Models;

public class UserFollowed
{
    public UserFollowed()
    {
        this.Id = Guid.NewGuid().ToString();
        this.FollowedOn = DateTime.UtcNow;
    }

    [Key]
    public string Id {get; set;} = string.Empty;

    [Required]
    public bool Active {get; set;} = true;

    [Required]
    public DateTime FollowedOn {get; set;} 

    [Required]
    public string UserId {get; set;} = string.Empty;
    [ForeignKey(nameof(UserId))]
    public virtual User User {get; set;} = null!;

    [Required]
    public string FollowableId {get; set;} = string.Empty;
    [ForeignKey(nameof(FollowableId))]
    public virtual Followable Followable {get; set;} = null!;
}