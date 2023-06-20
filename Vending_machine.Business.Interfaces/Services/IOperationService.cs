using Vending_machine.Business.Dtos.OperationsDtos;

namespace Vending_machine.Business.Interfaces.Services;

public interface IOperationService
{
    Task<int> GetCustomerBalanceAsync();
    Task InsertCoinAsync (int coinId);
    Task TryBuyProductAsync (int productId);
    Task<RequestMoneyChangeOutDto> RequestMoneyChangeAsync();
}