/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", ”2”, "world", -> ["2",  “:-)”]
[" 1234, "1567", "-2", "computer science” -> ["-2"]
["Russia", "Denmark", "Kazan”] -> [] */

// Создание массива строк
static string[] CreateArray(int args)
{
    return new string[args];
}

// Печать массива строк
static void PrintArray(string[] array)
{

    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i]);
        Console.Write(";");
    }

}
// создание масива строк М и наполнение его с клавиатуры пользователем
Console.WriteLine("введите длину Массива");

int size_M = Convert.ToInt32(Console.ReadLine());
string[] M = CreateArray(size_M);

for (int j = 0; j < size_M; j++)
{
    Console.WriteLine("введите строку");

    M[j] = Console.ReadLine();
}

// создание массива N
string[] N = CreateArray(M.Length);
int index = 0;

// идём по массиву и переписываем строки длиной менее 3 символов в массив N
for (int i = 0; i < M.Length; i++)

{
    if (M[i].Length <= 3)
    {

        N[index] = M[i];
        index++;
    }

}
//PrintArray(N);

N = N.Where(x => !string.IsNullOrEmpty(x)).ToArray(); // Удаляем пустые строки

Console.WriteLine();

PrintArray(N);













