using System.Runtime.Serialization.Formatters;

var birthdays = new DateTime[5];

birthdays[0] = new DateTime(2000, 12, 12);
birthdays[1] = new DateTime(2006, 11, 16);
birthdays[2] = new DateTime(2002, 12, 23);
birthdays[3] = new DateTime(2008, 2, 9);
birthdays[4] = new DateTime(2004, 3, 6);

string[] names = new string[5];
names[0] = "Teshavoy";
names[1] = "Boltavoy";
names[2] = "Taqavoy";
names[3] = "To'xtavoy";
names[4] = "Kenjavoy";

DateTime compare = birthdays[0];
for (var indexA = 0; indexA < birthdays.Length- 1; indexA++)
{
    for (var indexB = indexA + 1; indexB < birthdays.Length; indexB++)
    {
        if (birthdays[indexA].DayOfYear > birthdays[indexB].DayOfYear)
        {
            Console.WriteLine(birthdays[indexB]);
        }
    }
}




