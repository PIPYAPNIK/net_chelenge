using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class GraphicEditor
    {
        public List<Shape> _figures = new List<Shape>();

        public void AddFigure(Shape figure)
        {
            _figures.Add(figure);
        }

        public void DeleteFigure(int id)
        {
            _figures.RemoveAt(id);
        }

        public void MovePosition(int id, double x, double y)
        {
            _figures[id].Move(x, y);
        }

        public double SumAreas()
        {
            double areas = 0;
            foreach (Shape figure in _figures)
            {
                areas += figure.AreaCalculation();
            }

            return areas;
        } 

        public void InfoFigures()
        {
            for (int i = 0; i < _figures.Count; i++)
            {
                int id = i;
                double area = _figures[id].AreaCalculation();
                string position = _figures[id].GetPosition();

                Console.WriteLine($"Element id - {id}, position = {position}, area = {area}");
            }
        }
    }
}
