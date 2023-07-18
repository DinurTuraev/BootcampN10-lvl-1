int[] points = new int[5];

points[0] = 45;
points[1] = 84;
points[2] = 99;
points[3] = 56;
points[4] = 64;

string[] names = new string[5];

names[0] = "Jo'rabek";
names[1] = "Og'abek";
names[2] = "Otabek";
names[3] = "Dostonbek";
points[4] = "Javlonbek";

Console.WriteLine(points.Max);
Console.WriteLine(points.Average);
Console.WriteLine(points.Min);
int count80 = 0;
int count90 = 0;
for (int i = 0; i < points.Length; i++)
{
    if (points[i] > 80) {
        count80++;
    }
    if (points[i] > 90)
    {
        count90++;
    }
}

Console.WriteLine($"80 dan baland ball olganlar {count80}");
Console.WriteLine($"90 dan baland ball olganlar {count90}");

for (int i = 0; i < points.Length-1; i++)
{
    for (int j = i + 1; j < points.Length; j++)
    {
        int index = points[j];
        names[j], points[j] = points[i];
        names[i], points[i] = index;
    }
}

for (int i = 0;i < points.Length; i++)
{
    Console.WriteLine($"{names[i]} - {points[i]}")
}
