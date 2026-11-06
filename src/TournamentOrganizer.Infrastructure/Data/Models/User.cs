using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TournamentOrganizer.Infrastructure.Data.Models;

public class User : IdentityUser
{
    [Required]
    public bool Active { get; set; } = true;

    public string? Class { get; set; } = string.Empty;

    public string? FollowableId { get; set; } = string.Empty;

    [ForeignKey(nameof(FollowableId))]
    public virtual Followable? Followable { get; set; } = null!;
}
