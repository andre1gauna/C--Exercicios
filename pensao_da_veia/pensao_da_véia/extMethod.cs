using System;
using System.Collections.Generic;
using System.Text;

namespace pensao_da_véia
{
    public static class extMethod
    {
        public static string Change(this string input)
        {
            
            char[] charArray = input.ToCharArray();
            charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
            return new string(charArray) ;
            
        }
    }
}
