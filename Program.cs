int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

title = employeeLevel switch
{
    100 => "Junior Associate",
    200 => "Senior Associate",
    300 => "Manager",
    400 => "Senior Manager",
    _ => "Associate",
};

Console.WriteLine($"{employeeName}, {title}");