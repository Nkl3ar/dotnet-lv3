namespace PasswordGen.Models;
public static class PasswordCheck{
    public static string PasswordCheckFunc(string password)
    {
        bool hasUpper = false;
        bool hasLower = false;
        for(int i = 0; i<password.Length; i++)
        {
            if(Char.IsUpper(password[i]))
            {
                hasUpper = true;
            }
            else if(Char.IsLower(password[i]))
            {
                hasLower = true;
            }
            

            if(hasLower && hasUpper)
                i=password.Length;
        }
        if(password.Length <= 8)
            return "Lozinka nije dovoljno dugačka";
        if(!hasLower)
            return "Lozinka nema ikakva mala slova";
        if(!hasUpper)
            return "Lozinka nema ikakva velika slova";
            
        return "Lozinka je dobra";
    }
}