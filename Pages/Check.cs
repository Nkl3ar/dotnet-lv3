using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;

namespace PasswordGen.Pages;

public class CheckModel : PageModel
{
    public string PasswordQuality {get; set;}
    private readonly ILogger<CheckModel> _logger;

    public CheckModel(ILogger<CheckModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        PasswordQuality = "";
    }
}

