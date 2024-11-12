using System.Numerics;
using Tonysmath;
class Euler
{
    public static void Main()
    {
        Eulersnum(2000, 15); // accuracy and power of the number
    }
    public static void Eulersnum(int accuracy, int power)
    {
        BigInteger e = 0;
        for (int n = 0; n < accuracy; n++)
        {
            //Console.WriteLine((Tonysmath.power(power, n)) + "/" + Tonysmath.factorial(n));
            e += StandardOperations.Power(power, n)/ StandardOperations.Factorial(n);
            Console.WriteLine("Iteration: " + n + ", Euler's number: " + e);
        }
        Console.WriteLine("Euler's number raised to the power of: " + power + " is: " + e);
    }
}
    