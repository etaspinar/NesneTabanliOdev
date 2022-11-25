using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClas
{
    public class Failed : Result
    {
        public Failed() : base(false,"Failed!")
        {

        }
        public Failed(string message) : base(false, message)
        {

        }
    }
}
