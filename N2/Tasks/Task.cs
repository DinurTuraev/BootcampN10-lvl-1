Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter your last name: ");
string lastname = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("ism: {0}, sharif: {1}, age: {2}", name, lastname, age);


DateTime today = DateTime.Today;
Console.WriteLine(today);

string date = "1970-yil 1-yanvar";
Console.WriteLine(date);

int age1 = 75;
Console.WriteLine(age1);

double money = 35.5;
Console.WriteLine(money);

string nickname = "MAX DEVELOPER";
Console.WriteLine(nickname);

// Primitive and Value
int a = 121;
Console.WriteLine(a);

char b = 'a';
Console.WriteLine(b);

// Complex and referance
string c = "SpaceX";
Console.WriteLine(c);

string[] companies = new string[]{"Apple", "Samsung", "Dell"};

for (int i = 0; i < companies.Length; i++)
{
    Console.WriteLine(companies[i]);
}