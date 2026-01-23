using ConsoleApp1;

static void PrintShapeInfo(Shape shape)
{
  string shapeType = shape.GetType().Name;
  double area = shape.Area();
  double perimeter = shape.Perimeter();
  if (shape.Try() && area != 0 && perimeter != 0)
  {
    Console.WriteLine($"Фигура {shapeType} имеет площадь {area} и периметр {perimeter}");
  }
  else
    Console.WriteLine($"Что-то пошло не так с {shape.GetType().Name}");
}

  Circle circle = new Circle(3);
  Rectangle rectangle = new Rectangle(2, 9);
  Triangle triangle = new Triangle(3, 4, 5);
  Triangle wrongTriangle = new Triangle(5, 0, 3);
  
  PrintShapeInfo(circle);
  PrintShapeInfo(rectangle);
  PrintShapeInfo(triangle);
  PrintShapeInfo(wrongTriangle);

