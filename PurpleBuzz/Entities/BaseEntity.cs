namespace PurpleBuzz.Entities;

public class BaseEntity
{
    public int id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}