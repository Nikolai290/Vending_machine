namespace Vending_machine.Entities;

public class Product : BaseDbEntity
{
    public string Name { get; set; }
    public string Image { get; set; }
    public int Cost { get; set; }
    public int Stock { get; set; }
    public IEnumerable<Operation> Operation { get; set; }
}