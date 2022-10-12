using System.ComponentModel.DataAnnotations.Schema;

namespace Levare.Data.Entities;

public class Report : EntityBase
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int CustomerId { get; set; }

    // [ForeignKey(nameof(CustomerId))]
    // public Customer Customer { get; set; }
}