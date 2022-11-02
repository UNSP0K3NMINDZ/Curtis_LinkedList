using Curtis_LinkedList;

// NAME: Micah Curtis  
// COURSE: IT113
// Behaviors Not Implemented: The Remove and Contains functions are empty and the program will do nothing but give a menu
ConsoleKeyInfo input;
LinkedList MyList = new LinkedList();
Menu();

do
{
    input = Console.ReadKey();
    if (input.Key == ConsoleKey.D1)
    {
        //Add
    }
    else if (input.Key == ConsoleKey.D2)
    {
        //Remove
    }
    else if (input.Key == ConsoleKey.D3)
    {
        //Search
    }
    else if (input.Key == ConsoleKey.D4)
    {
        //Print
    }
    else
    {
        Console.Clear();
    }
    Menu();
} while (input.Key != ConsoleKey.D5);

static void Menu()
{
    Console.WriteLine("");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Remove");
    Console.WriteLine("3. Search");
    Console.WriteLine("4. Print");
    Console.WriteLine("5. Exit");
}
