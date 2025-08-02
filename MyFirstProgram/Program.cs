NickCoolCalculator calculator = new(
    "Welcome to Nick's Cool Calculator!");
calculator.Start();


public sealed class NickCoolCalculator
{
    private string _greeting;
    public NickCoolCalculator(string greeting)
    {
        _greeting = greeting;
    }
    
    public string Start()
    {
        Console.WriteLine(_greeting);

        Dictionary<string, string> supportedOperators = new()
        {
            { "*", "Add" },
            { "/", "Divide" }
        };

        while (true)
        {
            Console.WriteLine("Operator choices are as follows:");
            foreach (var op in supportedOperators)
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }
            Console.WriteLine("Enter an operator:");
            string operatorChoice = Console.ReadLine();

            if (!supportedOperators.TryGetValue(
                operatorChoice,
                out var selectedOperatorDescription))
            {
                Console.WriteLine("Invalid operator choice.");
                continue;
            }

            Console.WriteLine($"You selected: {selectedOperatorDescription}");
            Console.WriteLine();

            Console.WriteLine($"Recall that integers are on the range" +
                $"{int.MinValue} to {int.MaxValue}");
            Console.WriteLine();

            Console.WriteLine("Enter the first integer:");
            string firstNumberInput = Console.ReadLine();
            if (!int.TryParse(firstNumberInput, out int firstNumber))
            { 
                Console.WriteLine($"{firstNumberInput} could not be parsed as an integer!");
                continue;
            }

            Console.WriteLine("Enter the secound integer:");
            string secoundNumberInput = Console.ReadLine();
            if (!int.TryParse(secoundNumberInput, out int secoundNumber))
            {
                Console.WriteLine($"{secoundNumberInput} could not be parsed as an integer!");
                continue;
            }

            int result;
            try
            {
                result = operatorChoice switch
                {
                    "*" => firstNumber * secoundNumber,
                    "/" => firstNumber / secoundNumber,
                    _ => throw new NotSupportedException(
                        $"Arithmetic is not currently suppoerted" +
                        $"for operator {operatorChoice}.")
                };
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
                continue;
            }
            catch (Exception ex) {
                Console.WriteLine($"There was an unhandled exception: {ex.Message}");
                continue;
            }

            Console.WriteLine($"This result is: {result}");
        }
    }
}