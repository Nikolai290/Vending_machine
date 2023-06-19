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
}