using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp
{
    public class AutentificationMiddleware
    {
        private RequestDelegate _next;

        public AutentificationMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];

            if(string.IsNullOrWhiteSpace(token))
            {
                context.Response.StatusCode = 403;
            } 
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
