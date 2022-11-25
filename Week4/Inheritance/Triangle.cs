using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Triangle : Shape
    {
         new public void Draw() // bu new ile oluşturulan metod shape clas ındaki Draw metodunu gizledi.Birnevi önceki oluşturulan override gibi geçersiz kıldı.
        {
            Console.WriteLine($"Triangle {X},{Y}");
        }
    }
}
