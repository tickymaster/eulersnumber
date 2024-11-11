using System.Numerics;
using System.Runtime.CompilerServices;

class Tonysmath
{
    public static BigInteger power(BigInteger x, BigInteger y)
    {
        if (x == null! || y == null!) throw new ArgumentNullException("Null exception.");
        if (x == 0 && y == 0) return 0;
        if (y == 0) return 1;
        BigInteger initial = x;
        for (int i = 1; i < y; i++)
        {
            x *= initial;
        }
        return x;
    }
    public static BigInteger factorial(BigInteger n)
    {
        if (n < 0) throw new ArgumentException("Factorial of a negative number is undefined.");
        if (n == 0)
        {
            return 1;
        }
        BigInteger k = n;
        for(int i = 1; i < k; i++)
        {
            n = n * (k - i);
        }
        return n;
    }
    //public static void Main()
    //{
    //    BigInteger x = 4;
    //    Console.WriteLine(power(x, x));
    //    Console.WriteLine(factorial(x));
    //}
}
class Euler
{
    public static void Main()
    {
        eulersnum(2000, 15); // accuracy and power of the number
    }
    public static void eulersnum(int accuracy, int power)
    {
        BigInteger e = 0;
        for (int n = 0; n < accuracy; n++)
        {
            //Console.WriteLine((Tonysmath.power(power, n)) + "/" + Tonysmath.factorial(n));
            e += Tonysmath.power(power, n)/Tonysmath.factorial(n);
            Console.WriteLine("Iteration: " + n + ", Euler's number: " + e);
        }
        Console.WriteLine("Euler's number raised to the power of: " + power + " is: " + e);
    }
}
