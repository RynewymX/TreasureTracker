// Initial data structures

List<string> treasures  = new List<string>();
Dictionary<string, int> treasureQuantity = new Dictionary<string, int>();
Dictionary<string, int> treasureValue = new Dictionary<string, int>();

// User "Interface" (as much of one as you can get for a console app)
while (true)
{
    Console.WriteLine("\nChoose an option:");
    Console.WriteLine("1. Add a treasure");
    Console.WriteLine("2. Update inventory");
    Console.WriteLine("3. Display inventory");
    Console.WriteLine("4. Quit");

    string choice = Console.ReadLine();

    if (choice == "4")
    {
        Console.WriteLine("Goodbye.");
        break;
    }

    // Code to handle user choices
    // Add new treasure
    if (choice == "1")
    {
        Console.WriteLine("Enter the name of your treasure: ");
        string name = Console.ReadLine();

        if (treasureQuantity.ContainsKey(name))
        {
            Console.WriteLine($"{name} already exists in your inventory.");
        }
        else
        {
            Console.Write("Enter the quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter the value per unit: ");
            int value = int.Parse(Console.ReadLine());

            treasures.Add(name);
            treasureQuantity[name] = quantity;
            treasureValue[name] = value;

            Console.WriteLine($"{name} added to your inventory.");
        }
    }

    // Updating treasure
    else if (choice == "2")
    {
        Console.Write("Enter the name of the treasure to update: ");
        string name = Console.ReadLine();

        if (treasureQuantity.ContainsKey(name))
        {
            Console.Write("Enter the new quantity: ");
            int newQuantity = int.Parse(Console.ReadLine());

            Console.Write("Enter the new value per unit: ");
            int newValue = int.Parse(Console.ReadLine());

            treasureQuantity[name] = newQuantity;
            treasureValue[name] = newValue;

            Console.WriteLine($"{name} has been updated.");
        }
        else
        {
            Console.WriteLine("Treasure not found in inventory.");
        }
    }

    // Viewing inventory
    else if (choice == "3")
    {
        foreach (var name in treasures)
        {
            Console.WriteLine($"Name: {name}, Quantity: {treasureQuantity[name]}, Value per Unit: {treasureValue[name]}");
        }
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}