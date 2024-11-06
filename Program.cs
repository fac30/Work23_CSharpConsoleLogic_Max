Random coinFLipper = new();
int isHeads = coinFLipper.Next(2);

Console.WriteLine((isHeads == 0)? "tails": "heads");