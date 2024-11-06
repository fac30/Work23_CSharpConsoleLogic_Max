string[] characters = ["Monster", "Hero"];
int[] charactersHealth = [10, 10];
Random attack = new();
int turnCount = 0;
int damagedIndex;

do
{
    int damage = attack.Next(1, 11);
    damagedIndex = turnCount % 2;
    charactersHealth[damagedIndex] -= damage;
    Console.WriteLine($"{characters[damagedIndex]} was damaged and lost {damage} health and now has {charactersHealth[damagedIndex]} health.");
    turnCount++;
} while (charactersHealth[0] > 0 && charactersHealth[1] > 0);

Console.WriteLine($"{characters[Math.Abs(damagedIndex-1)]} wins!");