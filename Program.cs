
Console.WriteLine("Enter an integer between 1 and 100: ");
try
{
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine("Specify the series type: (Even or Odd) ");
    string series = Console.ReadLine();

    if (series == "Odd" || series == "odd")
    {
        Console.WriteLine("You have selected " + series + " series. The numbers odd between 0 and " + input + " are:");
        for (int i = 0; i <= input; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }

    if (series == "Even" || series == "even")
    {
        Console.WriteLine("You have selected " + series + " series. The even numbers between 0 and " + input + " are:");
        for (int i = 0; i <= input; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
}

catch
{
    Console.WriteLine("Please enter an integer between 1 and 100: ");
}