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
        private double re { get; }
        private double im { get; }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        private double Square(double n)
        {
            return n * n;
        }

        public double Modulus => System.Math.Sqrt(Square(re) + Square(im));

        public double Phase => System.Math.Atan2(re, im);

        public Complex Complement => new Complex(re, -im);

        public Complex Sum(Complex a) => new Complex(this.re + a.re, this.im + a.im);
        public Complex Sub(Complex a) => new Complex(this.re - a.re, this.im - a.im);

        public override string ToString()
        {
            return re + im;
        }
    }
}