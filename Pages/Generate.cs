﻿using Microsoft.AspNetCore.Mvc;
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
        for(int i = 0; i<10; i++)
        {
            Passwords.Add(GeneratePasswords.CreatePassword(10));
        }
        
    }
}

