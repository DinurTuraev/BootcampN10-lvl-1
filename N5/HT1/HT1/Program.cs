string[] questions = {"O'zbekiston poytaxti?", "Amir Temur qachon tug'ilgan?"};

string[] correct = {"Toshkent", "1336" };
string[] wrong = { "Antananarivu", "1363" };
int point = 0;

Random rd = new Random();

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine(questions[i]);
    if (rd.Next(0, 2) == 1)
    {
        Console.WriteLine($"A: {correct[i]}");
        Console.WriteLine($"B: {wrong[i]}");
        Console.WriteLine("Javob kiriting: A/B");
        var answer = Console.ReadLine();
        if (answer.Equals("A", StringComparison.OrdinalIgnoreCase))
        {
            point += 10;
        }
    }
    else
    {
        Console.WriteLine($"A: {wrong[i]}");
        Console.WriteLine($"B: {correct[i]}");
        Console.WriteLine("Javob kiriting: A/B");
        var answer = Console.ReadLine();
        if(answer.Equals("B",StringComparison.OrdinalIgnoreCase))
        {
            point += 10;
        }
    }
}

Console.WriteLine($"Your score: {point}");





