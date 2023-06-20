namespace Vending_machine.Business.Dtos.OperationsDtos;

public class RequestMoneyChangeOutDto
{
    public IEnumerable<CoinTypeQuantityPair> MoneyChange { get; set; }
}