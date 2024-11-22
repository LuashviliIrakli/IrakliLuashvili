namespace TenHomework
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            _numerator = numerator;
            _denominator = denominator;
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int commonDenominator = f1._denominator * f2._denominator;
            int newNumerator = f1._numerator * f2._denominator + f2._numerator * f1._denominator;

            return new Fraction(newNumerator, commonDenominator);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1._numerator * f2._denominator == f2._numerator * f1._denominator;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction)
            {
                Fraction other = (Fraction)obj;
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (_numerator, _denominator).GetHashCode();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 3);
            Fraction fraction3 = new Fraction(1, 2);

            Console.WriteLine($"fraction1: {fraction1.ToString()}");
            Console.WriteLine($"fraction2: {fraction2.ToString()}");

            Fraction sum = fraction1 + fraction2;
            Console.WriteLine($"Sum: {sum.ToString()}");

            Console.WriteLine($"fraction1 == fraction2: {fraction1 == fraction2}");
            Console.WriteLine($"fraction1 == fraction3: {fraction1 == fraction3}");

            Console.WriteLine($"fraction1 != fraction2: {fraction1 != fraction2}");
            Console.WriteLine($"fraction1 != fraction3: {fraction1 != fraction3}");
        }
    }
}
