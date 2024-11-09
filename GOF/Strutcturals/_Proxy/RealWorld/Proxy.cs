namespace GOF.Strutcturals._Proxy.RealWorld
{
    public interface IMath
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    }

    public class Math : IMath
    {
        public double Add(double x, double y) => x + y;
        public double Divide(double x, double y) => x / y;
        public double Multiply(double x, double y) => x * y;
        public double Subtract(double x, double y) => x - y;
    }

    public class MathProxy : IMath
    {
        Math math = new Math();

        public double Add(double x, double y) => math.Add(x, y);
        public double Divide(double x, double y) => math.Divide(x, y);
        public double Multiply(double x, double y) => math.Multiply(x, y);
        public double Subtract(double x, double y) => math.Subtract(x, y);
    }
}
