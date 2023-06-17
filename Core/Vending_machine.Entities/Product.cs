namespace Vending_machine.Entities;

public class Product : BaseDbEntity
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public Manufacturer Manufacturer { get; set; }
}