
int hour = 0;
int sekund = 0;

while (hour < 24)
{

    if (hour < 10)
    {
        Console.Write("0" + hour + ":");
    }
    else
    {
        Console.Write(hour + ":");
    }
    if (sekund < 10)
    {
        Console.WriteLine("0" + sekund);
    }
    else
    {
        Console.WriteLine(sekund);
    }



    if (sekund < 60)
    {
        sekund++;
    }
    if (sekund == 60)
    {
        hour++;
        sekund = (0);
    }
}


