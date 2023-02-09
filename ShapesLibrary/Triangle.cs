namespace ShapesLibrary
{
    public class Triangle: IShape
    {
        public double[] Sides { get; private set; }
        public double GetArea()
        {
            double p = (Sides[0]+ Sides[1]+Sides[2]) / 2; //halfPerimeter

            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        public bool IsRightTriangle()
        {
            double hypotenuse = Sides.Max();
            var catheti = Sides.Where(value => value != hypotenuse).ToArray();
            
            if (Math.Pow(hypotenuse, 2) == Math.Pow(catheti[0],2) + Math.Pow(catheti[1], 2))
            {
                return true;
            }
            return false;
        }
        public Triangle(double[] sides) 
        {
            if (sides == null || sides.Length != 3) throw new Exception("недопустимое количество сторон");
            bool allPositive = sides.All(value => value > 0);
            if (allPositive == false) throw new Exception("недопустимые значения сторон");
            Sides = sides; 
        }
    }
}
