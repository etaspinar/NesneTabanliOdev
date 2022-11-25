using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClas
{
    public class Successed : Result
    {
        public Successed() : base(true, "Succassed")
        {

        }

        public Successed(string message) : base(true, message)
        {

        }
    }
}
