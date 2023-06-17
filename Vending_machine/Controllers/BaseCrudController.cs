using Microsoft.AspNetCore.Mvc;
using Vending_machine.Business.Interfaces.Services;

namespace Vending_machine.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseCrudController<TCreateDto, TUpdateDto, TOutDto> : ControllerBase
{
    private readonly IBaseCrudService<TCreateDto, TUpdateDto, TOutDto> _baseCrudService;

    public BaseCrudController(IBaseCrudService<TCreateDto, TUpdateDto, TOutDto> baseCrudService)
    {
        _baseCrudService = baseCrudService;
    }
    
    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<TOutDto>>> GetAllAsync()
    {
        try
        {
            var outDto = await _baseCrudService.GetAllAsync();
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetById/{Id}")]
    public async Task<ActionResult<TOutDto>> GetByIdAsync([FromRoute] int Id)
    {
        try
        {
            var outDto = await _baseCrudService.GetByIdAsync(Id);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("Create")]
    public async Task<ActionResult<TOutDto>> CreateAsync([FromBody] TCreateDto dto)
    {
        try
        {
            var outDto = await _baseCrudService.CreateAsync(dto);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("Update/{id}")]
    public async Task<ActionResult<TOutDto>> UpdateAsync([FromRoute] int id, [FromBody] TUpdateDto dto)
    {
        try
        {
            var outDto = await _baseCrudService.UpdateAsync(id, dto);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("Delete/{id}")]
    public async Task<ActionResult<bool>> DeleteAsync([FromRoute] int id)
    {
        try
        {
            var outDto = await _baseCrudService.DeleteAsync(id);
            return Ok(outDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}