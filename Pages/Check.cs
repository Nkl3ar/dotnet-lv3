using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;

namespace PasswordGen.Pages;

public class CheckModel : PageModel
{
    public string passwordQuality {get; set;}
    private readonly ILogger<CheckModel> _logger;

    public CheckModel(ILogger<CheckModel> logger)
    {
        _logger = logger;
        passwordQuality = "";
    }

    public void OnGet()
    {
    }
    public void OnPost(string password)
    {
        passwordQuality = PasswordCheck.PasswordCheckFunc(password);
    }
    
}

