using Classtasks;

List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  Age = 18,  EduType = "DotNET", Payment = 2400000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  Age = 20,  EduType = "Python", Payment = 2500000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2600000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  Age = 16,  EduType = "SMM", Payment = 2700000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  Age = 17,  EduType = "Dizayn", Payment = 2800000 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  Age = 23,  EduType = "SMM", Payment = 2900000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  Age = 22,  EduType = "Dizayn", Payment = 3000000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2000000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  Age = 19,  EduType = "Python", Payment = 2100000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  Age = 20,  EduType = "Dizayn", Payment = 2500000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  Age = 19,  EduType = "Python", Payment = 2400000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  Age = 16,  EduType = "DotNET", Payment = 2500000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  Age = 24,  EduType = "DotNET", Payment = 2500000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Dilshod O'g'li",  Age = 21,  EduType = "Python", Payment = 2400000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  Age = 25,  EduType = "SMM", Payment = 2300000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  Age = 16,  EduType = "Dizayn", Payment = 2000000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  Age = 23,  EduType = "DotNET", Payment = 2500000 },
};


back:
Console.WriteLine("1 - Talabalar ro'yxati");
string a = Console.ReadLine();

if (a == "1")
{
    foreach (var i in student)
    {
        Console.WriteLine($"{i.Id} - {i.FullName} - {i.Age} - {i.EduType} - {i.Payment}");
    }
}

start:

Console.WriteLine("0 - EXIT");
Console.WriteLine("1 - Python");
Console.WriteLine("2 - SMM");
Console.WriteLine("3 - Dizayn");
Console.WriteLine("4 - DotNET");

string b = Console.ReadLine();

switch (b)
{

    case "0": 
        goto back;

    case "1":
        foreach (var i in student)
        {
            if (i.EduType == "Python")
            {
                Console.WriteLine($"{i.Id} - {i.FullName} - {i.Age} - {i.EduType} - {i.Payment}");
            }
        }
        break;
    case "2":
        foreach (var i in student)
        {
            if (i.EduType == "SMM")
            {
                Console.WriteLine($"{i.Id} - {i.FullName} - {i.Age} - {i.EduType} - {i.Payment}");
            }
        }
        break;
    case "3":
        foreach (var i in student)
        {
            if (i.EduType == "Dizayn")
            {
                Console.WriteLine($"{i.Id} - {i.FullName} - {i.Age} - {i.EduType} - {i.Payment}");
            }
        }
        break;
    case "4":
        foreach (var i in student)
        {
            if (i.EduType == "DotNET")
            {
                Console.WriteLine($"{i.Id} - {i.FullName} - {i.Age} - {i.EduType} - {i.Payment}");
            }
        }
        break;
    default:
        Console.Clear();
        break;
}
goto start;









