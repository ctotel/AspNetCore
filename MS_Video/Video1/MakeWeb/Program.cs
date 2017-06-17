using System;
using Microsoft.AspNetCore.Hosting;
using movingtoweb;

namespace Video1
{
    class Program
    {
        static void Main(string[] args)
        {   
		    var host = new WebHostBuilder()
			    .UseKestrel()
				.UseStartup<Startup>()
				.Build();
				
				host.Run();
        }
    }
}
