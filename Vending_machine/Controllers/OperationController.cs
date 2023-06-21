using Microsoft.AspNetCore.Mvc;
using Vending_machine.Business.Dtos.OperationsDtos;
using Vending_machine.Business.Interfaces.Services;

namespace Vending_machine.Controllers;

[ApiController]
[Route("[controller]")]
public class OperationController : ControllerBase
{
    private readonly IOperationService _operationService;

    public OperationController(IOperationService operationService)
    {
        _operationService = operationService;
    }

    [HttpGet("GetCustomerBalance")]
    public async Task<ActionResult<int>> GetCustomerBalanceAsync(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _operationService.GetCustomerBalanceAsync(cancellationToken);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpPost("InsertCoint/{coinId}")]
    public async Task<ActionResult> InsertCoinAsync([FromRoute] int coinId, CancellationToken cancellationToken)
    {
        try
        {
            await _operationService.InsertCoinAsync(coinId, cancellationToken);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("BuyProduct/{productId}")]
    public async Task<ActionResult> TryBuyProductAsync([FromRoute] int productId, CancellationToken cancellationToken)
    {
        try
        {
            await _operationService.TryBuyProductAsync(productId, cancellationToken);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("RequestMoneyChange")]
    public async Task<ActionResult<MoneyChangeOutDto>> RequestMoneyChangeAsync(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _operationService.RequestMoneyChangeAsync(cancellationToken);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}