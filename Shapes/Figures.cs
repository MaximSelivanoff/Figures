namespace Figures
{
    public abstract class Figure
    {
        public abstract double GetArea();
        public Figure(params double[] lengths)
        {
            if(lengths== null)
                throw new ArgumentNullException(nameof(lengths));
            foreach(var l in lengths)
            {
                if (l <= 0)
                    throw new ArgumentException("Argument must be greater than 0\"");
            }
        }
    }
    public class Circle: Figure
    {
        double radius;

        public Circle(double radius): base(radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            double square = Math.PI * radius * radius;
            return square;
        }
    }
    public class Triangle : Figure
    {
        double sideA;
        double sideB;
        double sideC;
        public Triangle(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public override double GetArea()
        {
            double perimeter = (sideA + sideB + sideC) / 2;
            double square = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
            return square;
        }
        public bool IsRight()
        {
            if (sideC > sideA && sideC > sideA)
            {
                return isRightCheck(sideA, sideB, sideC);
            }
            if (sideB > sideA && sideB > sideC)
            {
                return isRightCheck(sideA, sideC, sideB);
            }
            return isRightCheck(sideB, sideC, sideA);
        }
        private bool isRightCheck(double cathet1, double cathet2, double hypotenuse)
        {
            double compare1 = Math.Sqrt((cathet1 * cathet1) + (cathet2 * cathet2));
            double compare2 = Math.Sqrt(hypotenuse * hypotenuse);
            if (compare1 == compare2)
                return true;
            return false;
        }
    }
}