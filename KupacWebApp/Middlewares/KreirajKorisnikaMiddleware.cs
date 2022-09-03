using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace KupacWebApp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class KreirajKorisnikaMiddleware
    {
        private readonly RequestDelegate _next;

        public KreirajKorisnikaMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var v = httpContext.Session.Get("Identity");
            if(v is not null)
            {
                httpContext.User = new ClaimsPrincipal();
                var dictionaryClaims = JsonSerializer.Deserialize<Dictionary<string, string>>(httpContext.Session.Get("Identity"));
                var claims = dictionaryClaims.Select(k => new Claim(k.Key, k.Value));
                ClaimsIdentity identity = new ClaimsIdentity(claims);
                httpContext.User.AddIdentity(identity);
            }
           
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class KreirajKorisnikaMiddlewareExtensions
    {
        public static IApplicationBuilder UseKreirajKorisnikaMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<KreirajKorisnikaMiddleware>();
        }
    }
}
