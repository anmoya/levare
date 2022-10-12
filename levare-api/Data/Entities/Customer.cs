using System.ComponentModel.DataAnnotations.Schema;

namespace Levare.Data.Entities;

public class Customer : EntityBase
{
    public string Name { get; set; }
    public string FantasyName { get; set; }
    public string Email { get; set; }
    public int CommunityId { get; set; }

    [ForeignKey(nameof(CommunityId))]
    public Community community { get; set; }
}