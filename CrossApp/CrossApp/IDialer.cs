using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossApp
{
    public interface IDialer
    {
        bool Dial(string number);
    }
}
