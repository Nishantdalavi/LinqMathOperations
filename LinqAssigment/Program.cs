namespace LinqAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "10", "5", "100", "30", "50", "abc", "pqr" };
            var numericStrings = numbers.Where(x => int.TryParse(x, out int n));
            var numericValues = numericStrings.Select(x => int.Parse(x));

            if (numericValues.Any())
            {
                int maxNum = numericValues.Max();
                int minNum = numericValues.Min();
                int secondMax = numericValues.OrderByDescending(n => n).Skip(1).FirstOrDefault();
                int sumOf = numericValues.Sum();
                Console.WriteLine($"Maximum number is {maxNum}");
                Console.WriteLine($"Minmum number is {minNum}");
                Console.WriteLine($"Second maximum number is {secondMax}");
                Console.WriteLine($"Sum of numbers are {sumOf}");

                var descendingNum = numericValues.OrderByDescending(n => n);
                foreach (var n in descendingNum)
                {
                    Console.Write(" "+n);
                }
            }
            
        }

    }
}
