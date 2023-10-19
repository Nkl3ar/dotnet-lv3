using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PasswordGen.Pages;
using PasswordGen.Models;
public class GenerateModel : PageModel
{
    private readonly ILogger<GenerateModel> _logger;

    public List<string> Passwords {get; set;}
    public GenerateModel(ILogger<GenerateModel> logger)
    {
        _logger = logger;
        Passwords = new List<string>();
    }

    public void OnGet()
    {
        string pass = "test";
        Passwords.Add("te4st");
        
    }
}

