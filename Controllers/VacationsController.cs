using Microsoft.AspNetCore.Mvc;

namespace DaprZeebeSample.Controllers;

[ApiController]
public class VacationsController : ControllerBase
{
    [HttpPost("dapr-zeebe-sample-save-data")]
    public async Task<IActionResult> HandleJob()
    {
        using var reader = new StreamReader(Request.Body);
        var body = await reader.ReadToEndAsync();

        var result = new
        {
            variables = new
            {
                approved = true,
                comment = "Handled by Dapr .NET controller"
            }
        };

        return Ok(result);
    }
}