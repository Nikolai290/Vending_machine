using Vending_machine.Business.Dtos.CoinDtos;

namespace Vending_machine.Business.Dtos.OperationsDtos;

public class CoinTypeQuantityPair
{
    public CoinTypeOutDto Coin { get; set; }
    public int Quantity { get; set; }
}