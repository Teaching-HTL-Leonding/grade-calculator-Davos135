Console.Write(" Have you participated in the first written exam ?");
string TEST = Console.ReadLine()!;
int points = 0;
int maxpoints = 0;
if (TEST == "yes")
{
    Console.Write("How many points do you got in the first written exam ?");
    points += int.Parse(Console.ReadLine()!);
    maxpoints += 20;
}

Console.Write("Have you participated in the second written exam");
string TEST2 = Console.ReadLine()!;
if (TEST2 == "yes")
{
    Console.Write(" How many points do you got in the second written exam ?");
    points += int.Parse(Console.ReadLine()!);
    maxpoints += 20;
}


int percent = points / maxpoints * 100;






 if (TEST == "no")
{
    Console.Write(" How many points do you got in the second written exam ?");
     points += int.Parse(Console.ReadLine()!);
    maxpoints +=20;
}
    
    int percent1 = points / maxpoints * 100;


    if (percent >= 90)
    {
        Console.Write(" You grade is: 1");

    }
    else if (percent >= 76)
    {
        Console.Write("You grade is: 2");


    }
    else if (percent >= 63)
    {
        Console.Write("You grade is: 3");

    }
    else if (percent >= 50)
    {

        Console.Write("You grade is: 4");
    }
    else if (percent < 50)

    {
        Console.Write("You grade is: 5");
    }




