namespace Vending_machine.Business.Dtos.OperationsDtos;

public class MoneyChangeOutDto
{
    public IList<CoinTypeQuantityPair> MoneyChange { get; set; }
}