using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotChocolate.AuthReproduction;

[ApiController]
[Route("jwt")]
[Authorize(Policy = "JWTPolicy")]
public class JWTController : ControllerBase
{
    [HttpGet("test")]
    public string CookieTest() => "CookieTest";
}