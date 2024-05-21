using KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Pizza>();
var validToppings = new List<string> { "sausage", "pepperoni", "cheese", "mushrooms", "olives" }; // add new toppings here

for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var pizza = new Pizza();

    Console.WriteLine("Enter the price of the pizza");
    pizza.price = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter the amount of calories");
    pizza.calories = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Enter the style of pizza");
    pizza.style = Console.ReadLine();
    
    Console.WriteLine("Enter the size of the pizza in inches");
    pizza.size = int.Parse(Console.ReadLine());

    bool validToppingsEntered = false;
    while (!validToppingsEntered)
    {
        Console.WriteLine($"Enter your toppings (available options: {string.Join(", ", validToppings)})");
        string toppingsInput = Console.ReadLine();

        string[] enteredToppings = toppingsInput.Split(',');

        bool allToppingsValid = enteredToppings.All(topping => validToppings.Contains(topping.Trim()));

        if(allToppingsValid)
        {
            pizza.toppings = toppingsInput;
            validToppingsEntered = true;
        }
        else
        {
            Console.WriteLine("One or more toppings are invalid. Please try again, and seperate the toppings with a comma.");
        }
    }


    recordList.Add(pizza);
}

// Print out the list of records using Console.WriteLine()

foreach (var record in recordList)
{
    Console.WriteLine(record.ToString());
}