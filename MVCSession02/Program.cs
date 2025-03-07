namespace MVCSession02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Register Any Services
            // before the build

            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            // Configure Any Middleware
            app.UseRouting();


            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/login", () => Signin());

            app.UseStaticFiles(); // Configure Middelware

            // MVC
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller= Movie}/{action=GetMovie}/{id?}");

            app.Run();
        }

        public static string Signin()
        {
            return "u r signed in";
        }
    }
}
