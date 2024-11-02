namespace PurpleBuzz.Models.Pricing;

public class PricingPlanVM
{
    public string Name { get; set; } 
    public decimal Price { get; set; }        
    public List<string> Features { get; set; } 
}