using System;

namespace GeometryTest
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Создает круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new NotImplementedException(trowMessage);
            this.radius = radius;
        }

        string trowMessage = "Радиус должен быть больше нуля!";
        double radius;

        public double Radius 
        { 
            get => radius; 
            set
            {
                if (radius <= 0)
                    Console.WriteLine(trowMessage);
                else
                    radius = value;
            } 
        }

        public double Square()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
