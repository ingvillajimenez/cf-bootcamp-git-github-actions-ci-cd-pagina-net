using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UsersWeb.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly Services.RandomUserService _randomUserService;

    public List<Models.User> Usuarios { get; private set; } = new();
    public int Total => Usuarios.Count;

    public IndexModel(ILogger<IndexModel> logger, Services.RandomUserService randomUserService)
    {
        _logger = logger;
        _randomUserService = randomUserService;
    }

    public void OnGet(int count = 10)
    {
        Usuarios = _randomUserService.GenerateUsers(count);
        _logger.LogInformation("Generados {Total} usuarios aleatorios", Total);
    }
}
