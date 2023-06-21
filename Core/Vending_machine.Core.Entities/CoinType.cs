namespace Vending_machine.Entities;

public class CoinType : BaseDbEntity
{
    public string Name { get; set; }
    public int Value { get; set; }
    public int Stock { get; set; }
    
    public IEnumerable<Operation> Operation { get; set; }
}