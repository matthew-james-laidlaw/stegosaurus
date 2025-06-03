using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
}

[ApiController]
[Route("movies")]
public class MoviesController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetAll(
        [FromQuery] string? title = null,
        [FromQuery] string? director = null)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Movie>> GetOne([FromRoute] Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<ActionResult<Movie>> Create([FromBody] Movie movie)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        throw new NotImplementedException();
    }
}
