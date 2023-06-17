namespace Vending_machine.Entities;

public class Coin : BaseDbEntity
{
    public string Name { get; set; }
    public int Value { get; set; }
}