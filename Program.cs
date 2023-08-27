// create and fill preexisting three string arrays.
string[] incomeArray = new string[3];
for (int i = 0; i < 3; i++)
{
    incomeArray[i] = Console.ReadLine();
}
// visualising incomeArray
Console.Write("[ " + string.Join(", ", incomeArray) + " ] -> ");

int elementsQuantityOfNewArray = 0;

for (int i = 0; i < incomeArray.Length; i++)
{
    if (incomeArray[i].Length < 4)
    {
        elementsQuantityOfNewArray++;
    }
}

    // creating new array
    string[] newArray = new string[elementsQuantityOfNewArray];

    int count = 0;
    for (int i = 0; i < incomeArray.Length; i++)
    {
        if (incomeArray[i].Length < 4)
        {
            newArray[count] = incomeArray[i];
            count++;
        }
    }

    System.Console.WriteLine("[ " + string.Join(", ", newArray) + " ]");