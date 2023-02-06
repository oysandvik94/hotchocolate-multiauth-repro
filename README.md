# hotchocolate-multiauth-repro

This reproduction demonstrates behaviour where there is both JWT and Cookie authentication schemes. 
I would like different resolvers to use different schemes.

There are two controllers in the project, "JWTController" and "CookieController". 
When I do a GET towards http://localhost:5168/cookie/test I am redirected to the register endpoint, or I get access to the endpoint if I am registered and auth'ed with a cookie.
When I do a GET towards http://localhost:5168/jwt/test I recieve 401 because I dont have a bearer token.

This is the behaviour I am trying to achieve.

For my GraphQL queries it is using Cookie auth for both. For example, if I am authed with Asp.Identity and have a valid cookie, I recieve 200 for both "cookieQueryTest" and "jwtQueryTest". 
