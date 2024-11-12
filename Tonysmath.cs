using System.Numerics;
namespace Tonysmath
{
    class StandardOperations
    {
        public static BigInteger Power(BigInteger x, BigInteger y)
        {
            if (x == 0 && y == 0) return 0;
            if (y == 0) return 1;
            BigInteger initial = x;
            for (int i = 1; i < y; i++)
            {
                x *= initial;
            }
            return x;
        }
        public static BigInteger Factorial(BigInteger n)
        {
            if (n < 0) throw new ArgumentException("Factorial of a negative number is undefined.");
            if (n == 0)
            {
                return 1;
            }
            BigInteger k = n;
            for (int i = 1; i < k; i++)
            {
                n = n * (k - i);
            }
            return n;
        }
    }
    class MatrixOperations
    {
        public static int[,] Multiply(int[,] m1, int[,] m2)
        {
            if (m1.GetLength(1) != m2.GetLength(0))
            {
                throw new ArgumentException("Dimension error exception. Dimension of the matricies dont match.");
            }
            int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];
            int sum;
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(0); j++)
                {
                    sum = 0;
                    for (int k = 0; k < m2.GetLength(1); k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }
        public static int[,] Add(int[,] m1, int[,] m2)
        {
            if (m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
            {
                throw new ArgumentException("Dimension error exception. Dimension of the matricies dont match.");
            }
            int[,] result = new int[m1.GetLength(0), m1.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }
        public static int[,] Subtract(int[,] m1, int[,] m2)
        {
            if (m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
            {
                throw new ArgumentException("Dimension error exception. Dimension of the matricies dont match.");
            }
            int[,] result = new int[m1.GetLength(0), m1.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }
        public static int[,] Divide(int[,] m1, int[,] m2)
        {
            if (m1.GetLength(1) != m2.GetLength(0))
            {
                throw new ArgumentException("Dimension error exception. Dimension of the matricies dont match.");
            }
            int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];
            int sum;
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(0); j++)
                {
                    sum = 0;
                    for (int k = 0; k < m2.GetLength(1); k++)
                    {
                        sum += m1[i, k] * (1 / m2[k, j]);
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }
        public static int[,] PlaceHolder(int[,] m1, int[,] m2)
        {
            int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];
            return result;
        }
    }
}
