using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotChocolate.AuthReproduction;

[ApiController]
[Route("cookie")]
[Authorize(Policy = "CookiePolicy")]
public class CookieController : ControllerBase
{
    [HttpGet("test")]
    public string CookieTest() => "CookieTest";
}