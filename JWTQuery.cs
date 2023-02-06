using HotChocolate.AspNetCore.Authorization;

namespace HotChocolate.AuthReproduction;

[ExtendObjectType(typeof(Query))]
public class JWTQuery
{
    [Authorize(Policy = "JWTPolicy")]
    public string JwtQueryTest() => "JwtQueryTest";
}