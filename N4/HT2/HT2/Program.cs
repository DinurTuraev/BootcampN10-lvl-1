using System.Text.RegularExpressions;

Console.WriteLine("Username kiriting: ");

string userName = Console.ReadLine();

string[] names = {"Abdulloh", "Doston", "Mardon", "Aziza", "Jahona"};
string[] nick = { "Temirchi", "Qassob", "Tandirchi", "G'ilay", "Ishyoqmas" };
userName = userName.Replace(" ", string.Empty);
userName = userName.Replace("!@#", string.Empty);

//userName = Regex.Replace("!@#$%^&*()_+", "").Replace(" ", "");

userName = Regex.Replace(userName, @"[!@#$%^&*()_+';/~`?><,.]", "");

Random rd = new Random();

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == userName)
    {
        userName += nick[rd.Next(0, 4)];
    }
}

//userName += nick[rd.Next(0, 4)];

Console.WriteLine(userName);