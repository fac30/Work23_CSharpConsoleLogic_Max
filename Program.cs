int numberInt = 0;
bool isValidInt = false;
bool isValidInput = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    string? numberString = Console.ReadLine();
    isValidInt = int.TryParse(numberString, out numberInt);
    if (isValidInt)
    {
        if (numberInt < 5 || numberInt > 10)
        {
            Console.WriteLine($"You entered {numberInt}. Please enter a number between 5 and 10.");
        }
        else
        {
            isValidInput = true;
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
}
while (!isValidInput);

Console.WriteLine($"Your input value ({numberInt}) has been accepted.");