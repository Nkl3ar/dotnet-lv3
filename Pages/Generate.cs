using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PasswordGen.Pages;

public class GenerateModel : PageModel
{
    private readonly ILogger<GenerateModel> _logger;

    public GenerateModel(ILogger<GenerateModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

