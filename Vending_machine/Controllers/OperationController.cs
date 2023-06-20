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
    public async Task<ActionResult<int>> GetCustomerBalanceAsync()
    {
        try
        {
            var result = await _operationService.GetCustomerBalanceAsync();
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpPost("InsertCoint/{coinId}")]
    public async Task<ActionResult> InsertCoinAsync([FromRoute] int coinId)
    {
        try
        {
            await _operationService.InsertCoinAsync(coinId);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("BuyProduct/{productId}")]
    public async Task<ActionResult> TryBuyProductAsync([FromRoute] int productId)
    {
        try
        {
            await _operationService.TryBuyProductAsync(productId);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("RequestMoneyChange")]
    public async Task<ActionResult<RequestMoneyChangeOutDto>> RequestMoneyChangeAsync()
    {
        try
        {
            var result = await _operationService.RequestMoneyChangeAsync();
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}