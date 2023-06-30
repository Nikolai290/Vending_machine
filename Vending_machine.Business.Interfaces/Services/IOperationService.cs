using Vending_machine.Business.Dtos.OperationsDtos;
using Vending_machine.Business.Dtos.ProductDtos;

namespace Vending_machine.Business.Interfaces.Services;

public interface IOperationService
{
    Task<int> GetCustomerBalanceAsync(CancellationToken cancellationToken);
    Task InsertCoinAsync (int coinId, CancellationToken cancellationToken);
    Task<ProductOutDto> TryBuyProductAsync (int productId, CancellationToken cancellationToken);
    Task<MoneyChangeOutDto> RequestMoneyChangeAsync(CancellationToken cancellationToken);
}