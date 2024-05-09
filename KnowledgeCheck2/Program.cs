using KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Pizza>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var pizza = new Pizza();

    Console.WriteLine("Enter the price of the pizza");
    pizza.price = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the amount of calories");
    pizza.calories = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the size of the pizza in inches");
    pizza.size = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the toppings for example sausage, pepperoni, green peppers etc");
    pizza.toppings = Console.ReadLine();
    Console.WriteLine("Enter the style of pizza");
    pizza.style = Console.ReadLine();


    recordList.Add(pizza);
}

// Print out the list of records using Console.WriteLine()

foreach (var record in recordList)
{
    Console.WriteLine(record.ToString());
}