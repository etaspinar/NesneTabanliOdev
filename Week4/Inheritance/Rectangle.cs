using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Rectangle:Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Rectangle {0} {1}",X,Y);
        }
        
    }
}
