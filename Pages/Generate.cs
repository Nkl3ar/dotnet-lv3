using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PasswordGen.Pages;
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

    }
    public void OnPost(int passlen, int passwordcount, bool symbols = false, bool upper = false, bool lower = false, bool digits = false)
    {
        if(symbols || upper || lower || digits){
        for(int i = 0; i<passwordcount; i++)
        {
            Passwords.Add(GeneratePasswords.CreatePassword(passlen,symbols,upper,lower,digits));
        }
        }
    }
}

