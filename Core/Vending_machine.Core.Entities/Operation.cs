namespace Vending_machine.Entities;

public class Operation : BaseDbEntity
{
    public DateTime OperationDatetime { get; set; }
    public OperationType OperationType { get; set; }
    public int CustomerBalance { get; set; }
    public int VendingBalance { get; set; }
    public CoinType CoinInserted { get; set; }
    public Product ProductGiven { get; set; }
    public string ChangeInfo { get; set; }
}