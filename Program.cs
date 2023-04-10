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
        //app.MapGet("/produtos", ()=> "Produtos!!!!");
        app.MapGet("/produtos", (HttpContext contexto) =>
            {
            contexto.Response.Redirect("produtos.html", false);
            });
        //app.MapGet("/clientes" , () => "Teste de Clientes");
        app.MapGet("/clientes",(string nome, string email) =>$"O nome do cliente escolhido é: {nome} \n O email do cliente é: {email}");
        Pessoa p1=new Pessoa() {id=1, nome="Gabriel"};

        app.MapGet("/fornecedores" , () =>
            $"O fornecedo é: {p1.id} - {p1.nome}");
        app.Run();
    }
}
