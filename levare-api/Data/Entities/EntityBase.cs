namespace Levare.Data.Entities;

public class EntityBase
{
    public int Id { get; set; }
    public int CreatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
}