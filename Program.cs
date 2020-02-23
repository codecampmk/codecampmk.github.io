using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace codecampmk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .UseWebRoot(".")
                .Configure(x =>
                {
                    x.UseDefaultFiles();
                    x.UseStaticFiles();
                })
                .Build()
                .Run();
        }
    }
}
