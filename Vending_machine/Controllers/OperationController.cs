using Microsoft.AspNetCore.Mvc;

namespace Vending_machine.Controllers;

[ApiController]
[Route("[controller]")]
public class OperationController : ControllerBase
{
    [HttpPost("InsertCoint/{coinId}")]
    public async Task<ActionResult> InsertCoinAsync([FromRoute] int coinId)
    {
        try
        {
            
            
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
}