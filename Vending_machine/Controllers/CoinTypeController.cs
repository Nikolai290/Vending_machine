using Microsoft.AspNetCore.Mvc;
using Vending_machine.Business.Dtos.CoinDtos;
using Vending_machine.Business.Interfaces.Services;

namespace Vending_machine.Controllers;

public class CoinTypeController : BaseCrudController<CoinTypeCreateDto, CoinTypeUpdateDto, CoinTypeOutDto>
{
    private readonly ICoinTypeService _coinTypeService;

    public CoinTypeController(ICoinTypeService coinTypeService) : base(coinTypeService)
    {
        _coinTypeService = coinTypeService;
    }
    
    [HttpGet("GetAllFull")]
    public async Task<ActionResult<IEnumerable<CoinTypeFullOutDto>>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var foo = User.Identity;
        try
        {
            var outDto = await _coinTypeService.GetAllCoinsFulAsync(cancellationToken);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}