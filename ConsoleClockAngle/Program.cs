// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type hour: ");
float hour;
while (true)
{

    if (float.TryParse(Console.ReadLine(), out hour))
    {
        Console.WriteLine("hour added");
        break;
    }
    else
    {
        Console.WriteLine("Enter correct format of hour: ");
    }
}
Console.WriteLine("Type minutes: ");
float minutes;
while (true)
{

    if (float.TryParse(Console.ReadLine(), out minutes))
    {
        Console.WriteLine("minutes added");
        break;
    }
    else
    {
        Console.WriteLine("Enter correct format of minutes: ");
    }
}

float smallHandOfClockAngle;
float bigHandOfClockAngle;

smallHandOfClockAngle = hour * 30 + (minutes/60)*30;
//every next hour gives us 30 degrees, because whole clock is 360 degrees - 360 divided by 12 is 30

bigHandOfClockAngle = minutes * 6;

float finalAngleScore;

if(smallHandOfClockAngle>bigHandOfClockAngle)
{
    finalAngleScore = smallHandOfClockAngle - bigHandOfClockAngle;
    Console.WriteLine($"Angle is {finalAngleScore}");
}
else if(bigHandOfClockAngle> smallHandOfClockAngle)
{
    finalAngleScore = bigHandOfClockAngle - smallHandOfClockAngle;
    Console.WriteLine($"Angle is {finalAngleScore}");
}

