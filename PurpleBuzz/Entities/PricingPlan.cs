namespace PurpleBuzz.Entities;

public class PricingPlan
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Features { get; set; }
}