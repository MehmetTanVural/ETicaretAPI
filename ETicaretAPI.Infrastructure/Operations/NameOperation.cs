using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure.Operations
{
    public static class NameOperation
    {
        public static string CharacterRegulatory(string name)

          => name.Replace("'\'", "")
            .Replace("!", "")
            .Replace("'", "")
            .Replace("^", "")
            .Replace("+", "")
            .Replace("%", "")
            .Replace("&", "")
            .Replace("/", "")
            .Replace("(", "")
            .Replace(")", "")
            .Replace("=", "")
            .Replace("?", "")
            .Replace("-", "")
            .Replace("", "")
            .Replace("@", "")
            .Replace("£", "")
            .Replace(";", "")
            .Replace(":", "")
            .Replace(".", "-")
            .Replace("Ö", "o")
            .Replace("ö", "o")
            .Replace("Ü", "u")
            .Replace("ü", "u")
            .Replace("ı", "i")
            .Replace("I", "i")
            .Replace("ğ", "g")
            .Replace("Ğ", "g")
            .Replace("ş", "s")
            .Replace("Ş", "s")
            .Replace("Ç", "c")
            .Replace("<", "")
            .Replace(">", "")
            .Replace("|", "");



    }
}
