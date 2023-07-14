start:

Random rd = new Random();

string password = "";

Console.WriteLine("Parolda sonlar qatnashsinmi? 1 = HA / 0 = YO'Q: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Parolda harflar qatnashsinmi? 1 = HA / 0 = YO'Q: ");
int word = Convert.ToInt32(Console.ReadLine());
int upperWord = word;
int lowerWord = 0;

Console.WriteLine("Parolda belgilar qatnashsinmi? 1 = HA / 0 = YO'Q: ");
int character = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Parol uzunligini kiriting: ");
int passwordLength = Convert.ToInt32(Console.ReadLine());



for (int i = 0; i <= passwordLength / (num + word + character); i++)
{
    if (num == 1)
    {
        password += (char)rd.Next(48, 58);
    };

    if (upperWord == 1)
    {
        password += (char)rd.Next(61, 91);
        upperWord = 0;
        lowerWord = 1;
    };
    
    if (lowerWord == 1)
    {
        password += (char)rd.Next(97, 123);
        upperWord = 1;
        lowerWord = 0;
    };

    if (character == 1)
    {
        password += (char)rd.Next(33, 48);
    };
};

Console.WriteLine(password);

goto start;


