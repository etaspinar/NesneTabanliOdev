using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        //public void Draw()
        //{
        //    Console.WriteLine($"Shape {X},{Y}");
        //}
        public virtual void Draw()
        {
            Console.WriteLine($"Shape {X},{Y}");
        }
        public virtual void triangle()
        {
            Console.WriteLine($"Rectangle {X},{Y}");
        }

        protected  void calcarea()
        {
            X = 10;
            Y = 15;
        }
        private int A = 12;
    }
     
}   
