namespace Vending_machine.Entities;

public class Manufacturer : BaseDbEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}