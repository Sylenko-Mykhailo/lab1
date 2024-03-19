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
        public static void Main(string[] args)
        {
            
        }
    }
}