var numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Console.WriteLine("Enter bonus amount:");
var bonus = int.Parse(Console.ReadLine());

Console.WriteLine("Write sanction amount:");
var sanction = int.Parse(Console.ReadLine());

var numberOfBonuses = 0;
var numberOfSanctions = 0;
var balance = 0;
var max = int.MinValue;

for (int i = 0; i < 12; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
        numberOfBonuses++;
    }
    else
    {
        numberOfSanctions++;
    }

    balance += numbers[i] + (numberOfBonuses - 1) * bonus - (numberOfSanctions * sanction);
}

Console.WriteLine($"Number of bonuses: {numberOfBonuses}");
Console.WriteLine($"Number of sanctions: {numberOfSanctions}");
Console.WriteLine($"Final balance: {balance}");
