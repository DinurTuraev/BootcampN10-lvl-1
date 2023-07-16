string txt = "Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!";
var massiv = txt.Split();

var total = 100;

if (massiv.Length < 500)
{
    total -= 5;
}

for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i].Length > 20)
    {
        Console.WriteLine("entered");
        total -= 20;
        break;
    }
}
int count = 0;

for (int i = 0; i < massiv.Length; i++)
{
    if (count > massiv.Length * 0.2)
    {
        total -= 5;
        break;
    }

    for (int j = 0; j < massiv.Length; j++)
    {
        if (massiv[i].Equals(massiv[j], StringComparison.Ordinal))
        {
            count++;
        }
    }
}

string[] massiv2 = txt.Split(". ");

for (int i = 0; i < massiv2.Length; i++)
{
    if (Convert.ToInt32(massiv2[i][0]) >= 97 && Convert.ToInt32(massiv2[i][0]) <= 122)
    {
        total -= 5;
    }
}

bool stop = false;
for (int i = 0; i < massiv.Length; i++)
{
   
    for (int j = 1; j < massiv[i].Length; j++)
    {
        if (Convert.ToInt32(massiv[i][j]) >= 65 && Convert.ToInt32(massiv[i][j]) <= 90)
        {
            stop = true;
        }
    }
    if (stop)
    {
        Console.WriteLine("hi");
        total -= 5;
        break;
    }
}
Console.WriteLine(total);
