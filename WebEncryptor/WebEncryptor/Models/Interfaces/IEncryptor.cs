using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEncryptor.Interfaces
{
    interface IEncryptor
    {
        string Encrypt(string msg);
    }
}
