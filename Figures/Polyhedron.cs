using System;

namespace GeometryTest
{
    /// <summary>
    /// Многоугольник
    /// </summary>
    internal class Polyhedron : IShape
    {
        /// <summary>
        /// Создание многогранника по массиву длин сторон
        /// </summary>
        /// <param name="sides">Минимум должно быть 4 элемента в массиве (элемент массива - длина стороны)</param>
        /// <exception cref="NotImplementedException"></exception>
        public Polyhedron(double[] sides) 
        {
            if (sides.Length <= 3)
                throw new NotImplementedException(trowMessage);
            this.sides = sides;
        }

        string trowMessage = "У многогранника должен быть минимум 4 стороны!";

        double[] sides;

        public double[] Sides { get { return sides; }
            set
            {
                if (value.Length <= 3)
                    Console.WriteLine(trowMessage);
                else
                    sides = value;
            }
        }

        public double Square()
        {
            double a = sides.Length; //Кол-во сторон

            double a1 = (double)a / 4;

            double a2 = Math.Pow((Pyrimeter() / a), 2);

            double a3 = Math.Tan(Math.PI / a);

            return a1 * a2 / a3;
        }

        /// <summary>
        /// Возвращает пириметр многогранника
        /// </summary>
        /// <returns></returns>
        public double Pyrimeter()
        {
            double sum = 0;
            Array.ForEach(sides, i => sum += i);
            return sum;
        }
    }
}
