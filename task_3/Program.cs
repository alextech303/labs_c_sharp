/*Задание 3 . Зубчатый массив 
 
a) Ввести с клавиатуры размерность массива n, минимальное и максимальное значение. 
Создать зубчатый массив. Длина каждой строки выбирается случайным образом от 1 до n. 
    Заполнить массив случайными числами в диапазоне от минимального до максимального значения. Вывести полученный массив. 
b) Выполнить индивидуальное задание. При необходимости, запросить у пользователя необходимые данные. 
    Вывести полученный результат.*/


int min_value;
int max_value;
int size;
int compare_naumber;
int count=0;
Random random = new Random();
input_size:

Console.WriteLine("Введите размерность зубчатого массива:");

bool result_size = int.TryParse(Console.ReadLine(), out size);
if (!result_size)
{
    Console.WriteLine("Неверный ввод");

    goto input_size;
}

int[][] array = new int[size][];

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


Random random_number = new Random();



for (int i = 0; i < size; i++)
{
   
    array[i]=new int[random_number.Next(1, size+1)];
    for (int j = 0; j < array[i].Length; j++)
    {
        array[i][j]=random.Next(min_value, max_value+1);
        Console.Write($"{array[i][j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();



Console.WriteLine(" Вариант_8. Для каждой строки подсчитать количество элементов,\n"+
    "больших заданного числа, записать данные в новый массив.");
Console.WriteLine();
while (true)
{
    Console.WriteLine("Введите число для сравнения с элементами строки зубчатого массива:");

    if (int.TryParse(Console.ReadLine(), out compare_naumber))
    {
        break;
    }
    else Console.WriteLine("Неверный ввод");
}

for (int i = 0; i < size; i++){
  for (int j = 0; j < array[i].Length; j++)
    {
        if (array[i][j]>compare_naumber)
        {
            count++;
        }
   }
    Console.Write($"для строки {i} количество элементов больше числа {compare_naumber} = {count}\t");
    count=0;
    Console.WriteLine();
}
Console.WriteLine();

Console.ReadKey();