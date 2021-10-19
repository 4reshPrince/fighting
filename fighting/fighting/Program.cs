using System;

Console.WriteLine(@" ____  _        _   _               _ ");
Console.WriteLine(@"|  _ \(_) ___  | | | | __ _ _ __ __| |");
Console.WriteLine(@"| | | | |/ _ \ | |_| |/ _` | '__/ _` |");
Console.WriteLine(@"| |_| | |  __/ |  _  | (_| | | | (_| |");
Console.WriteLine(@"|____/|_|\___| |_| |_|\__,_|_|  \__,_|");
Console.WriteLine();
Console.WriteLine("Press 'Enter' to continue");

Console.ReadLine();
Console.Clear();

int JohnMcClaneHp = 100;
int HansGruberHp = 100;

string answer1 = "";


while (answer1 != "a" && answer1 != "john mcclane" && answer1 != "b" && answer1 != "hans gruber")
{
    Console.WriteLine("Character Menu");
    Console.WriteLine();
    Console.WriteLine("John McClane");
    Console.WriteLine();
    Console.WriteLine("Hans Gruber");
    Console.WriteLine();
    Console.WriteLine("Write your choice of character");

    answer1 = Console.ReadLine().ToLower();
    Console.Clear();
}

if (answer1 == "a" || answer1 == "John McClane")
{
    Console.WriteLine("");
}
else if (answer1 == "b" || answer1 == "HansGruber")
{
    Console.WriteLine("");
}

Random generator = new Random();

while (JohnMcClaneHp > 0 && HansGruberHp > 0)
{

    int damage = generator.Next(5, 20);
    JohnMcClaneHp = JohnMcClaneHp - damage;

    if (JohnMcClaneHp < 0)
    {
        JohnMcClaneHp = 0;
    }

    int damage2 = generator.Next(5, 20);
    HansGruberHp = HansGruberHp - damage2;

    if (HansGruberHp < 0)
    {
        HansGruberHp = 0;
    }

    Console.WriteLine("John McClane Punches Hans Gruber " + JohnMcClaneHp);
    Console.WriteLine("Hans Gruber Punches John McClane " + HansGruberHp);
    Console.ReadLine();
    
}

if (JohnMcClaneHp > 0)
{
    Console.WriteLine("John and Hans are at the 60 floor, Hans is standing by the broken window and John is standing in front of him and kicks him out so that Hans falls to his death.");
}
else
{
    Console.WriteLine("John got shot by Hans and died.");
}

Console.ReadLine();
Console.Clear();