bool restart = true;
do
{
    //intro
    Console.WriteLine("Learn your squares and cubes!");
    Console.WriteLine("Enter an integer\n");
    int num = int.Parse(Console.ReadLine());

    //validator
    if (num >= 1 && num <= 1290)
    {
        //table
        Console.WriteLine("" +
                "Number\t\tSquare\t\tCube\n" +
                "======\t\t======\t\t======\n");
        for (int x = 1; x <= num; x++)
        {
            Console.WriteLine("" +
                x + "\t\t" + (x * x) + "\t\t" + (x * x * x));
        }
        //repeat?
        Console.WriteLine("Would you like to try again? y/n");
        string userChoice = Console.ReadLine();
        if (userChoice == "y" || userChoice == "yes")
        {
            restart = true;
        }
        else if (userChoice == "n" || userChoice == "no")
        {
            restart = false;
        }
    }
    //chose incorrect values from if above
    else
    {
        Console.WriteLine("Please enter valid number");
    }
} while (restart == true);
Console.WriteLine("Goodbye!");
