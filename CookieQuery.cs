using HotChocolate.AspNetCore.Authorization;

namespace HotChocolate.AuthReproduction;

[ExtendObjectType(typeof(Query))]
public class CookieQuery
{
    [Authorize(Policy = "CookiePolicy")]
    public string CookieQueryTest() => "CookieQueryTest";
}