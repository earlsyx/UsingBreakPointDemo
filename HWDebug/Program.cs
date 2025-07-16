

// For Loop - multiplies a number by five , add it to the total each time.
//ex. 

Console.WriteLine("Number multiplier by five");
Console.WriteLine("*************************");



int totalNumber = 0;
static int GetNumber()
{
    bool isValidNumber = false;
    int number = 0;
    do
    {
        Console.Write("Give a number to be multiplied by five: ");
        string numberText = Console.ReadLine();
        isValidNumber = int.TryParse(numberText, out number); 
    } while (isValidNumber == false);

    return number;
    

}

static bool Continue()
{

    Console.WriteLine("Continue adding number? (yes/no): ");
    string answer = Console.ReadLine();
    return (answer.ToLower() == "yes");
}

bool continueLooping = false; 

    do
    {
       totalNumber += GetNumber() * 5;
       continueLooping = Continue();
    } while (continueLooping);

Console.WriteLine($"TotalNumber: {totalNumber}");



