using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double Real, double Imaginary)
        {
            this.Real = Real;
            this.Imaginary = Imaginary;
        }

        private double Square(double n)
        {
            return n * n;
        }

        public double Modulus => System.Math.Sqrt(Square(Real) + Square(Imaginary));

        public double Phase => System.Math.Atan2(Imaginary, Real);

        public Complex Complement() => new Complex(Real, -Imaginary);

        public Complex Plus(Complex a) =>
            new Complex(this.Real + a.Real, this.Imaginary + a.Imaginary);
        public Complex Minus(Complex a) =>
            new Complex(this.Real - a.Real, this.Imaginary - a.Imaginary);

        private bool Equals(Complex a) => this.Real.Equals(a.Real) && this.Imaginary.Equals(a.Imaginary);

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(obj == this)
            {
                return true;
            }
            if(obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Complex)obj);
        }

        public override string ToString()
        {
            if (Imaginary == 0)
            {
                return ($"{Real}");
            }
            if (Real == 0)
            {
                if (Imaginary == 1)
                {
                    return ("i");

                }
                if (Imaginary == -1)
                {
                    return ("-i");
                }
                else {
                    return ($"{Imaginary}");
                }
            }
            if (Imaginary == 1)
            {
                return ($"{Real} + i");
            }
            if (Imaginary == -1)
            {
                return ($"{Real} - i");
            }
            return ($"{Real} {Imaginary}i");
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imaginary);
        }
    }
}