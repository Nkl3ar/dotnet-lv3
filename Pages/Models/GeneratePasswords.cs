using System.Text;

namespace PasswordGen.Models;
public static class GeneratePasswords{
    public static string CreatePassword(int length, bool symbols, bool upper, bool lower, bool number)
    {
        
            String valid = "";
            if(symbols)
            {
                valid+="!#$%&/()=?*;:_,.-<>~ˇ^˘°˛`˙´˝¨";
            }
            if(upper)
            {
                valid+="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if(lower)
            {
                valid+="abcdefghijklmnopqrstuvwxyz";
            }
            if(number)
            {
                valid+="1234567890";
            }
            StringBuilder res = new StringBuilder();
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
    }

}