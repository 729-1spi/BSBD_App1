using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BSBD_App
{
     public class ClassMD5
    {
           
       public  string hashPassword(string password)
        {
           var mD5 = MD5.Create();
           
           byte[] b = Encoding.ASCII.GetBytes(password);
           byte[] hash = mD5.ComputeHash(b);
           
           StringBuilder sb = new StringBuilder();
           foreach (var a in hash)
               sb.Append(a.ToString("X2"));
           
           return Convert.ToString(sb);
        }
    }
}
