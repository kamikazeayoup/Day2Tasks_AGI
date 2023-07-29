using ShapeInterface;

Circle cir = new Circle(4);
cir.CalculateArea();
Console.WriteLine(cir.GetArea());

Triangle triangle = new Triangle(7, 6);
triangle.CalculateArea();
Console.WriteLine(triangle.GetArea());

Square square = new Square(4);
square.CalculateArea();
Console.WriteLine(square.GetArea());