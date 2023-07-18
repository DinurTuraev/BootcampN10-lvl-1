DateTime[] birthdates = new DateTime[5];

birthdates[0] = new DateTime(2000, 1, 1);
birthdates[1] = new DateTime(2001, 12, 19);
birthdates[2] = new DateTime(2000, 3, 31);
birthdates[3] = new DateTime(2000, 8, 27);
birthdates[4] = new DateTime(2000, 9, 5);

string[] names = new string[5];

names[0] = "Otabek";
names[1] = "Yusufbek-xoji";
names[2] = "Mirzakarim-qutidor";
names[3] = "Homid-Sodiq";
names[4] = "Hasanali";


Console.WriteLine(birthdates[0].DayOfYear);


for  (int i = 0; i < birthdates.Length - 1; i++)
{
    for (int j = i + 1; j < names.Length; j++)
    {
        if (birthdates[i].DayOfYear > birthdates[j].DayOfYear)
        {
            DateTime a = birthdates[j];
            birthdates[j] = birthdates[i];
            birthdates[i] = birthdates[j];
        }
    }
}

for (int i = 0;i < birthdates.Length; i++)
{
    Console.WriteLine($"{names[i]} - {birthdates[i]}");
}

