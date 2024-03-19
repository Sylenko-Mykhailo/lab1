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
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
        public static void Main(string[] args)
        {
            
        }
    }
}