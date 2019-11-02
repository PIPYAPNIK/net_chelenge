using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(10, 50, 8);
            Circle circle = new Circle(80, 23, 60);
            Square square = new Square(12, 35, 65);
            Triangle triangle = new Triangle(34, 65, 32, 34, 89);

            GraphicEditor graphic = new GraphicEditor();
            graphic.AddFigure(line);
            graphic.AddFigure(circle);
            graphic.AddFigure(square);
            graphic.AddFigure(triangle);

            Console.WriteLine(graphic.SumAreas());
            graphic.InfoFigures();
            graphic.DeleteFigure(2);
            Console.WriteLine();
            Console.WriteLine(graphic.SumAreas());
            graphic.InfoFigures();

            Console.ReadKey();

        }
    }
}
