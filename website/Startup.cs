using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace website
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
