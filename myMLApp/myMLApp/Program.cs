using myMLApp;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("This application will try to predict if a given review is positive or negative.");
Console.WriteLine("Input review:");

//Get review from console input
Console.ForegroundColor = ConsoleColor.DarkYellow;
string? input = Console.ReadLine();
if (input == null)
{
    return;
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.Write("Analyzing...");

//Create review object
Review review = new Review(input);
Console.WriteLine(" Done!");
Console.WriteLine("");


//Write result
Console.Write("Review is determined to be: ");

if (review.IsPositive)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("  POSITIVE  ");
} else {
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("  NEGATIVE  ");
}

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
