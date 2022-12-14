// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

void CreateArrayStr(int m)
{
    string arrayStr = String.Empty;
    string countSymbStr = String.Empty;
    string result = String.Empty;

    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} строку массива, затем нажмите Enter: ");
        countSymbStr = Console.ReadLine();
        if (i == 0)
        {
            arrayStr = "[";
        }

        if (i == m - 1)
        {
            arrayStr = $"{arrayStr}\"{countSymbStr}\"]";
        }
        else
        {
            arrayStr = $"{arrayStr}\"{countSymbStr}\", ";
        }

        if (countSymbStr.Length <= 3)
        {
            result = $"{result} \"{countSymbStr}\" ";
        }

    }
    Console.Write($"{arrayStr} -> [{result}]");

}


Console.Write("Введите количество элементов массива строк: ");
int m = Convert.ToInt32(Console.ReadLine());

CreateArrayStr(m);

