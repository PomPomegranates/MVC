namespace NC_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddScoped<AuthorService>();
            builder.Services.AddScoped<AuthorModel>();
            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapControllers();
            });
            app.MapGet("/", () => "Hello World!");

            app.Run();



            //We want the IActionResult 200OK List of Authors
        }
    }
}
