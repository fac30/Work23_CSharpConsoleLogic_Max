string? roleName;
bool isValidInput = false;
string instruction = "Enter your role name (Administrator, Manager, or User).";

Console.WriteLine(instruction);

do
{
    roleName = Console.ReadLine();
    if (roleName != null)
    {
        string roleNameProcessed = roleName.Trim().ToLower();
        if (roleNameProcessed == "administrator" || roleNameProcessed == "manager" || roleNameProcessed == "user")
        {
            isValidInput = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{roleName}\" is not valid. {instruction}");
        }
    }
    else
    {
        Console.WriteLine($"Invalid input. {instruction}");
    }
}
while (!isValidInput);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");