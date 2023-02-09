namespace ShapesLibrary
{
    public class Circle: IShape
    {
        public double Radius { get; private set; }

        public double GetArea() 
        {
            return Math.PI * Math.Pow(Radius, 2); 
        }
        public Circle(double radius) 
        {
            if (radius <= 0) throw new Exception("недопустимое значение для радиуса");
            Radius = radius;
        }
    }
}
