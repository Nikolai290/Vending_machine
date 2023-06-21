using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using AutoMapper;
using Vending_machine.Business.Dtos.CoinDtos;
using Vending_machine.Business.Dtos.OperationsDtos;
using Vending_machine.Business.Interfaces.Services;
using Vending_machine.Domain.Interfaces.Repositories;
using Vending_machine.Entities;

namespace Vending_machine.Business.Implementations.Services;

public class OperationService : IOperationService
{
    private readonly IOperationRepostory _operationRepostory;
    private readonly ICoinTypeRepository _coinTypeRepository;
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public OperationService(
        IOperationRepostory operationRepostory,
        ICoinTypeRepository coinTypeRepository,
        IProductRepository productRepository,
        IMapper mapper)
    {
        _operationRepostory = operationRepostory;
        _coinTypeRepository = coinTypeRepository;
        _productRepository = productRepository;
        _mapper = mapper;
    }
    
    public async Task<int> GetCustomerBalanceAsync(CancellationToken cancellationToken)
    {
        var result = await _operationRepostory.GetCustomerRepositoryAsync(cancellationToken);

        return result;
    }

    public async Task InsertCoinAsync(int coinId, CancellationToken cancellationToken)
    {
        var coin = await _coinTypeRepository.GetByIdAsync(coinId, cancellationToken);
        var customerBalance = await _operationRepostory.GetCustomerRepositoryAsync(cancellationToken);
        coin.Stock++;
        var operation = new Operation()
        {
            OperationDatetime = DateTime.UtcNow,
            OperationType = OperationType.CoinInserted,
            CustomerBalance = customerBalance + coin.Value,
            VendingBalance = await _coinTypeRepository.GetVendingBalanceAsync(cancellationToken),
            CoinInserted = coin,
            ProductGiven = null,
            ChangeInfo = ""
        };
        await _coinTypeRepository.UpdateAsync(coin, cancellationToken);
        await _operationRepostory.CreateAsync(operation, cancellationToken);
    }

    public async Task TryBuyProductAsync(int productId, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(productId, cancellationToken);
        var customerBalance = await _operationRepostory.GetCustomerRepositoryAsync(cancellationToken);
        if (product.Cost > customerBalance)
        {
            throw new Exception("Недостаточно средств.");
        }

        var operation = new Operation()
        {
            OperationDatetime = DateTime.UtcNow,
            OperationType = OperationType.ProductGiven,
            CustomerBalance = customerBalance - product.Cost,
            VendingBalance = await _coinTypeRepository.GetVendingBalanceAsync(cancellationToken),
            CoinInserted = null,
            ProductGiven = product,
            ChangeInfo = ""
        };
        await _operationRepostory.CreateAsync(operation, cancellationToken);
    }

    public async Task<MoneyChangeOutDto> RequestMoneyChangeAsync(CancellationToken cancellationToken)
    {
        var customerBalance = await _operationRepostory.GetCustomerRepositoryAsync(cancellationToken);
        var moneyChangeOutDto = new MoneyChangeOutDto();

        if (customerBalance == 0)
        {
            return moneyChangeOutDto;
        }

        var coinTypeQuantityPairs = new List<CoinTypeQuantityPair>();

        var coins = (await _coinTypeRepository.GetAllAsync(cancellationToken))
            .OrderByDescending(coin => coin.Value);

        foreach (var coin in coins)
        {
           var (coinTypeQuantityPair, newBalance) = GetCoinTypeQuantityPairAsync(coin, customerBalance);
           customerBalance = newBalance;
           coinTypeQuantityPairs.Add(coinTypeQuantityPair);
           if (customerBalance == 0)
           {
               break;
           }
        }

        if (customerBalance > 0)
        {
            throw new Exception("В автомате недостаточно монет чтобы выдать сдачу. Обратитесь по номеру телефона...");
        }
        
        moneyChangeOutDto.MoneyChange = coinTypeQuantityPairs;

        var operation = new Operation()
        {
            OperationDatetime = DateTime.UtcNow,
            OperationType = OperationType.ChangeGiven,
            CustomerBalance = customerBalance,
            VendingBalance = await _coinTypeRepository.GetVendingBalanceAsync(cancellationToken),
            CoinInserted = null,
            ProductGiven = null,
            ChangeInfo = JsonSerializer.Serialize(moneyChangeOutDto.MoneyChange)
        };
        await _operationRepostory.CreateAsync(operation, cancellationToken);
        await _coinTypeRepository.UpdateRangeAsync(coins, cancellationToken);


        return moneyChangeOutDto;
    }

    private (CoinTypeQuantityPair, int) GetCoinTypeQuantityPairAsync(CoinType coin, int customerBalance)
    {
        var need = customerBalance / coin.Value;
        need = need > coin.Stock ? coin.Stock : need;
        
        var coinTypeQuantityPair = new CoinTypeQuantityPair()
        {
            Coin = _mapper.Map<CoinTypeOutDto>(coin),
            Quantity = need
        };
        coin.Stock -= need;
        var newBalance = customerBalance - need * coin.Value;

        return (coinTypeQuantityPair, newBalance);
    }
}