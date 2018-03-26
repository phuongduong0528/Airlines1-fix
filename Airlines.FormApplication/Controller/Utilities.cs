using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.FormApplication.Controller
{
    class Utilities
    {
        public static string ToHashString(string str)
        {
            byte[] b = Encoding.UTF8.GetBytes(str);
            MD5 val = MD5.Create();
            byte[] hb = val.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            foreach (byte x in hb)
            {
                sb.Append(x.ToString("X2").ToLower());
            }
            return sb.ToString();
        }
    }
}
