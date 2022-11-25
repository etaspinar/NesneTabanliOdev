using Inheritance;

//Shape shape = new Shape() { X = 12, Y = 5 };
var shape = new Shape();
shape.X = 12;
shape.Y = 5;
//shape.Draw();

var rectangle = new Rectangle() { X = 8 , Y =25};
var triangle = new Triangle() { X = 8 , Y =25};

//rectangle.Draw();
//triangle.Draw();

List<Shape> list = new List<Shape>();
list.Add(shape);
list.Add(rectangle);
list.Add(triangle);

foreach (var item in list)
{
    item.Draw();
}