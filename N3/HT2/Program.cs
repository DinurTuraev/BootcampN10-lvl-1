start:

Console.WriteLine("Email kiriting: ");

string mail = Console.ReadLine();

// Foydalanuvchiga email tavsiya qilish uchun
string recommendation = "";

// ASCII
int strToInt;

// Errorlar bormi yo'qmi aniqlash uchun
Boolean error = false;

// Foydalanuvchi noto'g'ri kiritgan belgilarni ko'rsatish uchun
string emailErrors = "";

for (int i = 0; i < mail.Length; i++)
{
    strToInt = Convert.ToInt32(mail[i]);

    if (strToInt == 46 || strToInt >= 48 && strToInt <= 57 || strToInt >= 64 && strToInt <= 90 || strToInt >= 97 && strToInt <= 122)
    {
        recommendation += mail[i];
    }
    else
    {
        error = true;
        emailErrors += mail[i];
    }
};

if (error == true)
{
    Console.WriteLine($"Emailda harflar, sonlar va @ dan boshqa belgilar qatnashishi mumkin emas!");
    Console.WriteLine($"Siz {emailErrors} dan foydalandingiz");
    Console.WriteLine($"{recommendation} emailini tavsiya qilaman");
}
else
{
    Console.WriteLine("Good");
}

goto start;

