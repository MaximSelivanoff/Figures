namespace Figures
{
    abstract class Figures
    {
        public abstract double GetSquare();
        public Figures(params double[] lengths)
        {
            if(lengths== null)
                throw new ArgumentNullException(nameof(lengths));
            foreach(var l in lengths)
            {
                if (l <= 0)
                    throw new ArgumentException("Arguments or argument must be greater than 0\"");
            }
        }
    }
    class Circle: Figures
    {
        double radius;

        public Circle(double radius): base(radius)
        {
            this.radius = radius;
        }

        public override double GetSquare()
        {
            double square = Math.PI * radius * radius;
            return square;
        }
    }
    class Triangle : Figures
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
        public override double GetSquare()
        {
            double perimeter = (sideA * sideB + sideC) / 2;
            double square = (perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
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