using System.ComponentModel;
using System.Net;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using News.API.Contracts;
using News.DataAccess;

namespace News.API.Controllers;

[ApiController]
[Route("[controller]")]
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
     var news = NewsRepository.Get();
    return Ok();
  }

  [HttpPost]
  [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
  public async Task<IActionResult> Create([FromBody]CreateNewsRequest request)
  {
    var newsModel = new NewsModel();
    {
      Title = request.Title, 
      Article = request.Article,
      
    }
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
