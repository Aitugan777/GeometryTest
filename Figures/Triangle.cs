using System;

namespace GeometryTest
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Создает треугольник
        /// </summary>
        /// <param name="side1">Первая длина стороны треугольника</param>
        /// <param name="side2">Вторая длина стороны</param>
        /// <param name="side3">Третья длина стороны</param>
        public Triangle(double side1, double side2, double side3) 
        { 
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new NotImplementedException(trowMessage);
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        string trowMessage = "Длина стороны не может быть меньше нуля!";
        double side1;
        public double Side1 
        { 
            get { return this.side1; }
            set 
            { 
                if (value <= 0)
                    Console.WriteLine(trowMessage);
                else
                    this.side1 = value;
            }
        }
        double side2;
        public double Side2
        {
            get { return this.side2; }
            set
            {
                if (value <= 0)
                    Console.WriteLine(trowMessage);
                else
                    this.side2 = value;
            }
        }

        double side3;
        public double Side3
        {
            get { return this.side3; }
            set
            {
                if (value <= 0)
                    Console.WriteLine(trowMessage);
                else
                    this.side3 = value;
            }
        }


        public double Square()
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        }

        /// <summary>
        /// Возвращает истину, если треугольник прямоугольный
        /// </summary>
        public bool IsRightAngleTriangle()
        {
            double[] sides = new double[] { side1, side2, side3 };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
