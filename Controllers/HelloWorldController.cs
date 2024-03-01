using Microsoft.AspNetCore.Mvc;
using webapi.Services;

namespace mywebapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase{

    IHelloWorldService helloWorldService;
    private readonly ILogger<HelloWorldController> _logger;
    public HelloWorldController(ILogger<HelloWorldController> logger,IHelloWorldService helloworld)
    {
        _logger = logger;
        helloWorldService = helloworld;
    }
    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Saludando el mundo de los devops");
        return Ok(helloWorldService.GetHelloWorld()); 
    }
}