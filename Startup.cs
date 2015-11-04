using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace helloweb
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1>My First ASP.NET!</h1>");
                await context.Response.WriteAsync("<h2>Running Asp .Net 5.0 Application on OpenShift Cloud!</h2>");
               

                await context.Response.WriteAsync("<h3> Select an object to see more details.A pod contains one or more Docker containers that run together on a node,\n containing your application code.A service groups pods and provides a common DNS name and an optional, load - balanced IP address to access them. A deployment is an update to your application, triggered by a changed image or configuration.</ h3 > ");


                await context.Response.WriteAsync("<h6> Select an object to see more details.A pod contains one or more Docker containers that run together on a node,\n containing your application code.A service groups pods and provides a common DNS name and an optional, load - balanced IP address to access them. A deployment is an update to your application, triggered by a changed image or configuration.</ h6 > ");

            });
        }
    }
}
