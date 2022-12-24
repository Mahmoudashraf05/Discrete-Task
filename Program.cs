Console.WriteLine("Please enter the starting number of range");
int startingNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the ending number of range");
int endingNumber = int.Parse(Console.ReadLine());

Console.WriteLine("The prime numbers between " + startingNumber + " and " + endingNumber + " are");

for (int i = startingNumber; i <= endingNumber; i++)
{
    int count = 0;

    for (int l = 2; l <= i / 2; l++)
    {
        if (i % l == 0)
        {
            count++;
            break;
        }
    }
    if (count == 0 && i != 0)
    {
        Console.WriteLine(i);
    }
}
Console.ReadKey();