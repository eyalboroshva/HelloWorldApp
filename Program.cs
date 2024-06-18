using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Hosting;

mespace HelloWorldApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWeb(dbuilder =>
                  {webbuilder.UseStartup<Startup>();});
}
}
