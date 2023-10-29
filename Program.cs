
/*Задание 1. Одномерный массив целых чисел. 
a) Ввести с клавиатуры размерность массива, минимальное и максимальное значение. 
Создать одномерный массив и заполнить его случайными числами в диапазоне от минимального до максимального значения. 
    Вывести полученный массив. 
b) Выполнить индивидуальное задание (по вариантам). При необходимости, запросить у пользователя дополнительные данные. 
    Вывести преобразованный массив. */
int min_value;
int max_value;
int size;
int first_max_value=0;

input_size:

Console.WriteLine("Введите размер одномерного массива:");

bool result_size = int.TryParse(Console.ReadLine(), out size);
if (!result_size)
{
    Console.WriteLine("Неверный ввод");
   
    goto input_size;
}
if (result_size) goto create_array;

create_array:
int[] array = new int[size];

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


Random random = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = random.Next(min_value,max_value+1);

}

Console.WriteLine();
foreach (int i in array)
{
    Console.Write(i+"\t");
}

//Вариант_8. Найти индекс первого максимального элемента.

for(int i = 0; i<array.Length; i++)
{

    if (array[i+1]>array[i])
    {
        first_max_value = array[i+1];
        break;
    }

}

Console.WriteLine($"Первое максимальное значение в массиве = {first_max_value}");