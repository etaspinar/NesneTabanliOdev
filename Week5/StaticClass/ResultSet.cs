using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClas
{
    public static class ResultSet
    {
        public static  Result Action01()
        {
            return new Successed();
        }
        public static Result Action02()
        {
            return new Successed("Islem başariyla gerceklesti");
        }
        public static Result Action03()
        {
            return new Failed();
        }
        
        public static Result Action04()
        {
            return new Failed("Islem basarisiz gerceklesti");
        }

    }
}
