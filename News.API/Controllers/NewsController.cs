using System.Net;
using Microsoft.AspNetCore.Mvc;
using News.API.Contracts;

namespace News.API.Controllers;

[ApiController]
[Route("[NewsController]")]
public partial class NewsController : ControllerBase
{
  private readonly ILogger<NewsController> _logger;

  public NewsController(ILogger<NewsController> logger)
  {
    _logger = logger;
  }
  
  [HttpGet]
  [ProducesResponseType(typeof(GetNewsResponse),(int)HttpStatusCode.OK)]
  public async Task<IActionResult> Get()
  {
    return Ok();
  }

  [HttpPost]
  [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
  public async Task<IActionResult> Create([FromBody]CreateNewsRequest request)
  {
    return Ok();
  }

  [HttpPut]
  public IActionResult Update()
  {
    return Ok();
  }

  [HttpDelete]
  public IActionResult Delete()
  {
    return Ok();
  }
}
