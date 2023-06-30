namespace Vending_machine.Business.Dtos.OperationsDtos;

public class MoneyChangeOutDto
{
    public int MoneyChangeSummary { get; set; }
    public IList<CoinTypeQuantityPair> MoneyChange { get; set; }
}