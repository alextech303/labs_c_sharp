

bool x;
bool y;

while (true)
{
    Console.WriteLine("Введите значение x :");

if (bool.TryParse(Console.ReadLine(), out x))
{
    break;
}
else Console.WriteLine("Неверный ввод");
}

while (true)
{
    Console.WriteLine("Введите значение y :");

    if (bool.TryParse(Console.ReadLine(), out y))
    {
        break;
    }
    else Console.WriteLine("Неверный ввод");
}


m(x, y);
void m(bool x,bool y)
{
    bool a = x & y;
    bool b = x | y;
    bool c = x ^ y;
    Console.WriteLine("x & y = "+a);
    Console.WriteLine("x | y = "+b);
    Console.WriteLine("x ^ y = "+c);
}