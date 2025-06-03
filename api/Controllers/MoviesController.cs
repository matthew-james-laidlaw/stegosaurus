using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace api.Controllers;

public class Movie
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
}

public class CreateMovieDto
{
    public string Title { get; set; }
    public string Director { get; set; }
    public IFormFile File { get; set; }
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

    [HttpGet("{id:guid}/file")]
    public async Task<IActionResult> GetFile([FromRoute] Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<ActionResult<Movie>> Create([FromForm] CreateMovieDto dto)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        throw new NotImplementedException();
    }
}
