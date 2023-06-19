using Microsoft.AspNetCore.Mvc;
using Vending_machine.Business.Interfaces.Services;

namespace Vending_machine.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseCrudController<TCreateDto, TUpdateDto, TOutDto> : ControllerBase
{
    private readonly IBaseCrudService<TCreateDto, TUpdateDto, TOutDto> _baseCrudTypeService;

    public BaseCrudController(IBaseCrudService<TCreateDto, TUpdateDto, TOutDto> baseCrudTypeService)
    {
        _baseCrudTypeService = baseCrudTypeService;
    }
    
    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<TOutDto>>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var foo = User.Identity;
        try
        {
            var outDto = await _baseCrudTypeService.GetAllAsync(cancellationToken);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetById/{Id}")]
    public async Task<ActionResult<TOutDto>> GetByIdAsync([FromRoute] int Id, CancellationToken cancellationToken = default)
    {
        try
        {
            var outDto = await _baseCrudTypeService.GetByIdAsync(Id, cancellationToken);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("Create")]
    public async Task<ActionResult<TOutDto>> CreateAsync([FromBody] TCreateDto dto, CancellationToken cancellationToken = default)
    {
        try
        {
            var outDto = await _baseCrudTypeService.CreateAsync(dto, cancellationToken);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("Update/{id}")]
    public async Task<ActionResult<TOutDto>> UpdateAsync([FromRoute] int id, [FromBody] TUpdateDto dto, CancellationToken cancellationToken = default)
    {
        try
        {
            var outDto = await _baseCrudTypeService.UpdateAsync(id, dto, cancellationToken);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("Delete/{id}")]
    public async Task<ActionResult<bool>> DeleteAsync([FromRoute] int id, CancellationToken cancellationToken = default)
    {
        try
        {
            var outDto = await _baseCrudTypeService.DeleteAsync(id, cancellationToken);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}