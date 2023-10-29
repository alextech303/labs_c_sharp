/*Задание 2. Квадратный массив. 
a) Ввести с клавиатуры размерность массива, минимальное и максимальное значение. 
Создать квадратный массив и заполнить его случайными числами в диапазоне от минимального до максимального значения. 
    Вывести полученный массив. 
b) Выполнить индивидуальное задание. При необходимости, запросить у пользователя необходимые данные. 
    Вывести полученный результат. */

int min_value;
int max_value;
int size;
Random random = new Random();
input_size:

Console.WriteLine("Введите размерность квадратного массива:");

bool result_size = int.TryParse(Console.ReadLine(), out size);
if (!result_size)
{
    Console.WriteLine("Неверный ввод");

    goto input_size;
}

int[,] array = new int[size,size];

while (true)
{
    Console.WriteLine("Введите min значение массива:");

    if (int.TryParse(Console.ReadLine(), out min_value))
    {
        break;
    }
    else Console.WriteLine("Неверный ввод");
}

while (true)
{
    Console.WriteLine("Введите max значение массива:");

    if (int.TryParse(Console.ReadLine(), out max_value) && max_value> min_value)
    {
        break;
    }
    else Console.WriteLine("Неверный ввод");
}


for (int i = 0; i < size; i++) {
    for(int j = 0; j < size; j++){
        array[i,j]=random.Next(min_value, max_value+1);
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

/*Вариант 8.Если количество строк в массиве четное, то поменять строки местами по правилу: первую строку со второй, 
    третью – с четвертой и т.д. Если количество строк в массиве нечетное, то оставить массив без изменений.*/
Console.WriteLine("____________________");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
       
        if (i%2==0 && i < size-1) { 
        Console.Write($"{array[i+1, j]}\t");
        }
        else Console.Write($"{array[i-1, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();