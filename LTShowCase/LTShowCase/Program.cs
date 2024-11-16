namespace LTShowCase;

public static class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the amount of money (e.x. 19.99): ");
        
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount >= 0)
        {
            var change = ExactChangeExercise.CalculateChange(amount);
            Console.WriteLine("\nChange breakdown:");
            foreach (var line in change)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive value like the example provided: '19.99'.");
        }
    }
}