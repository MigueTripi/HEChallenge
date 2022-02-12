using HE.Challenge;

Console.WriteLine("Hi code reviewer!");
var calculator = new NumberCalculator();
do
{
    Console.WriteLine("Please enter first array of integer numbers (format example: 1,2,300 ): ");
    var arrayXInput = Console.ReadLine();
    var validArrayXInput = InputValidator.TryParseArray(arrayXInput, out int[]? arrayX);

    Console.WriteLine("Please enter second array of integer numbers (format example: 1,2,300 ): ");
    var arrayYInput = Console.ReadLine();
    var validArrayYInput = InputValidator.TryParseArray(arrayYInput, out int[]? arrayY);

    if (validArrayXInput && validArrayYInput)
    {
        var result = calculator.SumValuesFromArraysReversingSecond(arrayX, arrayY);
        if (result == null)
        {
            Console.WriteLine("The sum did not return data");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: [{string.Join(',', result)}]");
        }
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter data with the valid format");
    }

    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("Enter Y to calculate another set of values?");

} while (Console.ReadLine() == "Y");

Console.WriteLine("GoodBye!!!");



