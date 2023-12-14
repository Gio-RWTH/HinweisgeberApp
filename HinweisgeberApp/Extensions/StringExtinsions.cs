using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinweisgeberApp.Extensions
{
    public static class StringExtinsions
    {
        public static string ToPartnerConString(this byte[] bdb)
        {
            char[] chars = Encoding.Unicode.GetChars(bdb);
            string pconstr = string.Empty;
            for (int j = 0; j < chars.Length; j++)
            {
                pconstr += chars[j];
            }
            string res = pconstr;
            return res;
        }

        public static byte[] ToPartnerConString(this string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            return bytes;
        }
    }
}
