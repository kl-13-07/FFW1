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
            
            
        }

    }
string [] M = {"rsat", "ls", "1", "112", "1л11"};
string [] N = CreateArray (M.Length);

int index = 0;

for (int i = 0; i < M.Length; i++)
{
if (M[i].Length <= 3)




N[index] = M[i];




}


PrintArray (N);











