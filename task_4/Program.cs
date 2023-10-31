using System;
/*Метод принимает 2 параметра   bool и получает результат всех булевых
 операций над результат всех булевых операций над ними ( &, |, ^).
 Возвращение результата – на ваше усмотрение. */
    
   
bool x;
bool y;
int count = 0;

while (true)
{
    Console.WriteLine("Введите значение параметра x :");

if (bool.TryParse(Console.ReadLine(), out x))
{
    break;
}
else Console.WriteLine("Неверный ввод");
}

while (true)
{
    Console.WriteLine("Введите значение параметра y :");

    if (bool.TryParse(Console.ReadLine(), out y))
    {
        break;
    }
    else Console.WriteLine("Неверный ввод");
}


bool[] m(bool x,bool y)
{
    bool a = x & y;
    bool b = x | y;
    bool c = x ^ y;
    bool[] array = new bool[3];
    array[0]=a;
    array[1]=b;
    array[2]=c;
    return array;
}

m(x, y);

foreach (bool result in m(x, y))
{
    if (count==0)  
        Console.WriteLine("x & y = "+result);
           
    if (count==1)
        Console.WriteLine("x | y = "+result);
            
    if (count==2)
         Console.WriteLine("x ^ y = "+result);
    count++;
}

