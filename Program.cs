namespace Projeto_Web;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.UseStaticFiles();
        app.MapGet("/", () => "Hello World!");
        app.MapGet("/cliente", () => "Cliente !!!!");
        app.MapGet("/produtos", ()=> "Produtos!!!!");
        app.Run();
    }
}
