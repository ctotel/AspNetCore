
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace movingtoweb
{
    public class Startup 
	{
	    public void Configure (IApplicationBuilder app)
		{
		   app.Run(context =>  {
		     return context.Response.WriteAsync("Hello web !");
		   });
		}

     }
}
