namespace ConsoleApplication1
{
    internal class Program
    {
        public static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return (double)sum / numbers.Length;
        }
        public static int FindMax(int[] numbers)
        {
            int m = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > m)
                {
                    m = numbers[i];
                }
            }

            return m;
            int ma = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > ma)
                {
                    ma = numbers[i];
                }
            }

            return ma;
        }
        public static void Main(string[] args)
        {
            
        }
    }
}